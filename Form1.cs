﻿using Microsoft.Win32;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WebBruteForcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Pool pool { get; private set; }
        public Workers workers { get; private set; }
        public bool bruteforce_running { get; private set; }
        public string url_to_bruteforce { get; private set; }
        public bool show404 { get; private set; }
        public string dictionary { get; private set; }
        public string post_data_to_send { get; private set; }
        public string title { get; private set; }
        public string method { get; private set; }
        public string dictionaries_folder { get; private set; }
        public List<string> debug { get; private set; }
        public string req_headers_to_send { get; private set; }
        public bool break_on_errors { get; private set; }
        public bool hide_lines_checked { get; private set; }
        public string hide_lines { get; private set; }
        public WorkersPanelControl workers_panel { get; private set; }

        public void do_work(Worker worker)
        {
            download_url(worker, url_to_bruteforce, post_data_to_send, req_headers_to_send);
        }

        private WorkerResults analyze_results(Worker worker)
        {
            WorkerResults wr = new WorkerResults(worker);
            if (worker.result == null || worker.result.Length.Equals(0)) return wr;
            string response = Encoding.ASCII.GetString(worker.result);
            string[] lines = response.Split('\n');
            wr.first_line = lines[0].Trim();
            string[] cols = wr.first_line.Split(' ');
            if (cols.Length < 3)
                throw new Exception("Unknown response " + wr.first_line);
            wr.response_code = cols[1];
            wr.response_code_long = string.Join(" ", cols.Skip(1));
            wr.headers = lines.Skip(1).Select(header => header.TrimEnd()).Where(header => header.Length > 0);
            return wr;
        }

        private void flush_work(Worker worker)
        {
            if (worker.running || worker.avail || worker.payload == null) return;
            if (worker.error != null)
            {
                if (break_on_errors == false) return;
                Console.WriteLine(worker.error.ToString());
                if (worker.error.ErrorCode.Equals(11001))
                {
                    if (this.bruteforce_running)
                    {
                        this.bruteforce_running = false;
                        MessageBox.Show(string.Format("Error Downloading URL:{0}{0}{1}{0}{0}Error:{0}{0}{2}{0}{0}{3}",
                            Environment.NewLine, worker.uri, worker.error, "BruteForcer Canceled ..."),
                            "Flush Work", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw worker.error;
                }
                return;
            }
            WorkerResults wr = analyze_results(worker);
            bool silent = wr.response_code != null && wr.response_code.Equals("404") && show404.Equals(false);
            int lines_count = wr.headers != null ? wr.headers.Count() : 0;
            silent = this.hide_lines_checked && this.hide_lines!=null && this.hide_lines.Equals(lines_count.ToString()) ? true : silent;
            if (!silent)
            {
                string headers_debug_line = wr.headers != null ? string.Join(" | ", wr.headers) : "";
                int max_debug_line_len = 1024 * 10;
                if (headers_debug_line.Length > max_debug_line_len)
                    headers_debug_line = headers_debug_line.Substring(0, max_debug_line_len);
                rtbResults.AppendText(string.Format(
                    "[ {0,-24} ] {1,-35} [ {2,6} {3,7} ] {4}{5}",
                        worker.payload,
                        wr.first_line,
                        lines_count,
                        wr.headers != null ? string.Join("", wr.headers).Length : 0,
                        wr.headers != null ? headers_debug_line : "",
                        Environment.NewLine));
                write_to_log(wr);
            }
            lock (worker)
            {
                worker.Clean();
                worker.avail = true;
            }
        }
        private void InitBruteForcer()
        {
            tsUrlText.Text = "https://yoire.com/[payload]";
            LoadWorkersPanel();
            LoadConfig();
            if (!update_available_dictionaries())
            {
                this.dictionaries_folder = Directory.GetCurrentDirectory() + @"\dictionaries";
                this.dictionary = this.dictionaries_folder + @"\wordlist.txt";
                update_available_dictionaries();
            }

            load_dictionary(this.dictionary);
        }

        private void LoadWorkersPanel()
        {
            workers_panel = new WorkersPanelControl();
            splitContainer2.Panel2.Controls.Add(workers_panel);
            ResizeWorkersPanel();
        }

        private void ResizeWorkersPanel()
        {
            splitContainer2.SplitterDistance = Width - workers_panel.getWidth() - 25;            
        }

        private void load_dictionary(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("Can't open file " + filename, "Load Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string[] lines = System.IO.File.ReadAllLines(filename);
            pool = new Pool();
            pool.AddItems(lines);

            this.dictionary = filename;

            tsRunButton.Text = "Bruteforce";

            UpdateTitle();
            pool_count();
            Debug("Dictionary " + Path.GetFileName(filename) + " loaded");
            Debug(string.Join(" ", lines.Take(5)));
        }

        private void UpdateTitle()
        {
            if (this.title == null)
                this.title = Text;
            string msg = "not initialized";
            if (this.workers != null)
                msg = workers.Count().ToString();
            string last = "";
            if (this.workers != null && this.workers.Count() > 0)
            {
                if (this.workers.getAll()[0].uri != null)
                    last = " - last: " + this.workers.getAll()[0].uri.AbsoluteUri;
            }
            Text = string.Format("{0} - WL {1} - Method {2} - Workers {3} - BF {4} {5}",
                this.title, Path.GetFileName(this.dictionary), this.method, msg, bruteforce_running ? "Running" : "Idle", last);
            if (tsLowPanelInfoButton.Text.Equals("PANELINFO"))
            {
                if (this.method.Equals("POST"))
                    show_panel_info("Post Data");
                else
                    show_panel_info("Headers");
            }
            Debug(Text);
            if (tsLowPanelInfoButton.Text.Equals("Debug"))
                show_panel_info("Debug");
            ResizeControls();
            SaveConfig();
        }
        private void Debug(string msg)
        {
            bool inDebug = tsLowPanelInfoButton.Text.Equals("Debug");
            if (this.debug == null)
                this.debug = new List<string>();
            this.debug.Add(msg);
            if (inDebug)
            {
                refresh_Debug();
            }
        }

        private bool update_available_dictionaries()
        {
            string dictionaries_path = getDictionariesPath();
            if (!Directory.Exists(dictionaries_path))
                return false;
            tsDictMenu.DropDownItems.Clear();
            string[] fileEntries = Directory.GetFiles(dictionaries_path);
            foreach (string filename in fileEntries)
            {
                ToolStripItem ts_item = tsDictMenu.DropDownItems.Add(Path.GetFileName(filename));
                ts_item.Tag = filename;
                ts_item.Click += dictionary_clicked;
                if (!File.Exists(this.dictionary) && filename.Contains("wordlist"))  // set default dict
                    this.dictionary = filename;
            }
            return true;
        }

        private string getDictionariesPath()
        {
            return this.dictionaries_folder == null ? @"..\..\dictionaries" : this.dictionaries_folder;
        }

        private void dictionary_clicked(object sender, EventArgs e)
        {
            ToolStripItem ts_item = (ToolStripItem)sender;
            load_dictionary((string)ts_item.Tag);
        }

        private void BruteForce()
        {
            if (
                (method.Equals("HEAD") || method.Equals("GET")) && !url_to_bruteforce.Contains("[payload]") && !req_headers_to_send.Contains("[payload]") ||
                (method.Equals("POST") && !url_to_bruteforce.Contains("[payload]") && !req_headers_to_send.Contains("[payload]") && !post_data_to_send.Contains("[payload]"))
                )
            {
                bruteforce_running = false;
                MessageBox.Show("Missing [payload] tag in Url, Headers or Post Data", "BruteForce Urls using " + this.method, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (workers != null)
                workers.StopAll();
            if (bruteforce_running)
            {
                bruteforce_running = false;
                return;
            }
            if (pool_count().Equals(0))
                load_dictionary(this.dictionary);
            bruteforce_running = true;
            tsRunButton.Text = "Pause Bruteforce";
            workers = new Workers(50, workers_panel);
            Debug("Total workers: " + workers.Count());
            UpdateTitle();
            WriteConfigToLog();
            Application.DoEvents();
            do
            {
                do
                {
                    Worker worker = workers.getAvail();
                    if (worker == null) break;

                    string item = pool.PopItem();
                    if (item == null)
                        break;
                    worker.payload = item;
                    worker.action = do_work;
                    worker.Run();
                } while (true);
                workers.updateControls();
                int pool_remain = pool_count();

                lock (workers)
                {
                    foreach (Worker worker in workers.getAll())
                        flush_work(worker);
                }
                if (pool_remain.Equals(0))
                {
                    lock (workers)
                    {
                        do
                        {
                            workers.updateControls();
                            bool running = workers.getAll().Any(worker => worker.running);
                            if (!running)
                                break;
                            Application.DoEvents();
                            Thread.Sleep(3);

                        } while (true);
                        foreach (Worker worker in workers.getAll())
                            flush_work(worker);
                    }
                    break;
                }
                Application.DoEvents();
            } while (bruteforce_running);
            tsRunButton.Text = pool_count() > 0 ? "Resume Bruteforce" : "Bruteforce";
            bruteforce_running = false;
            workers.updateControls();
            UpdateTitle();
            if (pool_count() > 0)
                Debug("Payloads left: " + pool_count());
        }

        private int pool_count()
        {
            if (pool == null)
                return 0;
            int count = pool.items.Length;
            tsDictMenu.Text = count.Equals(0) ? Path.GetFileName(this.dictionary) : Path.GetFileName(this.dictionary) + " ( " + count.ToString() + " payloads )";
            ResizeControls();
            return count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBruteForcer();
        }
        private void download_url(Worker worker, string download_url_template, string post_data_template = null, string req_headers_template = null)
        {
            Uri uri = new Uri(download_url_template.Replace("[payload]", worker.payload));
            string post_data = post_data_template.Replace("[payload]", worker.payload);
            string req_headers = req_headers_template.Replace("[payload]", worker.payload);
            worker.uri = uri;

            List<string> send_headers_list = new List<string>();
            send_headers_list.Add(method + " " + uri.PathAndQuery + " HTTP/1.0");
            send_headers_list.Add("Host: " + uri.Host + ":" + uri.Port);
            send_headers_list.Add("User-Agent: Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36");
            send_headers_list.Add("Accept: */*");
            if (req_headers != null && req_headers != "")
            {
                foreach (string header in req_headers.Split('\n').Select(h => h.Trim()))
                {
                    string[] cols = header.Split(':');
                    send_headers_list = send_headers_list.Where(h => !h.StartsWith(cols[0])).ToList();
                    send_headers_list.Add(header);
                }
            }
            if (method.Equals("POST"))
            {
                send_headers_list.Add("Content-Length: " + post_data.Length);
                send_headers_list.Add("Content-Type: application/x-www-form-urlencoded");
                send_headers_list.Add("");
                send_headers_list.Add(post_data);
            }
            else
            {
                send_headers_list.Add("");
                send_headers_list.Add("");
            }
            string send_headers = string.Join(Environment.NewLine, send_headers_list);            

            if (uri.Scheme.Equals("https"))
                download_url_SSL(worker, uri, post_data, req_headers, send_headers);
            else
                download_url_noSSL(worker, uri, post_data, req_headers, send_headers);

        }
        private void download_url_SSL(Worker worker, Uri url, string post_data, string req_headers, string send_headers)
        {
            RemoteCertificateValidationCallback DefaultCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                ServerSocket.Connect(url.Host, url.Port);
            }
            catch (SocketException se)
            {
                worker.error = se;
                return;
            }
            Stream ServerStream = new NetworkStream(ServerSocket, false);
            var sslServerStream = new SslStream(ServerStream, false, DefaultCertificateValidationCallback);
            sslServerStream.AuthenticateAsClient(url.Host, null, SslProtocols.Tls12, false);
            ServerStream = sslServerStream;
            ServerStream.ReadTimeout = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            var writer = new StreamWriter(ServerStream, Encoding.ASCII, 8192, true);

            writer.WriteLine(string.Join(Environment.NewLine, send_headers));
            writer.Flush();

            byte[] result = new byte[0];
            byte[] buffer = new byte[1024 * 100];
            int max_body_download_limit = 1024 * 5000; //5MB
            do
            {
                int readed = 0;
                try
                {
                    readed = ServerStream.Read(buffer, 0, buffer.Length);
                    if (readed.Equals(0))
                        break;
                }
                catch (Exception)
                {
                    break;
                }
                result = result.Concat(buffer.Take(readed).ToArray()).ToArray();
                if (result.Length > max_body_download_limit)
                    break;
            } while (true);
            try
            {
                ServerStream.Close();
            }
            catch (Exception) { }
            while (result.Length > 0 && result[0].Equals(0))
                result = result.Skip(1).ToArray();
            worker.result = result;
        }
        private void download_url_noSSL(Worker worker, Uri url, string post_data, string req_headers, string send_headers)
        {
            Socket ServerSocket = null;
            try
            {
                IPHostEntry ipHostInfo = Dns.GetHostEntry(url.Host);
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, url.Port);
                ServerSocket = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                ServerSocket.Connect(remoteEP);
            }
            catch (SocketException se)
            {
                worker.error = se;
                return;
            }

            byte[] result = new byte[0];
            byte[] bytes = new byte[1024];
            int max_body_download_limit = 1024 * 5000; //5MB

            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(send_headers);
                int bytesSent = ServerSocket.Send(msg);

                while (true)
                {
                    int bytesRec = ServerSocket.Receive(bytes);
                    if (bytesRec.Equals(0)) break;
                    bytes = bytes.Take(bytesRec).ToArray();
                    result = result.Concat(bytes).ToArray();
                    if (result.Length > max_body_download_limit)
                        break;
                }
            }
            catch (Exception) { };
            ServerSocket.Shutdown(SocketShutdown.Both);
            ServerSocket.Close();
            worker.result = result;
        }

        private void tsRunButton_Click(object sender, EventArgs e)
        {
            url_to_bruteforce = tsUrlText.Text;
            post_data_to_send = rtbPostData.Text;
            req_headers_to_send = rtbHeaders.Text;
            UpdateTitle();
            BruteForce();
        }

        private void write_to_log(WorkerResults wr)
        {
            string headers_debug_line = wr.headers != null ? string.Join(" | ", wr.headers) : "";
            string line = string.Format(
                "[ {0,-24} ] {1,-35} [ {2,6} {3,7} ] {4}{5}",
                    wr.worker.payload,
                    wr.first_line,
                    wr.headers != null ? wr.headers.Count() : 0,
                    wr.headers != null ? string.Join("", wr.headers).Length : 0,
                    wr.headers != null ? headers_debug_line : "",
                    Environment.NewLine);
            File.AppendAllText(@"logs\" + wr.worker.uri.Host + "-bf_results.txt", line);

            json_data data = new json_data();
            data.payload = wr.worker.payload;
            data.uri = wr.worker.uri;
            data.first_line = wr.first_line;
            data.result = wr.worker.result;
            string jsonString = JsonConvert.SerializeObject(data);
            File.AppendAllText(@"logs\" + wr.worker.uri.Host + "-bf_results.json", jsonString + Environment.NewLine);
        }

        public class json_data
        {
            public string payload;
            public Uri uri;
            public string first_line;
            public byte[] result;
        }
        private void CheckLogsDir()
        {
            if (!Directory.Exists("logs"))
                Directory.CreateDirectory("logs");
        }

        private void WriteConfigToLog()
        {
            CheckLogsDir();
            json_config_data data = new json_config_data();
            data.url_to_bruteforce = this.url_to_bruteforce;
            data.method = this.method;
            data.show404 = this.show404;
            data.hide_lines = this.hide_lines;
            data.hide_lines_checked = this.hide_lines_checked;
            data.break_on_errors= this.break_on_errors;
            data.dictionaries_folder = this.dictionaries_folder;
            data.dictionary = this.dictionary;
            data.post_data_to_send = this.method.Equals("POST") ? this.post_data_to_send : "";
            data.req_headers_to_send = this.req_headers_to_send;
            string hostname = "hostname";
            try
            {
                Uri uri = new Uri(url_to_bruteforce);
                hostname = uri.Host;
            }
            catch (Exception) { }
            string jsonString = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.AppendAllText(@"logs\" + hostname + "-config.json", jsonString + Environment.NewLine);
        }
        public class json_config_data
        {
            public string url_to_bruteforce;
            public string method;
            public bool show404;
            public bool break_on_errors;
            public bool hide_lines_checked;
            public string hide_lines;
            public string dictionaries_folder;
            public string dictionary;
            public string post_data_to_send;
            public string req_headers_to_send;
        }

        private void LoadConfig()
        {
            RegistryKey key = KeyConfig();
            this.url_to_bruteforce = (string)key.GetValue("url");
            this.method = key.GetValue("method") != null ? (string)key.GetValue("method") : "HEAD";
            this.show404 = key.GetValue("show404") == null || key.GetValue("show404").Equals("True");
            this.break_on_errors = key.GetValue("break_on_errors") == null || key.GetValue("break_on_errors").Equals("True");
            this.hide_lines_checked = key.GetValue("hide_lines_checked") != null && key.GetValue("hide_lines_checked").Equals("True");
            this.hide_lines = (string)key.GetValue("hide_lines");
            this.dictionaries_folder = (string)key.GetValue("dictionaries_folder");
            this.dictionary = (string)key.GetValue("dictionary");
            this.post_data_to_send = (string)key.GetValue("post_data");
            this.req_headers_to_send = (string)key.GetValue("req_headers");

            if (this.url_to_bruteforce != null)
                tsUrlText.Text = this.url_to_bruteforce;
            if (this.post_data_to_send != null)
                rtbPostData.Text = this.post_data_to_send;
            if (this.req_headers_to_send != null)
                rtbHeaders.Text = this.req_headers_to_send;
            if (this.hide_lines != null)
                tsHideLinesTextbox.Text = this.hide_lines;
            show404ResponsesToolStripMenuItem.Checked = this.show404;
            breakOnErrorsToolStripMenuItem.Checked = this.break_on_errors;
            hideLinesToolStripMenuItem.Checked = this.hide_lines_checked;
            SetMethod(this.method);
        }
        private void SaveConfig()
        {
            RegistryKey key = KeyConfig();
            if (this.url_to_bruteforce != null) key.SetValue("url", this.url_to_bruteforce);
            if (this.method != null) key.SetValue("method", this.method);
            if (this.dictionaries_folder != null) key.SetValue("dictionaries_folder", this.dictionaries_folder);
            if (this.dictionary != null) key.SetValue("dictionary", this.dictionary);
            if (this.hide_lines != null) key.SetValue("hide_lines", this.hide_lines);
            if (this.post_data_to_send != null) key.SetValue("post_data", this.post_data_to_send);
            if (this.req_headers_to_send != null) key.SetValue("req_headers", this.req_headers_to_send);
            key.SetValue("show404", this.show404);
            key.SetValue("break_on_errors", this.break_on_errors);
            key.SetValue("hide_lines_checked", this.hide_lines_checked);
        }
        private RegistryKey KeyConfig()
        {
            return Registry.CurrentUser.CreateSubKey(@"SOFTWARE\\WebBruteForcer");
        }

        private void show404ResponsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.show404 = show404ResponsesToolStripMenuItem.Checked;
            SaveConfig();
        }


        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
        }

        private void tsPoolCountLabel_Click(object sender, EventArgs e)
        {
            load_dictionary(this.dictionary);
        }
        private void selectDictionariesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDictionariesFolder();
        }
        private void SelectDictionariesFolder()
        {
            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
            folderBrowserDialog1.ShowDialog();
            this.dictionaries_folder = folderBrowserDialog1.SelectedPath;
            if (update_available_dictionaries())
                load_dictionary(this.dictionary);
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
        }

        private void refreshDictionariesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_available_dictionaries();
        }

        private void postDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoItemClicked(sender);
        }
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoItemClicked(sender);
        }
        private void headersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoItemClicked(sender);
        }
        private void InfoItemClicked(object sender)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            show_panel_info(item.Text);
        }

        private void refresh_Debug()
        {
            if (tcPanelInfo.TabPages.Contains(tpDebug).Equals(false))
                tcPanelInfo.TabPages.Add(tpDebug);
            if (this.debug == null)
                rtbDebug.Text = "(Empty)";
            else
                rtbDebug.Text = string.Join(Environment.NewLine, this.debug);
            rtbDebug.SelectionStart = rtbDebug.TextLength;
            rtbDebug.ScrollToCaret();
        }
        private void show_panel_info(string option_name)
        {
            tsLowPanelInfoButton.Text = option_name;
            tcPanelInfo.TabPages.Remove(tpDebug);
            tcPanelInfo.TabPages.Remove(tpPostData);
            tcPanelInfo.TabPages.Remove(tpHeaders);
            switch (option_name)
            {
                case "Post Data":
                    if (tcPanelInfo.TabPages.Contains(tpPostData).Equals(false))
                        tcPanelInfo.TabPages.Add(tpPostData);
                    break;
                case "Headers":
                    if (tcPanelInfo.TabPages.Contains(tpHeaders).Equals(false))
                        tcPanelInfo.TabPages.Add(tpHeaders);
                    break;
                case "Debug":
                    refresh_Debug();
                    break;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            int new_width = Width - tsUrlLabel.Width - tsMethodButton.Width - tsRunButton.Width - tsOptionsMenu.Width - tsDictMenu.Width - 50;
            tsUrlText.Width = new_width;
            ResizeWorkersPanel();
            Application.DoEvents();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void openDictionaryInEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", this.dictionary);
        }

        private void gETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMethod("GET");
            show_panel_info("Headers");
        }

        private void SetMethod(string method)
        {
            this.method = method;
            tsMethodButton.Text = method;
            UpdateTitle();
        }

        private void hEADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMethod("HEAD");
            show_panel_info("Headers");
        }

        private void pOSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetMethod("POST");
            show_panel_info("Post Data");
        }

        private void breakOnErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.break_on_errors = breakOnErrorsToolStripMenuItem.Checked;
            SaveConfig();
        }

        private void hideLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.hide_lines_checked = hideLinesToolStripMenuItem.Checked;
            SaveConfig();
        }

        private void tsHideLinesTextbox_TextChanged(object sender, EventArgs e)
        {
            this.hide_lines = tsHideLinesTextbox.Text;
            SaveConfig();
        }
    }

    public class WorkerResults
    {
        public Worker worker;

        public string first_line { get; internal set; }
        public string response_code { get; internal set; }
        public string response_code_long { get; internal set; }
        public IEnumerable<string> headers { get; internal set; }
        public WorkerResults(Worker worker)
        {
            this.worker = worker;
        }
    }

    public class Worker
    {
        public Worker(string id)
        {
            this.id = id;
            this.avail = true;
        }

        public bool avail { get; internal set; }
        public string id { get; internal set; }
        public string payload { get; internal set; }
        public Action<Worker> action { get; internal set; }
        public byte[] result { get; internal set; }
        public bool running { get { return thread != null && !thread.ThreadState.Equals(System.Threading.ThreadState.Stopped); } }
        public Thread thread { get; private set; }
        public SocketException error { get; internal set; }
        public Uri uri { get; internal set; }
        public workerControl control { get; internal set; }

        public override string ToString()
        {
            return string.Format("[ Path {0,24} ] : {1}", payload, result != null ? Encoding.ASCII.GetString(result).Replace(Environment.NewLine, " ") : "null");
        }

        internal void Clean()
        {
            this.result = new byte[0];
            this.payload = null;
            this.control.SetState("cleaned");
        }

        internal void Run()
        {
            this.control.SetState("running");
            this.thread = new Thread(() =>
            {
                this.action(this);
            });
            this.thread.Priority = ThreadPriority.BelowNormal;
            this.thread.Start();
        }
    }

    public class Workers
    {
        private Worker[] workers = null;

        public WorkersPanelControl wpanel { get; }

        public Workers(int max_workers)
        {
            InitWorkers(max_workers);
        }

        public Workers(int max_workers, WorkersPanelControl wpanel)
        {
            this.wpanel = wpanel;
            InitWorkers(max_workers);
            for (int i = 0; i < workers.Count(); i++)
            {
                workers[i].control = wpanel.w_controls[i];
            }
        }
        private void InitWorkers(int max_workers)
        {
            workers = new Worker[max_workers];
            for (int i = 0; i < workers.Count(); i++)
            {
                workers[i] = new Worker("worker_" + i.ToString());
            }
        }
        public int Count()
        {
            return this.workers.Length;
        }

        public Worker getAvail()
        {
            Worker[] workers_avail = workers.Where(w => w.avail.Equals(true)).ToArray();
            if (workers_avail.Count().Equals(0))
                return null;
            workers_avail[0].avail = false;
            return workers_avail[0];
        }
        public List<Worker> getAll()
        {
            return this.workers.ToList();
        }

        internal void StopAll()
        {
            foreach (Worker worker in workers)
                if (worker.thread != null)
                    worker.thread.Interrupt();
        }

        internal void updateControls()
        {
            foreach (Worker worker in workers)
            {
                if (worker.thread == null) continue;
                worker.control.worker = worker;
                if (worker.running.Equals(false))
                {
                    worker.control.SetState("idle");
                }
                if (worker.result!=null && worker.result.Length > 0)
                {
                    worker.control.SetState("results_ready");
                }
                worker.control.Refresh();
            }
            wpanel.Refresh();
            Application.DoEvents();
        }
    }

    public class Pool
    {
        public string[] items { get; private set; }
        public void AddItems(string[] lines)
        {
            if (this.items == null)
                this.items = new string[0];
            this.items = this.items.Concat(lines).ToArray();
        }

        public string PopItem()
        {
            if (items.Length == 0) return null;
            string item = items[0];
            items = items.Skip(1).ToArray();
            return item;
        }
    }
}
