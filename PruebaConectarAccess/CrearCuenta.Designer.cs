namespace PruebaConectarAccess
{
    partial class CrearCuenta
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
            this.btnInsertarDatos = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.cbxOrientacion = new System.Windows.Forms.ComboBox();
            this.llOrientacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxLetra = new System.Windows.Forms.ComboBox();
            this.llLetra = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertarDatos
            // 
            this.btnInsertarDatos.Location = new System.Drawing.Point(469, 479);
            this.btnInsertarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertarDatos.Name = "btnInsertarDatos";
            this.btnInsertarDatos.Size = new System.Drawing.Size(100, 28);
            this.btnInsertarDatos.TabIndex = 0;
            this.btnInsertarDatos.TabStop = false;
            this.btnInsertarDatos.Text = "Cargar Datos";
            this.btnInsertarDatos.UseVisualStyleBackColor = true;
            this.btnInsertarDatos.Click += new System.EventHandler(this.btnInsertarDatos_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(243, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(297, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(243, 267);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(297, 22);
            this.txtMail.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(245, 384);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(297, 22);
            this.txtContra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crear Cuenta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "7mo",
            "1ro",
            "2do",
            "3ro",
            "4to",
            "5to"});
            this.cbxCurso.Location = new System.Drawing.Point(615, 148);
            this.cbxCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(121, 24);
            this.cbxCurso.TabIndex = 11;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // cbxOrientacion
            // 
            this.cbxOrientacion.FormattingEnabled = true;
            this.cbxOrientacion.Location = new System.Drawing.Point(615, 267);
            this.cbxOrientacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOrientacion.Name = "cbxOrientacion";
            this.cbxOrientacion.Size = new System.Drawing.Size(121, 24);
            this.cbxOrientacion.TabIndex = 12;
            this.cbxOrientacion.SelectedIndexChanged += new System.EventHandler(this.cbxOrientacion_SelectedIndexChanged);
            // 
            // llOrientacion
            // 
            this.llOrientacion.AutoSize = true;
            this.llOrientacion.Location = new System.Drawing.Point(615, 229);
            this.llOrientacion.Name = "llOrientacion";
            this.llOrientacion.Size = new System.Drawing.Size(81, 17);
            this.llOrientacion.TabIndex = 13;
            this.llOrientacion.Text = "Orientacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Curso";
            // 
            // cbxLetra
            // 
            this.cbxLetra.FormattingEnabled = true;
            this.cbxLetra.Location = new System.Drawing.Point(615, 384);
            this.cbxLetra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLetra.Name = "cbxLetra";
            this.cbxLetra.Size = new System.Drawing.Size(121, 24);
            this.cbxLetra.TabIndex = 15;
            // 
            // llLetra
            // 
            this.llLetra.AutoSize = true;
            this.llLetra.Location = new System.Drawing.Point(615, 350);
            this.llLetra.Name = "llLetra";
            this.llLetra.Size = new System.Drawing.Size(41, 17);
            this.llLetra.TabIndex = 16;
            this.llLetra.Text = "Letra";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(246, 479);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 28);
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.llLetra);
            this.Controls.Add(this.cbxLetra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llOrientacion);
            this.Controls.Add(this.cbxOrientacion);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnInsertarDatos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.ComboBox cbxOrientacion;
        private System.Windows.Forms.Label llOrientacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxLetra;
        private System.Windows.Forms.Label llLetra;
        private System.Windows.Forms.Button btnAtras;
    }
}