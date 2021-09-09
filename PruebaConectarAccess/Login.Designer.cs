namespace PruebaConectarAccess
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llCrearCuenta = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.LLCambiarPassword = new System.Windows.Forms.Label();
            this.llOlvideMiPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(311, 158);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(311, 258);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(122, 20);
            this.txtContra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contrasena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inicio de Sesion";
            // 
            // llCrearCuenta
            // 
            this.llCrearCuenta.AutoSize = true;
            this.llCrearCuenta.Location = new System.Drawing.Point(340, 373);
            this.llCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCrearCuenta.Name = "llCrearCuenta";
            this.llCrearCuenta.Size = new System.Drawing.Size(60, 13);
            this.llCrearCuenta.TabIndex = 6;
            this.llCrearCuenta.Text = "Registrarse";
            this.llCrearCuenta.Click += new System.EventHandler(this.llCrearCuenta_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(320, 332);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(102, 31);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // LLCambiarPassword
            // 
            this.LLCambiarPassword.AutoSize = true;
            this.LLCambiarPassword.Location = new System.Drawing.Point(321, 394);
            this.LLCambiarPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLCambiarPassword.Name = "LLCambiarPassword";
            this.LLCambiarPassword.Size = new System.Drawing.Size(102, 13);
            this.LLCambiarPassword.TabIndex = 8;
            this.LLCambiarPassword.Text = "Cambiar Contraseña";
            this.LLCambiarPassword.Click += new System.EventHandler(this.llOlvideMiPassword_Click);
            // 
            // llOlvideMiPassword
            // 
            this.llOlvideMiPassword.AutoSize = true;
            this.llOlvideMiPassword.Location = new System.Drawing.Point(321, 416);
            this.llOlvideMiPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llOlvideMiPassword.Name = "llOlvideMiPassword";
            this.llOlvideMiPassword.Size = new System.Drawing.Size(106, 13);
            this.llOlvideMiPassword.TabIndex = 9;
            this.llOlvideMiPassword.Text = "Olvide mi contraseña";
            this.llOlvideMiPassword.Click += new System.EventHandler(this.llOlvideMiPassword_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llOlvideMiPassword);
            this.Controls.Add(this.LLCambiarPassword);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.llCrearCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label llCrearCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label LLCambiarPassword;
        private System.Windows.Forms.Label llOlvideMiPassword;
    }
}

