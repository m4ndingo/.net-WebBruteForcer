
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUrlLabel = new System.Windows.Forms.ToolStripLabel();
            this.tsUrlText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRunButton = new System.Windows.Forms.ToolStripButton();
            this.tsMethodButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.gETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOptionsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.show404ResponsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHideLinesTextbox = new System.Windows.Forms.ToolStripTextBox();
            this.breakOnErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDictionaryInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDictMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tcPanelInfo = new System.Windows.Forms.TabControl();
            this.tpPostData = new System.Windows.Forms.TabPage();
            this.rtbPostData = new System.Windows.Forms.RichTextBox();
            this.tpDebug = new System.Windows.Forms.TabPage();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.tpHeaders = new System.Windows.Forms.TabPage();
            this.rtbHeaders = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsLowPanelInfoButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.postDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tcPanelInfo.SuspendLayout();
            this.tpPostData.SuspendLayout();
            this.tpDebug.SuspendLayout();
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
            this.toolStripSeparator1,
            this.tsRunButton,
            this.tsMethodButton,
            this.toolStripSeparator2,
            this.tsOptionsMenu,
            this.tsDictMenu,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsUrlLabel
            // 
            this.tsUrlLabel.Name = "tsUrlLabel";
            this.tsUrlLabel.Size = new System.Drawing.Size(25, 22);
            this.tsUrlLabel.Text = "Url:";
            // 
            // tsUrlText
            // 
            this.tsUrlText.AutoSize = false;
            this.tsUrlText.Name = "tsUrlText";
            this.tsUrlText.Size = new System.Drawing.Size(301, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsRunButton
            // 
            this.tsRunButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsRunButton.Image = ((System.Drawing.Image)(resources.GetObject("tsRunButton.Image")));
            this.tsRunButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRunButton.Name = "tsRunButton";
            this.tsRunButton.Size = new System.Drawing.Size(66, 22);
            this.tsRunButton.Text = "Bruteforce";
            this.tsRunButton.Click += new System.EventHandler(this.tsRunButton_Click);
            // 
            // tsMethodButton
            // 
            this.tsMethodButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gETToolStripMenuItem,
            this.hEADToolStripMenuItem,
            this.pOSTToolStripMenuItem});
            this.tsMethodButton.Name = "tsMethodButton";
            this.tsMethodButton.Size = new System.Drawing.Size(69, 22);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsOptionsMenu
            // 
            this.tsOptionsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show404ResponsesToolStripMenuItem,
            this.hideLinesToolStripMenuItem,
            this.breakOnErrorsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectDictionariesFolderToolStripMenuItem,
            this.refreshDictionariesFolderToolStripMenuItem,
            this.openDictionaryInEditorToolStripMenuItem,
            this.toolStripMenuItem5,
            this.newWindowToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearResultsToolStripMenuItem});
            this.tsOptionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsOptionsMenu.Image")));
            this.tsOptionsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOptionsMenu.Name = "tsOptionsMenu";
            this.tsOptionsMenu.Size = new System.Drawing.Size(62, 22);
            this.tsOptionsMenu.Text = "Options";
            // 
            // show404ResponsesToolStripMenuItem
            // 
            this.show404ResponsesToolStripMenuItem.CheckOnClick = true;
            this.show404ResponsesToolStripMenuItem.Name = "show404ResponsesToolStripMenuItem";
            this.show404ResponsesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.show404ResponsesToolStripMenuItem.Text = "Show 404 Responses";
            this.show404ResponsesToolStripMenuItem.Click += new System.EventHandler(this.show404ResponsesToolStripMenuItem_Click);
            // 
            // hideLinesToolStripMenuItem
            // 
            this.hideLinesToolStripMenuItem.CheckOnClick = true;
            this.hideLinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHideLinesTextbox});
            this.hideLinesToolStripMenuItem.Name = "hideLinesToolStripMenuItem";
            this.hideLinesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.hideLinesToolStripMenuItem.Text = "Hide Responses with # Lines";
            this.hideLinesToolStripMenuItem.Click += new System.EventHandler(this.hideLinesToolStripMenuItem_Click);
            // 
            // tsHideLinesTextbox
            // 
            this.tsHideLinesTextbox.Name = "tsHideLinesTextbox";
            this.tsHideLinesTextbox.Size = new System.Drawing.Size(100, 23);
            this.tsHideLinesTextbox.TextChanged += new System.EventHandler(this.tsHideLinesTextbox_TextChanged);
            // 
            // breakOnErrorsToolStripMenuItem
            // 
            this.breakOnErrorsToolStripMenuItem.CheckOnClick = true;
            this.breakOnErrorsToolStripMenuItem.Name = "breakOnErrorsToolStripMenuItem";
            this.breakOnErrorsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.breakOnErrorsToolStripMenuItem.Text = "Break on Errors";
            this.breakOnErrorsToolStripMenuItem.Click += new System.EventHandler(this.breakOnErrorsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // selectDictionariesFolderToolStripMenuItem
            // 
            this.selectDictionariesFolderToolStripMenuItem.Name = "selectDictionariesFolderToolStripMenuItem";
            this.selectDictionariesFolderToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.selectDictionariesFolderToolStripMenuItem.Text = "Select \"Dictionaries\" Folder ...";
            this.selectDictionariesFolderToolStripMenuItem.Click += new System.EventHandler(this.selectDictionariesFolderToolStripMenuItem_Click);
            // 
            // refreshDictionariesFolderToolStripMenuItem
            // 
            this.refreshDictionariesFolderToolStripMenuItem.Name = "refreshDictionariesFolderToolStripMenuItem";
            this.refreshDictionariesFolderToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.refreshDictionariesFolderToolStripMenuItem.Text = "Refresh \"Dictionaries\" Folder";
            this.refreshDictionariesFolderToolStripMenuItem.Click += new System.EventHandler(this.refreshDictionariesFolderToolStripMenuItem_Click);
            // 
            // openDictionaryInEditorToolStripMenuItem
            // 
            this.openDictionaryInEditorToolStripMenuItem.Name = "openDictionaryInEditorToolStripMenuItem";
            this.openDictionaryInEditorToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.openDictionaryInEditorToolStripMenuItem.Text = "Open Dictionary in Editor";
            this.openDictionaryInEditorToolStripMenuItem.Click += new System.EventHandler(this.openDictionaryInEditorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(225, 6);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // tsDictMenu
            // 
            this.tsDictMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsDictMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDictMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsDictMenu.Image")));
            this.tsDictMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDictMenu.Name = "tsDictMenu";
            this.tsDictMenu.Size = new System.Drawing.Size(74, 22);
            this.tsDictMenu.Text = "Dictionary";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbResults);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 341);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtbResults
            // 
            this.rtbResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(0, 0);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(1032, 236);
            this.rtbResults.TabIndex = 3;
            this.rtbResults.Text = "";
            this.rtbResults.WordWrap = false;
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
            this.splitContainer2.Size = new System.Drawing.Size(1032, 101);
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
            this.tcPanelInfo.Size = new System.Drawing.Size(790, 76);
            this.tcPanelInfo.TabIndex = 4;
            // 
            // tpPostData
            // 
            this.tpPostData.Controls.Add(this.rtbPostData);
            this.tpPostData.Location = new System.Drawing.Point(4, 22);
            this.tpPostData.Name = "tpPostData";
            this.tpPostData.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostData.Size = new System.Drawing.Size(782, 50);
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
            this.rtbPostData.Size = new System.Drawing.Size(776, 44);
            this.rtbPostData.TabIndex = 5;
            this.rtbPostData.Text = "";
            this.rtbPostData.WordWrap = false;
            // 
            // tpDebug
            // 
            this.tpDebug.Controls.Add(this.rtbDebug);
            this.tpDebug.Location = new System.Drawing.Point(4, 22);
            this.tpDebug.Name = "tpDebug";
            this.tpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebug.Size = new System.Drawing.Size(782, 50);
            this.tpDebug.TabIndex = 1;
            this.tpDebug.Text = "Debug";
            this.tpDebug.UseVisualStyleBackColor = true;
            // 
            // rtbDebug
            // 
            this.rtbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDebug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDebug.Location = new System.Drawing.Point(3, 3);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(776, 44);
            this.rtbDebug.TabIndex = 6;
            this.rtbDebug.Text = "";
            this.rtbDebug.WordWrap = false;
            // 
            // tpHeaders
            // 
            this.tpHeaders.Controls.Add(this.rtbHeaders);
            this.tpHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpHeaders.Name = "tpHeaders";
            this.tpHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeaders.Size = new System.Drawing.Size(782, 50);
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
            this.rtbHeaders.Size = new System.Drawing.Size(776, 44);
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
            // postDataToolStripMenuItem
            // 
            this.postDataToolStripMenuItem.Name = "postDataToolStripMenuItem";
            this.postDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postDataToolStripMenuItem.Text = "Post Data";
            this.postDataToolStripMenuItem.Click += new System.EventHandler(this.postDataToolStripMenuItem_Click);
            // 
            // headersToolStripMenuItem
            // 
            this.headersToolStripMenuItem.Name = "headersToolStripMenuItem";
            this.headersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.headersToolStripMenuItem.Text = "Headers";
            this.headersToolStripMenuItem.Click += new System.EventHandler(this.headersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
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
            this.Text = "WebBruteForcer v1.1";
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tcPanelInfo.ResumeLayout(false);
            this.tpPostData.ResumeLayout(false);
            this.tpDebug.ResumeLayout(false);
            this.tpHeaders.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRunButton;
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
        private System.Windows.Forms.RichTextBox rtbResults;
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
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.TabPage tpHeaders;
        private System.Windows.Forms.RichTextBox rtbHeaders;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton tsLowPanelInfoButton;
        private System.Windows.Forms.ToolStripMenuItem postDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
    }
}

