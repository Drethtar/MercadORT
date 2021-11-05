
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
            this.lblQueEs = new System.Windows.Forms.Label();
            this.pbFotoPublicacion = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPublicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(105, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(932, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Libros";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(113, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(915, 46);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label2";
            this.lblDescription.Click += new System.EventHandler(this.description_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(1040, 26);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(224, 42);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "label3";
            // 
            // btnQuieroComprar
            // 
            this.btnQuieroComprar.BackColor = System.Drawing.Color.White;
            this.btnQuieroComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuieroComprar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnQuieroComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuieroComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuieroComprar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuieroComprar.Location = new System.Drawing.Point(1041, 71);
            this.btnQuieroComprar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuieroComprar.Name = "btnQuieroComprar";
            this.btnQuieroComprar.Size = new System.Drawing.Size(224, 46);
            this.btnQuieroComprar.TabIndex = 3;
            this.btnQuieroComprar.Text = "Quiero Comprarlo!";
            this.btnQuieroComprar.UseVisualStyleBackColor = false;
            this.btnQuieroComprar.Click += new System.EventHandler(this.btnQuieroComprarLibro_Click);
            // 
            // lblQueEs
            // 
            this.lblQueEs.AutoSize = true;
            this.lblQueEs.Location = new System.Drawing.Point(0, 127);
            this.lblQueEs.Name = "lblQueEs";
            this.lblQueEs.Size = new System.Drawing.Size(16, 17);
            this.lblQueEs.TabIndex = 4;
            this.lblQueEs.Text = "a";
            this.lblQueEs.Visible = false;
            this.lblQueEs.Click += new System.EventHandler(this.lblQueEs_Click);
            // 
            // pbFotoPublicacion
            // 
            this.pbFotoPublicacion.Location = new System.Drawing.Point(3, 3);
            this.pbFotoPublicacion.Name = "pbFotoPublicacion";
            this.pbFotoPublicacion.Size = new System.Drawing.Size(100, 130);
            this.pbFotoPublicacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoPublicacion.TabIndex = 7;
            this.pbFotoPublicacion.TabStop = false;
            this.pbFotoPublicacion.Click += new System.EventHandler(this.pbFotoPublicacion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.BackgroundImage = global::PruebaConectarAccess.Properties.Resources.Rectangle_108;
            this.pictureBox2.Location = new System.Drawing.Point(40, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1227, 4);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // PublicationItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbFotoPublicacion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblQueEs);
            this.Controls.Add(this.btnQuieroComprar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PublicationItem";
            this.Size = new System.Drawing.Size(1319, 145);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPublicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnQuieroComprar;
        private System.Windows.Forms.Label lblQueEs;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbFotoPublicacion;
    }
}
