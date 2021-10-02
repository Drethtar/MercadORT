
namespace PruebaConectarAccess
{
    partial class PublicacionDeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicacionDeVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxQueEs = new System.Windows.Forms.ComboBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtTituloUtil = new System.Windows.Forms.TextBox();
            this.txtTituloApunte = new System.Windows.Forms.TextBox();
            this.llTituloLibro = new System.Windows.Forms.Label();
            this.llTituloUtil = new System.Windows.Forms.Label();
            this.llTituloApunte = new System.Windows.Forms.Label();
            this.llMateriaLibro = new System.Windows.Forms.Label();
            this.cbxMateriaLibro = new System.Windows.Forms.ComboBox();
            this.llColorUtil = new System.Windows.Forms.Label();
            this.cbxColorUtil = new System.Windows.Forms.ComboBox();
            this.llMateriaApunte = new System.Windows.Forms.Label();
            this.cbxMateriaApunte = new System.Windows.Forms.ComboBox();
            this.numPrecioLibro = new System.Windows.Forms.NumericUpDown();
            this.numPrecioApunte = new System.Windows.Forms.NumericUpDown();
            this.numPrecioUtil = new System.Windows.Forms.NumericUpDown();
            this.llPrecioLibro = new System.Windows.Forms.Label();
            this.llPrecioUtil = new System.Windows.Forms.Label();
            this.llPrecioApunte = new System.Windows.Forms.Label();
            this.llDescLibro = new System.Windows.Forms.Label();
            this.llDescUtil = new System.Windows.Forms.Label();
            this.llDescApunte = new System.Windows.Forms.Label();
            this.txtDescLibro = new System.Windows.Forms.TextBox();
            this.txtDescUtil = new System.Windows.Forms.TextBox();
            this.txtDescApunte = new System.Windows.Forms.TextBox();
            this.btnPublicar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioApunte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUtil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que Queres Vender?";
            // 
            // cbxQueEs
            // 
            this.cbxQueEs.FormattingEnabled = true;
            this.cbxQueEs.Items.AddRange(new object[] {
            "Libro",
            "Util",
            "Apunte"});
            this.cbxQueEs.Location = new System.Drawing.Point(333, 30);
            this.cbxQueEs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxQueEs.Name = "cbxQueEs";
            this.cbxQueEs.Size = new System.Drawing.Size(121, 24);
            this.cbxQueEs.TabIndex = 1;
            this.cbxQueEs.SelectedIndexChanged += new System.EventHandler(this.cbxQueEs_SelectedIndexChanged);
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(324, 95);
            this.txtTituloLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(155, 22);
            this.txtTituloLibro.TabIndex = 2;
            // 
            // txtTituloUtil
            // 
            this.txtTituloUtil.Location = new System.Drawing.Point(323, 95);
            this.txtTituloUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloUtil.Name = "txtTituloUtil";
            this.txtTituloUtil.Size = new System.Drawing.Size(156, 22);
            this.txtTituloUtil.TabIndex = 4;
            // 
            // txtTituloApunte
            // 
            this.txtTituloApunte.Location = new System.Drawing.Point(325, 95);
            this.txtTituloApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloApunte.Name = "txtTituloApunte";
            this.txtTituloApunte.Size = new System.Drawing.Size(151, 22);
            this.txtTituloApunte.TabIndex = 5;
            // 
            // llTituloLibro
            // 
            this.llTituloLibro.AutoSize = true;
            this.llTituloLibro.Location = new System.Drawing.Point(320, 71);
            this.llTituloLibro.Name = "llTituloLibro";
            this.llTituloLibro.Size = new System.Drawing.Size(154, 17);
            this.llTituloLibro.TabIndex = 7;
            this.llTituloLibro.Text = "Titulo de la Publicacion";
            // 
            // llTituloUtil
            // 
            this.llTituloUtil.AutoSize = true;
            this.llTituloUtil.Location = new System.Drawing.Point(319, 71);
            this.llTituloUtil.Name = "llTituloUtil";
            this.llTituloUtil.Size = new System.Drawing.Size(154, 17);
            this.llTituloUtil.TabIndex = 8;
            this.llTituloUtil.Text = "Titulo de la Publicacion";
            // 
            // llTituloApunte
            // 
            this.llTituloApunte.AutoSize = true;
            this.llTituloApunte.Location = new System.Drawing.Point(323, 71);
            this.llTituloApunte.Name = "llTituloApunte";
            this.llTituloApunte.Size = new System.Drawing.Size(154, 17);
            this.llTituloApunte.TabIndex = 9;
            this.llTituloApunte.Text = "Titulo de la Publicacion";
            // 
            // llMateriaLibro
            // 
            this.llMateriaLibro.AutoSize = true;
            this.llMateriaLibro.Location = new System.Drawing.Point(320, 143);
            this.llMateriaLibro.Name = "llMateriaLibro";
            this.llMateriaLibro.Size = new System.Drawing.Size(114, 17);
            this.llMateriaLibro.TabIndex = 12;
            this.llMateriaLibro.Text = "Materia del Libro";
            // 
            // cbxMateriaLibro
            // 
            this.cbxMateriaLibro.FormattingEnabled = true;
            this.cbxMateriaLibro.Items.AddRange(new object[] {
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
            this.cbxMateriaLibro.Location = new System.Drawing.Point(324, 162);
            this.cbxMateriaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMateriaLibro.Name = "cbxMateriaLibro";
            this.cbxMateriaLibro.Size = new System.Drawing.Size(155, 24);
            this.cbxMateriaLibro.TabIndex = 13;
            // 
            // llColorUtil
            // 
            this.llColorUtil.AutoSize = true;
            this.llColorUtil.Location = new System.Drawing.Point(323, 143);
            this.llColorUtil.Name = "llColorUtil";
            this.llColorUtil.Size = new System.Drawing.Size(88, 17);
            this.llColorUtil.TabIndex = 14;
            this.llColorUtil.Text = "Color del Util";
            // 
            // cbxColorUtil
            // 
            this.cbxColorUtil.FormattingEnabled = true;
            this.cbxColorUtil.Items.AddRange(new object[] {
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
            "No Importa",
            "Otro"});
            this.cbxColorUtil.Location = new System.Drawing.Point(324, 162);
            this.cbxColorUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxColorUtil.Name = "cbxColorUtil";
            this.cbxColorUtil.Size = new System.Drawing.Size(156, 24);
            this.cbxColorUtil.TabIndex = 15;
            // 
            // llMateriaApunte
            // 
            this.llMateriaApunte.AutoSize = true;
            this.llMateriaApunte.Location = new System.Drawing.Point(316, 143);
            this.llMateriaApunte.Name = "llMateriaApunte";
            this.llMateriaApunte.Size = new System.Drawing.Size(127, 17);
            this.llMateriaApunte.TabIndex = 16;
            this.llMateriaApunte.Text = "Materia del Apunte";
            // 
            // cbxMateriaApunte
            // 
            this.cbxMateriaApunte.FormattingEnabled = true;
            this.cbxMateriaApunte.Items.AddRange(new object[] {
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
            this.cbxMateriaApunte.Location = new System.Drawing.Point(326, 162);
            this.cbxMateriaApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMateriaApunte.Name = "cbxMateriaApunte";
            this.cbxMateriaApunte.Size = new System.Drawing.Size(151, 24);
            this.cbxMateriaApunte.TabIndex = 17;
            // 
            // numPrecioLibro
            // 
            this.numPrecioLibro.DecimalPlaces = 2;
            this.numPrecioLibro.Location = new System.Drawing.Point(327, 236);
            this.numPrecioLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioLibro.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioLibro.Name = "numPrecioLibro";
            this.numPrecioLibro.Size = new System.Drawing.Size(155, 22);
            this.numPrecioLibro.TabIndex = 22;
            this.numPrecioLibro.ThousandsSeparator = true;
            // 
            // numPrecioApunte
            // 
            this.numPrecioApunte.DecimalPlaces = 2;
            this.numPrecioApunte.Location = new System.Drawing.Point(324, 236);
            this.numPrecioApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioApunte.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioApunte.Name = "numPrecioApunte";
            this.numPrecioApunte.Size = new System.Drawing.Size(151, 22);
            this.numPrecioApunte.TabIndex = 23;
            this.numPrecioApunte.ThousandsSeparator = true;
            // 
            // numPrecioUtil
            // 
            this.numPrecioUtil.DecimalPlaces = 2;
            this.numPrecioUtil.Location = new System.Drawing.Point(325, 236);
            this.numPrecioUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioUtil.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioUtil.Name = "numPrecioUtil";
            this.numPrecioUtil.Size = new System.Drawing.Size(156, 22);
            this.numPrecioUtil.TabIndex = 24;
            this.numPrecioUtil.ThousandsSeparator = true;
            // 
            // llPrecioLibro
            // 
            this.llPrecioLibro.AutoSize = true;
            this.llPrecioLibro.Location = new System.Drawing.Point(323, 218);
            this.llPrecioLibro.Name = "llPrecioLibro";
            this.llPrecioLibro.Size = new System.Drawing.Size(107, 17);
            this.llPrecioLibro.TabIndex = 25;
            this.llPrecioLibro.Text = "Precio del Libro";
            // 
            // llPrecioUtil
            // 
            this.llPrecioUtil.AutoSize = true;
            this.llPrecioUtil.Location = new System.Drawing.Point(323, 218);
            this.llPrecioUtil.Name = "llPrecioUtil";
            this.llPrecioUtil.Size = new System.Drawing.Size(95, 17);
            this.llPrecioUtil.TabIndex = 26;
            this.llPrecioUtil.Text = "Precio del Util";
            // 
            // llPrecioApunte
            // 
            this.llPrecioApunte.AutoSize = true;
            this.llPrecioApunte.Location = new System.Drawing.Point(323, 218);
            this.llPrecioApunte.Name = "llPrecioApunte";
            this.llPrecioApunte.Size = new System.Drawing.Size(120, 17);
            this.llPrecioApunte.TabIndex = 27;
            this.llPrecioApunte.Text = "Precio del Apunte";
            // 
            // llDescLibro
            // 
            this.llDescLibro.AutoSize = true;
            this.llDescLibro.Location = new System.Drawing.Point(317, 284);
            this.llDescLibro.Name = "llDescLibro";
            this.llDescLibro.Size = new System.Drawing.Size(82, 17);
            this.llDescLibro.TabIndex = 28;
            this.llDescLibro.Text = "Descripcion";
            // 
            // llDescUtil
            // 
            this.llDescUtil.AutoSize = true;
            this.llDescUtil.Location = new System.Drawing.Point(320, 283);
            this.llDescUtil.Name = "llDescUtil";
            this.llDescUtil.Size = new System.Drawing.Size(82, 17);
            this.llDescUtil.TabIndex = 29;
            this.llDescUtil.Text = "Descripcion";
            // 
            // llDescApunte
            // 
            this.llDescApunte.AutoSize = true;
            this.llDescApunte.Location = new System.Drawing.Point(320, 284);
            this.llDescApunte.Name = "llDescApunte";
            this.llDescApunte.Size = new System.Drawing.Size(82, 17);
            this.llDescApunte.TabIndex = 30;
            this.llDescApunte.Text = "Descripcion";
            // 
            // txtDescLibro
            // 
            this.txtDescLibro.Location = new System.Drawing.Point(321, 305);
            this.txtDescLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescLibro.Name = "txtDescLibro";
            this.txtDescLibro.Size = new System.Drawing.Size(155, 22);
            this.txtDescLibro.TabIndex = 31;
            // 
            // txtDescUtil
            // 
            this.txtDescUtil.Location = new System.Drawing.Point(321, 303);
            this.txtDescUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescUtil.Name = "txtDescUtil";
            this.txtDescUtil.Size = new System.Drawing.Size(156, 22);
            this.txtDescUtil.TabIndex = 32;
            // 
            // txtDescApunte
            // 
            this.txtDescApunte.Location = new System.Drawing.Point(324, 303);
            this.txtDescApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescApunte.Name = "txtDescApunte";
            this.txtDescApunte.Size = new System.Drawing.Size(151, 22);
            this.txtDescApunte.TabIndex = 33;
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(325, 411);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(153, 27);
            this.btnPublicar.TabIndex = 34;
            this.btnPublicar.Text = "Publicar";
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(213, 411);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(83, 27);
            this.btnAtras.TabIndex = 35;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // PublicacionDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnPublicar);
            this.Controls.Add(this.txtDescApunte);
            this.Controls.Add(this.txtDescUtil);
            this.Controls.Add(this.txtDescLibro);
            this.Controls.Add(this.llDescApunte);
            this.Controls.Add(this.llDescUtil);
            this.Controls.Add(this.llDescLibro);
            this.Controls.Add(this.llPrecioApunte);
            this.Controls.Add(this.llPrecioUtil);
            this.Controls.Add(this.llPrecioLibro);
            this.Controls.Add(this.numPrecioUtil);
            this.Controls.Add(this.numPrecioApunte);
            this.Controls.Add(this.numPrecioLibro);
            this.Controls.Add(this.cbxMateriaApunte);
            this.Controls.Add(this.llMateriaApunte);
            this.Controls.Add(this.cbxColorUtil);
            this.Controls.Add(this.llColorUtil);
            this.Controls.Add(this.cbxMateriaLibro);
            this.Controls.Add(this.llMateriaLibro);
            this.Controls.Add(this.llTituloApunte);
            this.Controls.Add(this.llTituloUtil);
            this.Controls.Add(this.llTituloLibro);
            this.Controls.Add(this.txtTituloApunte);
            this.Controls.Add(this.txtTituloUtil);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.cbxQueEs);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PublicacionDeVenta";
            this.Text = "PublicacionDeVenta";
            this.Load += new System.EventHandler(this.PublicacionDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioApunte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUtil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxQueEs;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtTituloUtil;
        private System.Windows.Forms.TextBox txtTituloApunte;
        private System.Windows.Forms.Label llTituloLibro;
        private System.Windows.Forms.Label llTituloUtil;
        private System.Windows.Forms.Label llTituloApunte;
        private System.Windows.Forms.Label llMateriaLibro;
        private System.Windows.Forms.ComboBox cbxMateriaLibro;
        private System.Windows.Forms.Label llColorUtil;
        private System.Windows.Forms.ComboBox cbxColorUtil;
        private System.Windows.Forms.Label llMateriaApunte;
        private System.Windows.Forms.ComboBox cbxMateriaApunte;
        private System.Windows.Forms.NumericUpDown numPrecioLibro;
        private System.Windows.Forms.NumericUpDown numPrecioApunte;
        private System.Windows.Forms.NumericUpDown numPrecioUtil;
        private System.Windows.Forms.Label llPrecioLibro;
        private System.Windows.Forms.Label llPrecioUtil;
        private System.Windows.Forms.Label llPrecioApunte;
        private System.Windows.Forms.Label llDescLibro;
        private System.Windows.Forms.Label llDescUtil;
        private System.Windows.Forms.Label llDescApunte;
        private System.Windows.Forms.TextBox txtDescLibro;
        private System.Windows.Forms.TextBox txtDescUtil;
        private System.Windows.Forms.TextBox txtDescApunte;
        private System.Windows.Forms.Button btnPublicar;
        private System.Windows.Forms.Button btnAtras;
    }
}