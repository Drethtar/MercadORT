
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publicaciones));
            this.btnAtras = new System.Windows.Forms.Button();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblQueEs = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.publicationsPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lbQueColor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.publicationsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.Location = new System.Drawing.Point(39, 17);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(151, 63);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.BackColor = System.Drawing.Color.LightGray;
            this.cbxMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMaterial.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaterial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Items.AddRange(new object[] {
            "Libro",
            "Apunte",
            "Util"});
            this.cbxMaterial.Location = new System.Drawing.Point(74, 292);
            this.cbxMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(229, 41);
            this.cbxMaterial.TabIndex = 2;
            this.cbxMaterial.SelectedIndexChanged += new System.EventHandler(this.cbxMaterial_SelectedIndexChanged);
            // 
            // cbxMateria
            // 
            this.cbxMateria.BackColor = System.Drawing.Color.LightGray;
            this.cbxMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxMateria.Location = new System.Drawing.Point(74, 445);
            this.cbxMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(229, 41);
            this.cbxMateria.TabIndex = 4;
            this.cbxMateria.SelectedIndexChanged += new System.EventHandler(this.cbxMateria_SelectedIndexChanged);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.BackgroundImage")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(1148, 20);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(151, 63);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblQueEs
            // 
            this.lblQueEs.AutoSize = true;
            this.lblQueEs.BackColor = System.Drawing.Color.White;
            this.lblQueEs.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueEs.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblQueEs.Location = new System.Drawing.Point(104, 245);
            this.lblQueEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueEs.Name = "lblQueEs";
            this.lblQueEs.Size = new System.Drawing.Size(126, 45);
            this.lblQueEs.TabIndex = 6;
            this.lblQueEs.Text = "¿Que Es?";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.White;
            this.lblMateria.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMateria.Location = new System.Drawing.Point(76, 398);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(114, 45);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "Materia";
            // 
            // publicationsPanel
            // 
            this.publicationsPanel.AutoScroll = true;
            this.publicationsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("publicationsPanel.BackgroundImage")));
            this.publicationsPanel.Controls.Add(this.vScrollBar1);
            this.publicationsPanel.Location = new System.Drawing.Point(388, 105);
            this.publicationsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publicationsPanel.Name = "publicationsPanel";
            this.publicationsPanel.Size = new System.Drawing.Size(911, 585);
            this.publicationsPanel.TabIndex = 10;

            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(495, -37);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 35);
            this.vScrollBar1.TabIndex = 11;
            // 
            // cbxColor
            // 
            this.cbxColor.BackColor = System.Drawing.Color.LightGray;
            this.cbxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Rojo",
            "Amarillo",
            "Azul",
            "Verde",
            "Marron",
            "Violeta",
            "Magenta",
            "Cian",
            "Gris",
            "Negro",
            "Blanco",
            "Naranja",
            "Rosa",
            "Transparente",
            "No Importa"});
            this.cbxColor.Location = new System.Drawing.Point(74, 447);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(229, 39);
            this.cbxColor.TabIndex = 11;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // lbQueColor
            // 
            this.lbQueColor.AutoSize = true;
            this.lbQueColor.BackColor = System.Drawing.Color.White;
            this.lbQueColor.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQueColor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbQueColor.Location = new System.Drawing.Point(72, 398);
            this.lbQueColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQueColor.Name = "lbQueColor";
            this.lbQueColor.Size = new System.Drawing.Size(231, 45);
            this.lbQueColor.TabIndex = 12;
            this.lbQueColor.Text = "¿De que color es?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 585);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 101);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbQueColor);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.publicationsPanel);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblQueEs);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Publicaciones";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.Publicaciones_Load);
            this.publicationsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel publicationsPanel;
        private VScrollBar vScrollBar1;
        private ComboBox cbxColor;
        private Label lbQueColor;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}