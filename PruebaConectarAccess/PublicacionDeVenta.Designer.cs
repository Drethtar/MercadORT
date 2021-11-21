
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioApunte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(443, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Qué Queres Vender?";
            // 
            // cbxQueEs
            // 
            this.cbxQueEs.BackColor = System.Drawing.Color.LightGray;
            this.cbxQueEs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxQueEs.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQueEs.FormattingEnabled = true;
            this.cbxQueEs.Items.AddRange(new object[] {
            "Libro",
            "Util",
            "Apunte"});
            this.cbxQueEs.Location = new System.Drawing.Point(440, 292);
            this.cbxQueEs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxQueEs.Name = "cbxQueEs";
            this.cbxQueEs.Size = new System.Drawing.Size(380, 63);
            this.cbxQueEs.TabIndex = 1;
            this.cbxQueEs.SelectedIndexChanged += new System.EventHandler(this.cbxQueEs_SelectedIndexChanged);
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.BackColor = System.Drawing.Color.LightGray;
            this.txtTituloLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloLibro.Location = new System.Drawing.Point(440, 434);
            this.txtTituloLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloLibro.Multiline = true;
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(381, 65);
            this.txtTituloLibro.TabIndex = 2;
            // 
            // txtTituloUtil
            // 
            this.txtTituloUtil.BackColor = System.Drawing.Color.LightGray;
            this.txtTituloUtil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloUtil.Location = new System.Drawing.Point(440, 434);
            this.txtTituloUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloUtil.Multiline = true;
            this.txtTituloUtil.Name = "txtTituloUtil";
            this.txtTituloUtil.Size = new System.Drawing.Size(381, 65);
            this.txtTituloUtil.TabIndex = 4;
            // 
            // txtTituloApunte
            // 
            this.txtTituloApunte.BackColor = System.Drawing.Color.LightGray;
            this.txtTituloApunte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloApunte.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTituloApunte.Location = new System.Drawing.Point(440, 434);
            this.txtTituloApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloApunte.Multiline = true;
            this.txtTituloApunte.Name = "txtTituloApunte";
            this.txtTituloApunte.Size = new System.Drawing.Size(380, 65);
            this.txtTituloApunte.TabIndex = 5;
            // 
            // llTituloLibro
            // 
            this.llTituloLibro.AutoSize = true;
            this.llTituloLibro.BackColor = System.Drawing.Color.White;
            this.llTituloLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llTituloLibro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llTituloLibro.Location = new System.Drawing.Point(443, 377);
            this.llTituloLibro.Name = "llTituloLibro";
            this.llTituloLibro.Size = new System.Drawing.Size(402, 57);
            this.llTituloLibro.TabIndex = 7;
            this.llTituloLibro.Text = "Titulo de la Publicación  ";
            // 
            // llTituloUtil
            // 
            this.llTituloUtil.AutoSize = true;
            this.llTituloUtil.BackColor = System.Drawing.Color.White;
            this.llTituloUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llTituloUtil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llTituloUtil.Location = new System.Drawing.Point(443, 377);
            this.llTituloUtil.Name = "llTituloUtil";
            this.llTituloUtil.Size = new System.Drawing.Size(384, 57);
            this.llTituloUtil.TabIndex = 8;
            this.llTituloUtil.Text = "Título de la Publicación";
            // 
            // llTituloApunte
            // 
            this.llTituloApunte.AutoSize = true;
            this.llTituloApunte.BackColor = System.Drawing.Color.White;
            this.llTituloApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llTituloApunte.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llTituloApunte.Location = new System.Drawing.Point(444, 377);
            this.llTituloApunte.Name = "llTituloApunte";
            this.llTituloApunte.Size = new System.Drawing.Size(384, 57);
            this.llTituloApunte.TabIndex = 9;
            this.llTituloApunte.Text = "Título de la Publicación";
            // 
            // llMateriaLibro
            // 
            this.llMateriaLibro.AutoSize = true;
            this.llMateriaLibro.BackColor = System.Drawing.Color.White;
            this.llMateriaLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llMateriaLibro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llMateriaLibro.Location = new System.Drawing.Point(1087, 223);
            this.llMateriaLibro.Name = "llMateriaLibro";
            this.llMateriaLibro.Size = new System.Drawing.Size(287, 57);
            this.llMateriaLibro.TabIndex = 12;
            this.llMateriaLibro.Text = "Materia del Libro";
            // 
            // cbxMateriaLibro
            // 
            this.cbxMateriaLibro.BackColor = System.Drawing.Color.LightGray;
            this.cbxMateriaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMateriaLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxMateriaLibro.Location = new System.Drawing.Point(1083, 292);
            this.cbxMateriaLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMateriaLibro.Name = "cbxMateriaLibro";
            this.cbxMateriaLibro.Size = new System.Drawing.Size(380, 39);
            this.cbxMateriaLibro.TabIndex = 13;
            // 
            // llColorUtil
            // 
            this.llColorUtil.AutoSize = true;
            this.llColorUtil.BackColor = System.Drawing.Color.White;
            this.llColorUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llColorUtil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llColorUtil.Location = new System.Drawing.Point(1087, 223);
            this.llColorUtil.Name = "llColorUtil";
            this.llColorUtil.Size = new System.Drawing.Size(224, 57);
            this.llColorUtil.TabIndex = 14;
            this.llColorUtil.Text = "Color del Util";
            // 
            // cbxColorUtil
            // 
            this.cbxColorUtil.BackColor = System.Drawing.Color.LightGray;
            this.cbxColorUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColorUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxColorUtil.Location = new System.Drawing.Point(1083, 292);
            this.cbxColorUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxColorUtil.Name = "cbxColorUtil";
            this.cbxColorUtil.Size = new System.Drawing.Size(380, 39);
            this.cbxColorUtil.TabIndex = 15;
            // 
            // llMateriaApunte
            // 
            this.llMateriaApunte.AutoSize = true;
            this.llMateriaApunte.BackColor = System.Drawing.Color.White;
            this.llMateriaApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llMateriaApunte.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llMateriaApunte.Location = new System.Drawing.Point(1073, 223);
            this.llMateriaApunte.Name = "llMateriaApunte";
            this.llMateriaApunte.Size = new System.Drawing.Size(317, 57);
            this.llMateriaApunte.TabIndex = 16;
            this.llMateriaApunte.Text = "Materia del Apunte";
            // 
            // cbxMateriaApunte
            // 
            this.cbxMateriaApunte.BackColor = System.Drawing.Color.LightGray;
            this.cbxMateriaApunte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMateriaApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxMateriaApunte.Location = new System.Drawing.Point(1083, 292);
            this.cbxMateriaApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMateriaApunte.Name = "cbxMateriaApunte";
            this.cbxMateriaApunte.Size = new System.Drawing.Size(380, 39);
            this.cbxMateriaApunte.TabIndex = 17;
            // 
            // numPrecioLibro
            // 
            this.numPrecioLibro.BackColor = System.Drawing.Color.LightGray;
            this.numPrecioLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecioLibro.DecimalPlaces = 2;
            this.numPrecioLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecioLibro.Location = new System.Drawing.Point(440, 583);
            this.numPrecioLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioLibro.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioLibro.Name = "numPrecioLibro";
            this.numPrecioLibro.Size = new System.Drawing.Size(380, 59);
            this.numPrecioLibro.TabIndex = 22;
            this.numPrecioLibro.ThousandsSeparator = true;
            // 
            // numPrecioApunte
            // 
            this.numPrecioApunte.BackColor = System.Drawing.Color.LightGray;
            this.numPrecioApunte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecioApunte.DecimalPlaces = 2;
            this.numPrecioApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecioApunte.Location = new System.Drawing.Point(440, 582);
            this.numPrecioApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioApunte.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioApunte.Name = "numPrecioApunte";
            this.numPrecioApunte.Size = new System.Drawing.Size(380, 59);
            this.numPrecioApunte.TabIndex = 23;
            this.numPrecioApunte.ThousandsSeparator = true;
            // 
            // numPrecioUtil
            // 
            this.numPrecioUtil.BackColor = System.Drawing.Color.LightGray;
            this.numPrecioUtil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecioUtil.DecimalPlaces = 2;
            this.numPrecioUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecioUtil.Location = new System.Drawing.Point(440, 582);
            this.numPrecioUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numPrecioUtil.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numPrecioUtil.Name = "numPrecioUtil";
            this.numPrecioUtil.Size = new System.Drawing.Size(380, 59);
            this.numPrecioUtil.TabIndex = 24;
            this.numPrecioUtil.ThousandsSeparator = true;
            // 
            // llPrecioLibro
            // 
            this.llPrecioLibro.AutoSize = true;
            this.llPrecioLibro.BackColor = System.Drawing.Color.White;
            this.llPrecioLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrecioLibro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llPrecioLibro.Location = new System.Drawing.Point(443, 513);
            this.llPrecioLibro.Name = "llPrecioLibro";
            this.llPrecioLibro.Size = new System.Drawing.Size(267, 57);
            this.llPrecioLibro.TabIndex = 25;
            this.llPrecioLibro.Text = "Precio del Libro";
            // 
            // llPrecioUtil
            // 
            this.llPrecioUtil.AutoSize = true;
            this.llPrecioUtil.BackColor = System.Drawing.Color.White;
            this.llPrecioUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrecioUtil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llPrecioUtil.Location = new System.Drawing.Point(444, 513);
            this.llPrecioUtil.Name = "llPrecioUtil";
            this.llPrecioUtil.Size = new System.Drawing.Size(240, 57);
            this.llPrecioUtil.TabIndex = 26;
            this.llPrecioUtil.Text = "Precio del Util";
            // 
            // llPrecioApunte
            // 
            this.llPrecioApunte.AutoSize = true;
            this.llPrecioApunte.BackColor = System.Drawing.Color.White;
            this.llPrecioApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrecioApunte.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llPrecioApunte.Location = new System.Drawing.Point(444, 513);
            this.llPrecioApunte.Name = "llPrecioApunte";
            this.llPrecioApunte.Size = new System.Drawing.Size(297, 57);
            this.llPrecioApunte.TabIndex = 27;
            this.llPrecioApunte.Text = "Precio del Apunte";
            // 
            // llDescLibro
            // 
            this.llDescLibro.AutoSize = true;
            this.llDescLibro.BackColor = System.Drawing.Color.White;
            this.llDescLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDescLibro.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llDescLibro.Location = new System.Drawing.Point(1087, 353);
            this.llDescLibro.Name = "llDescLibro";
            this.llDescLibro.Size = new System.Drawing.Size(206, 57);
            this.llDescLibro.TabIndex = 28;
            this.llDescLibro.Text = "Descripción";
            // 
            // llDescUtil
            // 
            this.llDescUtil.AutoSize = true;
            this.llDescUtil.BackColor = System.Drawing.Color.White;
            this.llDescUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDescUtil.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llDescUtil.Location = new System.Drawing.Point(1087, 352);
            this.llDescUtil.Name = "llDescUtil";
            this.llDescUtil.Size = new System.Drawing.Size(206, 57);
            this.llDescUtil.TabIndex = 29;
            this.llDescUtil.Text = "Descripción";
            // 
            // llDescApunte
            // 
            this.llDescApunte.AutoSize = true;
            this.llDescApunte.BackColor = System.Drawing.Color.White;
            this.llDescApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llDescApunte.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.llDescApunte.Location = new System.Drawing.Point(1087, 352);
            this.llDescApunte.Name = "llDescApunte";
            this.llDescApunte.Size = new System.Drawing.Size(206, 57);
            this.llDescApunte.TabIndex = 30;
            this.llDescApunte.Text = "Descripción";
            // 
            // txtDescLibro
            // 
            this.txtDescLibro.BackColor = System.Drawing.Color.LightGray;
            this.txtDescLibro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescLibro.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescLibro.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescLibro.Location = new System.Drawing.Point(1083, 412);
            this.txtDescLibro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescLibro.Multiline = true;
            this.txtDescLibro.Name = "txtDescLibro";
            this.txtDescLibro.Size = new System.Drawing.Size(353, 230);
            this.txtDescLibro.TabIndex = 31;
            this.txtDescLibro.Text = "Ej: Que tan usado está, editorial, etc.";
            this.txtDescLibro.Enter += new System.EventHandler(this.txtDescLibro_Enter);
            this.txtDescLibro.Leave += new System.EventHandler(this.txtDescLibro_Leave);
            // 
            // txtDescUtil
            // 
            this.txtDescUtil.BackColor = System.Drawing.Color.LightGray;
            this.txtDescUtil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescUtil.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescUtil.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescUtil.Location = new System.Drawing.Point(1083, 411);
            this.txtDescUtil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescUtil.Multiline = true;
            this.txtDescUtil.Name = "txtDescUtil";
            this.txtDescUtil.Size = new System.Drawing.Size(353, 231);
            this.txtDescUtil.TabIndex = 32;
            this.txtDescUtil.Text = "Ej: Que tan usado está, distintas descripciones segun el útil que se este vendien" +
    "do, etc.";
            this.txtDescUtil.Enter += new System.EventHandler(this.txtDescUtil_Enter);
            this.txtDescUtil.Leave += new System.EventHandler(this.txtDescUtil_Leave);
            // 
            // txtDescApunte
            // 
            this.txtDescApunte.BackColor = System.Drawing.Color.LightGray;
            this.txtDescApunte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescApunte.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescApunte.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescApunte.Location = new System.Drawing.Point(1083, 410);
            this.txtDescApunte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescApunte.Multiline = true;
            this.txtDescApunte.Name = "txtDescApunte";
            this.txtDescApunte.Size = new System.Drawing.Size(353, 231);
            this.txtDescApunte.TabIndex = 33;
            this.txtDescApunte.Text = "Ej: Si es digital o fisico, sobre que tema se trata, etc.";
            this.txtDescApunte.Enter += new System.EventHandler(this.txtDescApunte_Enter);
            this.txtDescApunte.Leave += new System.EventHandler(this.txtDescApunte_Leave);
            // 
            // btnPublicar
            // 
            this.btnPublicar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPublicar.BackgroundImage")));
            this.btnPublicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicar.FlatAppearance.BorderSize = 0;
            this.btnPublicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPublicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicar.Location = new System.Drawing.Point(879, 690);
            this.btnPublicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(153, 59);
            this.btnPublicar.TabIndex = 34;
            this.btnPublicar.UseVisualStyleBackColor = true;
            this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(75, 815);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(179, 68);
            this.btnAtras.TabIndex = 35;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1173, 750);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(877, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 122);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(877, 333);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(153, 227);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 38;
            this.pbImagen.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(877, 566);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(153, 23);
            this.btnExaminar.TabIndex = 39;
            this.btnExaminar.Text = "Elegir Foto";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // PublicacionDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.pictureBox2);
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
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PublicacionDeVenta";
            this.Text = "PublicacionDeVenta";
            this.Load += new System.EventHandler(this.PublicacionDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioApunte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnExaminar;
    }
}