
namespace PruebaConectarAccess
{
    partial class Utiles
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
            this.lblPrecioUtil = new System.Windows.Forms.Label();
            this.lblDescriptionUtil = new System.Windows.Forms.Label();
            this.lblTitleUtil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrecioUtil
            // 
            this.lblPrecioUtil.AutoSize = true;
            this.lblPrecioUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUtil.Location = new System.Drawing.Point(552, 44);
            this.lblPrecioUtil.Name = "lblPrecioUtil";
            this.lblPrecioUtil.Size = new System.Drawing.Size(64, 25);
            this.lblPrecioUtil.TabIndex = 5;
            this.lblPrecioUtil.Text = "label3";
            // 
            // lblDescriptionUtil
            // 
            this.lblDescriptionUtil.AutoSize = true;
            this.lblDescriptionUtil.Location = new System.Drawing.Point(40, 86);
            this.lblDescriptionUtil.Name = "lblDescriptionUtil";
            this.lblDescriptionUtil.Size = new System.Drawing.Size(46, 17);
            this.lblDescriptionUtil.TabIndex = 4;
            this.lblDescriptionUtil.Text = "label2";
            // 
            // lblTitleUtil
            // 
            this.lblTitleUtil.AutoSize = true;
            this.lblTitleUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUtil.Location = new System.Drawing.Point(35, 23);
            this.lblTitleUtil.Name = "lblTitleUtil";
            this.lblTitleUtil.Size = new System.Drawing.Size(126, 46);
            this.lblTitleUtil.TabIndex = 3;
            this.lblTitleUtil.Text = "label1";
            // 
            // Utiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrecioUtil);
            this.Controls.Add(this.lblDescriptionUtil);
            this.Controls.Add(this.lblTitleUtil);
            this.Name = "Utiles";
            this.Size = new System.Drawing.Size(650, 126);
            this.Load += new System.EventHandler(this.Utiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioUtil;
        private System.Windows.Forms.Label lblDescriptionUtil;
        private System.Windows.Forms.Label lblTitleUtil;
    }
}
