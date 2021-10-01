
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
            this.publicationsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(9, 328);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(74, 28);
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
            this.cbxMaterial.Location = new System.Drawing.Point(123, 10);
            this.cbxMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(102, 21);
            this.cbxMaterial.TabIndex = 2;
            this.cbxMaterial.SelectedIndexChanged += new System.EventHandler(this.cbxMaterial_SelectedIndexChanged);
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
            this.cbxMateria.Location = new System.Drawing.Point(442, 10);
            this.cbxMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(138, 21);
            this.cbxMateria.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(9, 286);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(74, 37);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblQueEs
            // 
            this.lblQueEs.AutoSize = true;
            this.lblQueEs.Location = new System.Drawing.Point(228, 12);
            this.lblQueEs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQueEs.Name = "lblQueEs";
            this.lblQueEs.Size = new System.Drawing.Size(48, 13);
            this.lblQueEs.TabIndex = 6;
            this.lblQueEs.Text = "Que Es?";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(398, 12);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 7;
            this.lblMateria.Text = "Materia";
            // 
            // publicationsPanel
            // 
            this.publicationsPanel.AutoScroll = true;
            this.publicationsPanel.Controls.Add(this.vScrollBar1);
            this.publicationsPanel.Location = new System.Drawing.Point(88, 35);
            this.publicationsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.publicationsPanel.Name = "publicationsPanel";
            this.publicationsPanel.Size = new System.Drawing.Size(511, 333);
            this.publicationsPanel.TabIndex = 10;
            this.publicationsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.publicationsPanel_Paint);
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
            this.cbxColor.Location = new System.Drawing.Point(442, 10);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(138, 21);
            this.cbxColor.TabIndex = 11;
            // 
            // lbQueColor
            // 
            this.lbQueColor.AutoSize = true;
            this.lbQueColor.Location = new System.Drawing.Point(349, 13);
            this.lbQueColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQueColor.Name = "lbQueColor";
            this.lbQueColor.Size = new System.Drawing.Size(88, 13);
            this.lbQueColor.TabIndex = 12;
            this.lbQueColor.Text = "De que color es?";
            // 
            // Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbQueColor);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.publicationsPanel);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblQueEs);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.cbxMateria);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.btnAtras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Publicaciones";
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.Publicaciones_Load);
            this.publicationsPanel.ResumeLayout(false);
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
    }
}