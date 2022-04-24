
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsUrlText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRunButton = new System.Windows.Forms.ToolStripButton();
            this.tsPoolCountLabel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.show404ResponsesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useHEADMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usePOSTMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDictionariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDictMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.tcPanelInfo = new System.Windows.Forms.TabControl();
            this.tpPostData = new System.Windows.Forms.TabPage();
            this.rtbPostData = new System.Windows.Forms.RichTextBox();
            this.tpDebug = new System.Windows.Forms.TabPage();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsLowPanelInfoButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.postDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tpHeaders = new System.Windows.Forms.TabPage();
            this.rtbHeaders = new System.Windows.Forms.RichTextBox();
            this.headersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcPanelInfo.SuspendLayout();
            this.tpPostData.SuspendLayout();
            this.tpDebug.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tpHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsUrlText,
            this.toolStripSeparator1,
            this.tsRunButton,
            this.tsPoolCountLabel,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.tsDictMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel1.Text = "Url:";
            // 
            // tsUrlText
            // 
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
            // tsPoolCountLabel
            // 
            this.tsPoolCountLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsPoolCountLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPoolCountLabel.Image = ((System.Drawing.Image)(resources.GetObject("tsPoolCountLabel.Image")));
            this.tsPoolCountLabel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPoolCountLabel.Name = "tsPoolCountLabel";
            this.tsPoolCountLabel.Size = new System.Drawing.Size(87, 22);
            this.tsPoolCountLabel.Text = "POOL_COUNT";
            this.tsPoolCountLabel.Click += new System.EventHandler(this.tsPoolCountLabel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show404ResponsesToolStripMenuItem,
            this.useHEADMethodToolStripMenuItem,
            this.usePOSTMethodToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearResultsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectDictionariesFolderToolStripMenuItem,
            this.refreshDictionariesFolderToolStripMenuItem,
            this.toolStripMenuItem3,
            this.newWindowToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Options";
            // 
            // show404ResponsesToolStripMenuItem
            // 
            this.show404ResponsesToolStripMenuItem.CheckOnClick = true;
            this.show404ResponsesToolStripMenuItem.Name = "show404ResponsesToolStripMenuItem";
            this.show404ResponsesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.show404ResponsesToolStripMenuItem.Text = "Show 404 Responses";
            this.show404ResponsesToolStripMenuItem.Click += new System.EventHandler(this.show404ResponsesToolStripMenuItem_Click);
            // 
            // useHEADMethodToolStripMenuItem
            // 
            this.useHEADMethodToolStripMenuItem.Checked = true;
            this.useHEADMethodToolStripMenuItem.CheckOnClick = true;
            this.useHEADMethodToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useHEADMethodToolStripMenuItem.Name = "useHEADMethodToolStripMenuItem";
            this.useHEADMethodToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.useHEADMethodToolStripMenuItem.Text = "Use HEAD method";
            this.useHEADMethodToolStripMenuItem.Click += new System.EventHandler(this.useHEADMethodToolStripMenuItem_Click);
            // 
            // usePOSTMethodToolStripMenuItem
            // 
            this.usePOSTMethodToolStripMenuItem.CheckOnClick = true;
            this.usePOSTMethodToolStripMenuItem.Name = "usePOSTMethodToolStripMenuItem";
            this.usePOSTMethodToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.usePOSTMethodToolStripMenuItem.Text = "Use POST method";
            this.usePOSTMethodToolStripMenuItem.Click += new System.EventHandler(this.usePOSTMethodToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(225, 6);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // tsDictMenu
            // 
            this.tsDictMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsDictMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsDictMenu.Image")));
            this.tsDictMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDictMenu.Name = "tsDictMenu";
            this.tsDictMenu.Size = new System.Drawing.Size(74, 22);
            this.tsDictMenu.Text = "Dictionary";
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
            this.splitContainer1.Panel2.Controls.Add(this.tcPanelInfo);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(710, 341);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 1;
            // 
            // rtbResults
            // 
            this.rtbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResults.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(0, 0);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(710, 236);
            this.rtbResults.TabIndex = 3;
            this.rtbResults.Text = "";
            this.rtbResults.WordWrap = false;
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
            this.tcPanelInfo.Size = new System.Drawing.Size(710, 76);
            this.tcPanelInfo.TabIndex = 1;
            // 
            // tpPostData
            // 
            this.tpPostData.Controls.Add(this.rtbPostData);
            this.tpPostData.Location = new System.Drawing.Point(4, 22);
            this.tpPostData.Name = "tpPostData";
            this.tpPostData.Padding = new System.Windows.Forms.Padding(3);
            this.tpPostData.Size = new System.Drawing.Size(702, 50);
            this.tpPostData.TabIndex = 0;
            this.tpPostData.Text = "Data";
            this.tpPostData.UseVisualStyleBackColor = true;
            // 
            // rtbPostData
            // 
            this.rtbPostData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPostData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPostData.Location = new System.Drawing.Point(3, 3);
            this.rtbPostData.Name = "rtbPostData";
            this.rtbPostData.Size = new System.Drawing.Size(696, 44);
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
            this.tpDebug.Size = new System.Drawing.Size(702, 50);
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
            this.rtbDebug.Size = new System.Drawing.Size(696, 44);
            this.rtbDebug.TabIndex = 6;
            this.rtbDebug.Text = "";
            this.rtbDebug.WordWrap = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLowPanelInfoButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(710, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsLowPanelInfoButton
            // 
            this.tsLowPanelInfoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLowPanelInfoButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postDataToolStripMenuItem,
            this.headersToolStripMenuItem,
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
            this.postDataToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.postDataToolStripMenuItem.Text = "Post Data";
            this.postDataToolStripMenuItem.Click += new System.EventHandler(this.postDataToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // tpHeaders
            // 
            this.tpHeaders.Controls.Add(this.rtbHeaders);
            this.tpHeaders.Location = new System.Drawing.Point(4, 22);
            this.tpHeaders.Name = "tpHeaders";
            this.tpHeaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpHeaders.Size = new System.Drawing.Size(702, 50);
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
            this.rtbHeaders.Size = new System.Drawing.Size(696, 44);
            this.rtbHeaders.TabIndex = 7;
            this.rtbHeaders.Text = "";
            this.rtbHeaders.WordWrap = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebBruteForcer v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcPanelInfo.ResumeLayout(false);
            this.tpPostData.ResumeLayout(false);
            this.tpDebug.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tpHeaders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsRunButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsUrlText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem show404ResponsesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsDictMenu;
        private System.Windows.Forms.ToolStripMenuItem useHEADMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsPoolCountLabel;
        private System.Windows.Forms.ToolStripMenuItem usePOSTMethodToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem selectDictionariesFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDictionariesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsLowPanelInfoButton;
        private System.Windows.Forms.ToolStripMenuItem postDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.TabControl tcPanelInfo;
        private System.Windows.Forms.TabPage tpPostData;
        private System.Windows.Forms.RichTextBox rtbPostData;
        private System.Windows.Forms.TabPage tpDebug;
        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.TabPage tpHeaders;
        private System.Windows.Forms.RichTextBox rtbHeaders;
        private System.Windows.Forms.ToolStripMenuItem headersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}

