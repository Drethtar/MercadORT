
namespace PruebaConectarAccess
{
    partial class PublicationItem
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnQuieroComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Libros";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(32, 56);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(379, 37);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label2";
            this.lblDescription.Click += new System.EventHandler(this.description_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(415, 32);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 24);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "label3";
            // 
            // btnQuieroComprar
            // 
            this.btnQuieroComprar.Location = new System.Drawing.Point(415, 56);
            this.btnQuieroComprar.Name = "btnQuieroComprar";
            this.btnQuieroComprar.Size = new System.Drawing.Size(63, 37);
            this.btnQuieroComprar.TabIndex = 3;
            this.btnQuieroComprar.Text = "Quiero Comprarlo!";
            this.btnQuieroComprar.UseVisualStyleBackColor = true;
            // 
            // PublicationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuieroComprar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PublicationItem";
            this.Size = new System.Drawing.Size(488, 102);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnQuieroComprar;
    }
}
