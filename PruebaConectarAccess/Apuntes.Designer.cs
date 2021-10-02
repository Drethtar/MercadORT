
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
            this.btnQuieroComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecioApunte
            // 
            this.lblPrecioApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioApunte.Location = new System.Drawing.Point(553, 39);
            this.lblPrecioApunte.Name = "lblPrecioApunte";
            this.lblPrecioApunte.Size = new System.Drawing.Size(85, 27);
            this.lblPrecioApunte.TabIndex = 5;
            this.lblPrecioApunte.Text = "label3";
            // 
            // lblDescriptionApunte
            // 
            this.lblDescriptionApunte.Location = new System.Drawing.Point(41, 69);
            this.lblDescriptionApunte.Name = "lblDescriptionApunte";
            this.lblDescriptionApunte.Size = new System.Drawing.Size(505, 47);
            this.lblDescriptionApunte.TabIndex = 4;
            this.lblDescriptionApunte.Text = "label2";
            // 
            // lblTitleApunte
            // 
            this.lblTitleApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleApunte.Location = new System.Drawing.Point(36, 23);
            this.lblTitleApunte.Name = "lblTitleApunte";
            this.lblTitleApunte.Size = new System.Drawing.Size(511, 46);
            this.lblTitleApunte.TabIndex = 3;
            this.lblTitleApunte.Text = "Apunte";
            // 
            // btnQuieroComprar
            // 
            this.btnQuieroComprar.Location = new System.Drawing.Point(553, 69);
            this.btnQuieroComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuieroComprar.Name = "btnQuieroComprar";
            this.btnQuieroComprar.Size = new System.Drawing.Size(84, 46);
            this.btnQuieroComprar.TabIndex = 6;
            this.btnQuieroComprar.Text = "Quiero Comprarlo!";
            this.btnQuieroComprar.UseVisualStyleBackColor = true;
            // 
            // Apuntes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuieroComprar);
            this.Controls.Add(this.lblPrecioApunte);
            this.Controls.Add(this.lblDescriptionApunte);
            this.Controls.Add(this.lblTitleApunte);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Apuntes";
            this.Size = new System.Drawing.Size(651, 126);
            this.Load += new System.EventHandler(this.Apuntes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioApunte;
        private System.Windows.Forms.Label lblDescriptionApunte;
        private System.Windows.Forms.Label lblTitleApunte;
        private System.Windows.Forms.Button btnQuieroComprar;
    }
}
