
namespace WebBruteForcer
{
    partial class workerControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workerControl));
            this.picState = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picState)).BeginInit();
            this.SuspendLayout();
            // 
            // picState
            // 
            this.picState.Image = global::WebBruteForcer.Properties.Resources.sphere_gray_30x30;
            this.picState.Location = new System.Drawing.Point(0, 0);
            this.picState.Name = "picState";
            this.picState.Size = new System.Drawing.Size(16, 16);
            this.picState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picState.TabIndex = 0;
            this.picState.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sphere_gray_30x30.png");
            this.imageList1.Images.SetKeyName(1, "sphere_green_30x30.png");
            this.imageList1.Images.SetKeyName(2, "sphere_red_30x30.png");
            this.imageList1.Images.SetKeyName(3, "sphere_cyan_30x30.png");
            // 
            // workerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picState);
            this.Name = "workerControl";
            this.Size = new System.Drawing.Size(16, 16);
            ((System.ComponentModel.ISupportInitialize)(this.picState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picState;
        private System.Windows.Forms.ImageList imageList1;
    }
}
