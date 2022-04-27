
namespace WebBruteForcer
{
    partial class WorkersPanelControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.wPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // wPanel
            // 
            this.wPanel.AutoScroll = true;
            this.wPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wPanel.Location = new System.Drawing.Point(0, 0);
            this.wPanel.Name = "wPanel";
            this.wPanel.Size = new System.Drawing.Size(150, 150);
            this.wPanel.TabIndex = 0;
            // 
            // WorkersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wPanel);
            this.Name = "WorkersPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wPanel;
    }
}
