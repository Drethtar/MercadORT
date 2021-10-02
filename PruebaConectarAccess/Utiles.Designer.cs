
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
            this.btnQuieroComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrecioUtil
            // 
            this.lblPrecioUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUtil.Location = new System.Drawing.Point(552, 39);
            this.lblPrecioUtil.Name = "lblPrecioUtil";
            this.lblPrecioUtil.Size = new System.Drawing.Size(83, 30);
            this.lblPrecioUtil.TabIndex = 5;
            this.lblPrecioUtil.Text = "label3";
            // 
            // lblDescriptionUtil
            // 
            this.lblDescriptionUtil.Location = new System.Drawing.Point(40, 69);
            this.lblDescriptionUtil.Name = "lblDescriptionUtil";
            this.lblDescriptionUtil.Size = new System.Drawing.Size(505, 46);
            this.lblDescriptionUtil.TabIndex = 4;
            this.lblDescriptionUtil.Text = "label2";
            // 
            // lblTitleUtil
            // 
            this.lblTitleUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleUtil.Location = new System.Drawing.Point(35, 23);
            this.lblTitleUtil.Name = "lblTitleUtil";
            this.lblTitleUtil.Size = new System.Drawing.Size(511, 46);
            this.lblTitleUtil.TabIndex = 3;
            this.lblTitleUtil.Text = "Utiles";
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
            // Utiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuieroComprar);
            this.Controls.Add(this.lblPrecioUtil);
            this.Controls.Add(this.lblDescriptionUtil);
            this.Controls.Add(this.lblTitleUtil);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Utiles";
            this.Size = new System.Drawing.Size(651, 126);
            this.Load += new System.EventHandler(this.Utiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrecioUtil;
        private System.Windows.Forms.Label lblDescriptionUtil;
        private System.Windows.Forms.Label lblTitleUtil;
        private System.Windows.Forms.Button btnQuieroComprar;
    }
}
