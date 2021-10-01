
namespace PruebaConectarAccess
{
    partial class Apuntes
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
            this.lblPrecioApunte = new System.Windows.Forms.Label();
            this.lblDescriptionApunte = new System.Windows.Forms.Label();
            this.lblTitleApunte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrecioApunte
            // 
            this.lblPrecioApunte.AutoSize = true;
            this.lblPrecioApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioApunte.Location = new System.Drawing.Point(553, 44);
            this.lblPrecioApunte.Name = "lblPrecioApunte";
            this.lblPrecioApunte.Size = new System.Drawing.Size(64, 25);
            this.lblPrecioApunte.TabIndex = 5;
            this.lblPrecioApunte.Text = "label3";
            // 
            // lblDescriptionApunte
            // 
            this.lblDescriptionApunte.AutoSize = true;
            this.lblDescriptionApunte.Location = new System.Drawing.Point(41, 86);
            this.lblDescriptionApunte.Name = "lblDescriptionApunte";
            this.lblDescriptionApunte.Size = new System.Drawing.Size(46, 17);
            this.lblDescriptionApunte.TabIndex = 4;
            this.lblDescriptionApunte.Text = "label2";
            // 
            // lblTitleApunte
            // 
            this.lblTitleApunte.AutoSize = true;
            this.lblTitleApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleApunte.Location = new System.Drawing.Point(36, 23);
            this.lblTitleApunte.Name = "lblTitleApunte";
            this.lblTitleApunte.Size = new System.Drawing.Size(126, 46);
            this.lblTitleApunte.TabIndex = 3;
            this.lblTitleApunte.Text = "label1";
            // 
            // Apuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecioApunte);
            this.Controls.Add(this.lblDescriptionApunte);
            this.Controls.Add(this.lblTitleApunte);
            this.Name = "Apuntes";
            this.Size = new System.Drawing.Size(650, 126);
            this.Load += new System.EventHandler(this.Apuntes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioApunte;
        private System.Windows.Forms.Label lblDescriptionApunte;
        private System.Windows.Forms.Label lblTitleApunte;
    }
}
