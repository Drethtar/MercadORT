
namespace PruebaConectarAccess
{
    partial class Publicaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtras = new System.Windows.Forms.Button();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblQueEs = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.DondeSePublicanLasCosas = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 404);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(98, 34);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Items.AddRange(new object[] {
            "Libro",
            "Apunte",
            "Util"});
            this.cbxMaterial.Location = new System.Drawing.Point(117, 12);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(134, 24);
            this.cbxMaterial.TabIndex = 2;
            // 
            // cbxMateria
            // 
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Items.AddRange(new object[] {
            "Ciencia y Tecnologia",
            "Ciencias Naturales",
            "Ciencias Sociales",
            "Lengua",
            "Matematica",
            "Hebreo",
            "Ingles",
            "Historia",
            "Geografia",
            "Formacion Etica y Ciudadana",
            "Arte",
            "Biologia",
            "Educacion Tecnologica",
            "Economia",
            "Fisico Quimica",
            "Cultura Judia",
            "Historia Judia",
            "Quimica",
            "Fisica",
            "Filosofia",
            "Marketing",
            "TIC",
            "Diseño",
            "Medios",
            "Humanidades",
            "Gestion"});
            this.cbxMateria.Location = new System.Drawing.Point(615, 12);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(182, 24);
            this.cbxMateria.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 352);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(98, 46);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblQueEs
            // 
            this.lblQueEs.AutoSize = true;
            this.lblQueEs.Location = new System.Drawing.Point(257, 15);
            this.lblQueEs.Name = "lblQueEs";
            this.lblQueEs.Size = new System.Drawing.Size(63, 17);
            this.lblQueEs.TabIndex = 6;
            this.lblQueEs.Text = "Que Es?";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(554, 15);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "Materia";
            // 
            // DondeSePublicanLasCosas
            // 
            this.DondeSePublicanLasCosas.AutoSize = true;
            this.DondeSePublicanLasCosas.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DondeSePublicanLasCosas.ColumnCount = 3;
            this.DondeSePublicanLasCosas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DondeSePublicanLasCosas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DondeSePublicanLasCosas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DondeSePublicanLasCosas.Location = new System.Drawing.Point(117, 43);
            this.DondeSePublicanLasCosas.Name = "DondeSePublicanLasCosas";
            this.DondeSePublicanLasCosas.RowCount = 2;
            this.DondeSePublicanLasCosas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DondeSePublicanLasCosas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DondeSePublicanLasCosas.Size = new System.Drawing.Size(680, 395);
            this.DondeSePublicanLasCosas.TabIndex = 8;
            // 
            // Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DondeSePublicanLasCosas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblQueEs);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.btnAtras);
            this.Name = "Publicaciones";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.Publicaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblQueEs;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TableLayoutPanel DondeSePublicanLasCosas;
    }
}