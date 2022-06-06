
namespace WebBruteForcer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUrlLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsUrlText = new System.Windows.Forms.ToolStripTextBox();
            this.tsPasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOptionsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.show404ResponsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHideLinesTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.hideResponsesWithBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHideBytesTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.breakOnErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDictionaryInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMethodButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.gETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDictMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsBruteForcePlayButton = new System.Windows.Forms.ToolStripButton();
            this.tsStopBruteforcerButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tcPanelInfo = new System.Windows.Forms.TabControl();
            this.tpPostData = new System.Windows.Forms.TabPage();
            this.rtbPostData = new System.Windows.Forms.RichTextBox();
            this.tpDebug = new System.Windows.Forms.TabPage();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsClearDebugButton = new System.Windows.Forms.ToolStripButton();
            this.tpHeaders = new System.Windows.Forms.TabPage();
            this.rtbHeaders = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsLowPanelInfoButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.headersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tcPanelInfo.SuspendLayout();
            this.tpPostData.SuspendLayout();
            this.tpDebug.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tpHeaders.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUrlLabel,
            this.tsUrlText,
            this.tsPasteButton,
            this.toolStripSeparator1,
            this.tsOptionsMenu,
            this.toolStripSeparator2,
            this.tsMethodButton,
            this.tsDictMenu,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUrlLabel
            // 
            this.tsUrlLabel.Name = "tsUrlLabel";
            this.tsUrlLabel.Size = new System.Drawing.Size(25, 24);
            this.tsUrlLabel.Text = "Url:";
            // 
            // tsUrlText
            // 
            this.tsUrlText.AutoSize = false;
            this.tsUrlText.Name = "tsUrlText";
            this.tsUrlText.Size = new System.Drawing.Size(301, 25);
            // 
            // tsPasteButton
            // 
            this.tsPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("tsPasteButton.Image")));
            this.tsPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPasteButton.Name = "tsPasteButton";
            this.tsPasteButton.Size = new System.Drawing.Size(24, 24);
            this.tsPasteButton.Text = "toolStripButton1";
            this.tsPasteButton.ToolTipText = "Paste Url";
            this.tsPasteButton.Click += new System.EventHandler(this.tsPasteButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsOptionsMenu
            // 
            this.tsOptionsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show404ResponsesToolStripMenuItem,
            this.hideLinesToolStripMenuItem,
            this.hideResponsesWithBytesToolStripMenuItem,
            this.breakOnErrorsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectDictionariesFolderToolStripMenuItem,
            this.refreshDictionariesFolderToolStripMenuItem,
            this.openDictionaryInEditorToolStripMenuItem,
            this.toolStripMenuItem5,
            this.newWindowToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearResultsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.aboutToolStripMenuItem});
            this.tsOptionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsOptionsMenu.Image")));
            this.tsOptionsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOptionsMenu.Name = "tsOptionsMenu";
            this.tsOptionsMenu.Size = new System.Drawing.Size(62, 24);
            this.tsOptionsMenu.Text = "Options";
            // 
            // show404ResponsesToolStripMenuItem
            // 
            this.show404ResponsesToolStripMenuItem.CheckOnClick = true;
            this.show404ResponsesToolStripMenuItem.Name = "show404ResponsesToolStripMenuItem";
            this.show404ResponsesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.show404ResponsesToolStripMenuItem.Text = "Show 404 Responses";
            this.show404ResponsesToolStripMenuItem.Click += new System.EventHandler(this.show404ResponsesToolStripMenuItem_Click);
            // 
            // hideLinesToolStripMenuItem
            // 
            this.hideLinesToolStripMenuItem.CheckOnClick = true;
            this.hideLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHideLinesTextbox});
            this.hideLinesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hideLinesToolStripMenuItem.Image")));
            this.hideLinesToolStripMenuItem.Name = "hideLinesToolStripMenuItem";
            this.hideLinesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hideLinesToolStripMenuItem.Text = "Hide Responses with # Lines";
            this.hideLinesToolStripMenuItem.Click += new System.EventHandler(this.hideLinesToolStripMenuItem_Click);
            // 
            // tsHideLinesTextbox
            // 
            this.tsHideLinesTextbox.Name = "tsHideLinesTextbox";
            this.tsHideLinesTextbox.Size = new System.Drawing.Size(100, 23);
            this.tsHideLinesTextbox.ToolTipText = "Examples:\r\n14           # hide responses with 14 lines\r\n14,20      # hide respons" +
    "es with 14 or 20 lines\r\n";
            this.tsHideLinesTextbox.TextChanged += new System.EventHandler(this.tsHideLinesTextbox_TextChanged);
            // 
            // hideResponsesWithBytesToolStripMenuItem
            // 
            this.hideResponsesWithBytesToolStripMenuItem.CheckOnClick = true;
            this.hideResponsesWithBytesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHideBytesTextbox});
            this.hideResponsesWithBytesToolStripMenuItem.Image = global::WebBruteForcer.Properties.Resources.filter1;
            this.hideResponsesWithBytesToolStripMenuItem.Name = "hideResponsesWithBytesToolStripMenuItem";
            this.hideResponsesWithBytesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.hideResponsesWithBytesToolStripMenuItem.Text = "Hide Responses with # Bytes";
            this.hideResponsesWithBytesToolStripMenuItem.Click += new System.EventHandler(this.hideResponsesWithBytesToolStripMenuItem_Click);
            // 
            // tsHideBytesTexbox
            // 
            this.tsHideBytesTextbox.Name = "tsHideBytesTexbox";
            this.tsHideBytesTextbox.Size = new System.Drawing.Size(100, 23);
            this.tsHideBytesTextbox.TextChanged += new System.EventHandler(this.tsHideBytesTexbox_TextChanged);
            // 
            // breakOnErrorsToolStripMenuItem
            // 
            this.breakOnErrorsToolStripMenuItem.CheckOnClick = true;
            this.breakOnErrorsToolStripMenuItem.Name = "breakOnErrorsToolStripMenuItem";
            this.breakOnErrorsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.breakOnErrorsToolStripMenuItem.Text = "Break on Errors";
            this.breakOnErrorsToolStripMenuItem.Click += new System.EventHandler(this.breakOnErrorsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // selectDictionariesFolderToolStripMenuItem
            // 
            this.selectDictionariesFolderToolStripMenuItem.Image = global::WebBruteForcer.Properties.Resources.folder;
            this.selectDictionariesFolderToolStripMenuItem.Name = "selectDictionariesFolderToolStripMenuItem";
            this.selectDictionariesFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.selectDictionariesFolderToolStripMenuItem.Text = "Select \"Dictionaries\" Folder ...";
            this.selectDictionariesFolderToolStripMenuItem.Click += new System.EventHandler(this.selectDictionariesFolderToolStripMenuItem_Click);
            // 
            // refreshDictionariesFolderToolStripMenuItem
            // 
            this.refreshDictionariesFolderToolStripMenuItem.Image = global::WebBruteForcer.Properties.Resources.refresh;
            this.refreshDictionariesFolderToolStripMenuItem.Name = "refreshDictionariesFolderToolStripMenuItem";
            this.refreshDictionariesFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.refreshDictionariesFolderToolStripMenuItem.Text = "Refresh \"Dictionaries\" Folder";
            this.refreshDictionariesFolderToolStripMenuItem.Click += new System.EventHandler(this.refreshDictionariesFolderToolStripMenuItem_Click);
            // 
            // openDictionaryInEditorToolStripMenuItem
            // 
            this.openDictionaryInEditorToolStripMenuItem.Image = global::WebBruteForcer.Properties.Resources.edit;
            this.openDictionaryInEditorToolStripMenuItem.Name = "openDictionaryInEditorToolStripMenuItem";
            this.openDictionaryInEditorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openDictionaryInEditorToolStripMenuItem.Text = "Edit Dictionary in Notepad";
            this.openDictionaryInEditorToolStripMenuItem.Click += new System.EventHandler(this.openDictionaryInEditorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(229, 6);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(229, 6);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Image = global::WebBruteForcer.Properties.Resources.close_button;
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(229, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsMethodButton
            // 
            this.tsMethodButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gETToolStripMenuItem,
            this.hEADToolStripMenuItem,
            this.pOSTToolStripMenuItem});
            this.tsMethodButton.Name = "tsMethodButton";
            this.tsMethodButton.Size = new System.Drawing.Size(69, 24);
            this.tsMethodButton.Text = "METHOD";
            // 
            // gETToolStripMenuItem
            // 
            this.gETToolStripMenuItem.Name = "gETToolStripMenuItem";
            this.gETToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.gETToolStripMenuItem.Text = "GET";
            this.gETToolStripMenuItem.Click += new System.EventHandler(this.gETToolStripMenuItem_Click);
            // 
            // hEADToolStripMenuItem
            // 
            this.hEADToolStripMenuItem.Name = "hEADToolStripMenuItem";
            this.hEADToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hEADToolStripMenuItem.Text = "HEAD";
            this.hEADToolStripMenuItem.Click += new System.EventHandler(this.hEADToolStripMenuItem_Click);
            // 
            // pOSTToolStripMenuItem
            // 
            this.pOSTToolStripMenuItem.Name = "pOSTToolStripMenuItem";
            this.pOSTToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pOSTToolStripMenuItem.Text = "POST";
            this.pOSTToolStripMenuItem.Click += new System.EventHandler(this.pOSTToolStripMenuItem_Click);
            // 
            // tsDictMenu
            // 
            this.tsDictMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDictMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDictMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsDictMenu.Image")));
            this.tsDictMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsDictMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDictMenu.Name = "tsDictMenu";
            this.tsDictMenu.Size = new System.Drawing.Size(74, 24);
            this.tsDictMenu.Text = "Dictionary";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbResults);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 339);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtbResults
            // 
            this.rtbResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(0, 0);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(1008, 205);
            this.rtbResults.TabIndex = 4;
            this.rtbResults.Text = "";
            this.rtbResults.WordWrap = false;
            // 
            // toolStrip4
            // 
            this.toolStrip4.AutoSize = false;
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBruteForcePlayButton,
            this.tsStopBruteforcerButton,
            this.toolStripButton1});
            this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip4.Location = new System.Drawing.Point(1008, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(24, 205);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // tsBruteForcePlayButton
            // 
            this.tsBruteForcePlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBruteForcePlayButton.Image = ((System.Drawing.Image)(resources.GetObject("tsBruteForcePlayButton.Image")));
            this.tsBruteForcePlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBruteForcePlayButton.Name = "tsBruteForcePlayButton";
            this.tsBruteForcePlayButton.Size = new System.Drawing.Size(22, 20);
            this.tsBruteForcePlayButton.Text = "toolStripButton2";
            this.tsBruteForcePlayButton.ToolTipText = "Run BruteForcer";
            this.tsBruteForcePlayButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsStopBruteforcerButton
            // 
            this.tsStopBruteforcerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStopBruteforcerButton.Enabled = false;
            this.tsStopBruteforcerButton.Image = ((System.Drawing.Image)(resources.GetObject("tsStopBruteforcerButton.Image")));
            this.tsStopBruteforcerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStopBruteforcerButton.Name = "tsStopBruteforcerButton";
            this.tsStopBruteforcerButton.Size = new System.Drawing.Size(22, 20);
            this.tsStopBruteforcerButton.Text = "Stop Bruteforcer";
            this.tsStopBruteforcerButton.Click += new System.EventHandler(this.tsStopBruteforcerButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(22, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Clear Results";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tcPanelInfo);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainer2.Size = new System.Drawing.Size(1032, 130);
            this.splitContainer2.SplitterDistance = 790;
            this.splitContainer2.TabIndex = 1;
            // 
            // tcPanelInfo
            // 
            this.tcPanelInfo.Controls.Add(this.tpPostData);
            this.tcPanelInfo.Controls.Add(this.tpDebug);
            this.tcPanelInfo.Controls.Add(this.tpHeaders);
            this.tcPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPanelInfo.Location = new System.Drawing.Point(0, 25);
            this.tcPanelInfo.Name = "tcPanelInfo";
            this.tcPanelInfo.SelectedIndex = 0;
            this.tcPanelInfo.Size = new System.Drawing.Size(790, 105);
            this.tcPanelInfo.TabIndex = 4;
            // 
            // tpPostData
            // 
            this.tpPostData.Controls.Add(this.rtbPostData);
            this.tpPostData.Location = new System.Drawing.Point(4, 22);
            this.tpPostData.Name = "tpPostData";
            this.tpPostData.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostData.Size = new System.Drawing.Size(782, 79);
            this.tpPostData.TabIndex = 0;
            this.tpPostData.Text = "Data";
            this.tpPostData.UseVisualStyleBackColor = true;
            // 
            // rtbPostData
            // 
            this.rtbPostData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPostData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPostData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPostData.Location = new System.Drawing.Point(3, 3);
            this.rtbPostData.Name = "rtbPostData";
            this.rtbPostData.Size = new System.Drawing.Size(776, 73);
            this.rtbPostData.TabIndex = 5;
            this.rtbPostData.Text = "";
            this.rtbPostData.WordWrap = false;
            // 
            // tpDebug
            // 
            this.tpDebug.Controls.Add(this.rtbDebug);
            this.tpDebug.Controls.Add(this.toolStrip3);
            this.tpDebug.Location = new System.Drawing.Point(4, 22);
            this.tpDebug.Name = "tpDebug";
            this.tpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebug.Size = new System.Drawing.Size(782, 79);
            this.tpDebug.TabIndex = 1;
            this.tpDebug.Text = "Debug";
            this.tpDebug.UseVisualStyleBackColor = true;
            // 
            // rtbDebug
            // 
            this.rtbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDebug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDebug.Location = new System.Drawing.Point(27, 3);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(752, 73);
            this.rtbDebug.TabIndex = 7;
            this.rtbDebug.Text = "";
            this.rtbDebug.WordWrap = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClearDebugButton});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(24, 73);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsClearDebugButton
            // 
            this.tsClearDebugButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClearDebugButton.Image = ((System.Drawing.Image)(resources.GetObject("tsClearDebugButton.Image")));
            this.tsClearDebugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClearDebugButton.Name = "tsClearDebugButton";
            this.tsClearDebugButton.Size = new System.Drawing.Size(21, 20);
            this.tsClearDebugButton.Text = "toolStripButton1";
            this.tsClearDebugButton.ToolTipText = "Clear Debug";
            this.tsClearDebugButton.Click += new System.EventHandler(this.tsClearDebugButton_Click);
            // 
            // tpHeaders
            // 
            this.tpHeaders.Controls.Add(this.rtbHeaders);
            this.tpHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpHeaders.Name = "tpHeaders";
            this.tpHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeaders.Size = new System.Drawing.Size(782, 79);
            this.tpHeaders.TabIndex = 2;
            this.tpHeaders.Text = "Headers";
            this.tpHeaders.UseVisualStyleBackColor = true;
            // 
            // rtbHeaders
            // 
            this.rtbHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHeaders.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHeaders.Location = new System.Drawing.Point(3, 3);
            this.rtbHeaders.Name = "rtbHeaders";
            this.rtbHeaders.Size = new System.Drawing.Size(776, 73);
            this.rtbHeaders.TabIndex = 7;
            this.rtbHeaders.Text = "";
            this.rtbHeaders.WordWrap = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLowPanelInfoButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(790, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsLowPanelInfoButton
            // 
            this.tsLowPanelInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLowPanelInfoButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headersToolStripMenuItem,
            this.postDataToolStripMenuItem,
            this.toolStripMenuItem4,
            this.debugToolStripMenuItem});
            this.tsLowPanelInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("tsLowPanelInfoButton.Image")));
            this.tsLowPanelInfoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLowPanelInfoButton.Name = "tsLowPanelInfoButton";
            this.tsLowPanelInfoButton.Size = new System.Drawing.Size(82, 22);
            this.tsLowPanelInfoButton.Text = "PANELINFO";
            // 
            // headersToolStripMenuItem
            // 
            this.headersToolStripMenuItem.Name = "headersToolStripMenuItem";
            this.headersToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.headersToolStripMenuItem.Text = "Headers";
            this.headersToolStripMenuItem.Click += new System.EventHandler(this.headersToolStripMenuItem_Click);
            // 
            // postDataToolStripMenuItem
            // 
            this.postDataToolStripMenuItem.Name = "postDataToolStripMenuItem";
            this.postDataToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.postDataToolStripMenuItem.Text = "Post Data";
            this.postDataToolStripMenuItem.Click += new System.EventHandler(this.postDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file.png");
            this.imageList1.Images.SetKeyName(1, "pause.png");
            this.imageList1.Images.SetKeyName(2, "resume.png");
            this.imageList1.Images.SetKeyName(3, "play.png");
            this.imageList1.Images.SetKeyName(4, "stop.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebBruteForcer v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tcPanelInfo.ResumeLayout(false);
            this.tpPostData.ResumeLayout(false);
            this.tpDebug.ResumeLayout(false);
            this.tpDebug.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tpHeaders.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsUrlLabel;
        private System.Windows.Forms.ToolStripTextBox tsUrlText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsOptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem show404ResponsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsDictMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectDictionariesFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDictionariesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDictionaryInEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripDropDownButton tsMethodButton;
        private System.Windows.Forms.ToolStripMenuItem gETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem breakOnErrorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsHideLinesTextbox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tcPanelInfo;
        private System.Windows.Forms.TabPage tpPostData;
        private System.Windows.Forms.RichTextBox rtbPostData;
        private System.Windows.Forms.TabPage tpDebug;
        private System.Windows.Forms.TabPage tpHeaders;
        private System.Windows.Forms.RichTextBox rtbHeaders;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton tsLowPanelInfoButton;
        private System.Windows.Forms.ToolStripMenuItem postDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsPasteButton;
        private System.Windows.Forms.ToolStripMenuItem hideResponsesWithBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsHideBytesTextbox;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsClearDebugButton;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton tsBruteForcePlayButton;
        private System.Windows.Forms.ToolStripButton tsStopBruteforcerButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

