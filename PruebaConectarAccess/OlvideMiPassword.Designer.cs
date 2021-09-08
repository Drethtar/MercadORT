
namespace PruebaConectarAccess
{
    partial class OlvideMiPassword
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
            this.txtContraOlvidada1 = new System.Windows.Forms.TextBox();
            this.txtContraOlvidada2 = new System.Windows.Forms.TextBox();
            this.txtNombrePerdiPassword = new System.Windows.Forms.TextBox();
            this.btnCambiarPassword = new System.Windows.Forms.Button();
            this.txtMailPerdiPassword = new System.Windows.Forms.TextBox();
            this.llNombrePerdiPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevaPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtContraOlvidada1
            // 
            this.txtContraOlvidada1.Location = new System.Drawing.Point(303, 184);
            this.txtContraOlvidada1.Name = "txtContraOlvidada1";
            this.txtContraOlvidada1.Size = new System.Drawing.Size(205, 22);
            this.txtContraOlvidada1.TabIndex = 0;
            // 
            // txtContraOlvidada2
            // 
            this.txtContraOlvidada2.Location = new System.Drawing.Point(303, 244);
            this.txtContraOlvidada2.Name = "txtContraOlvidada2";
            this.txtContraOlvidada2.Size = new System.Drawing.Size(205, 22);
            this.txtContraOlvidada2.TabIndex = 1;
            // 
            // txtNombrePerdiPassword
            // 
            this.txtNombrePerdiPassword.Location = new System.Drawing.Point(303, 67);
            this.txtNombrePerdiPassword.Name = "txtNombrePerdiPassword";
            this.txtNombrePerdiPassword.Size = new System.Drawing.Size(205, 22);
            this.txtNombrePerdiPassword.TabIndex = 2;
            // 
            // btnCambiarPassword
            // 
            this.btnCambiarPassword.Location = new System.Drawing.Point(344, 342);
            this.btnCambiarPassword.Name = "btnCambiarPassword";
            this.btnCambiarPassword.Size = new System.Drawing.Size(110, 47);
            this.btnCambiarPassword.TabIndex = 3;
            this.btnCambiarPassword.Text = "Cambiar mi Contraseña";
            this.btnCambiarPassword.UseVisualStyleBackColor = true;
            this.btnCambiarPassword.Click += new System.EventHandler(this.btnCambiarPassword_Click);
            // 
            // txtMailPerdiPassword
            // 
            this.txtMailPerdiPassword.Location = new System.Drawing.Point(303, 125);
            this.txtMailPerdiPassword.Name = "txtMailPerdiPassword";
            this.txtMailPerdiPassword.Size = new System.Drawing.Size(205, 22);
            this.txtMailPerdiPassword.TabIndex = 4;
            // 
            // llNombrePerdiPassword
            // 
            this.llNombrePerdiPassword.AutoSize = true;
            this.llNombrePerdiPassword.Location = new System.Drawing.Point(303, 44);
            this.llNombrePerdiPassword.Name = "llNombrePerdiPassword";
            this.llNombrePerdiPassword.Size = new System.Drawing.Size(131, 17);
            this.llNombrePerdiPassword.TabIndex = 5;
            this.llNombrePerdiPassword.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Direccion de Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Repita la Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nueva Contraseña";
            // 
            // txtNuevaPassword
            // 
            this.txtNuevaPassword.Location = new System.Drawing.Point(303, 297);
            this.txtNuevaPassword.Name = "txtNuevaPassword";
            this.txtNuevaPassword.Size = new System.Drawing.Size(205, 22);
            this.txtNuevaPassword.TabIndex = 10;
            // 
            // OlvideMiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevaPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llNombrePerdiPassword);
            this.Controls.Add(this.txtMailPerdiPassword);
            this.Controls.Add(this.btnCambiarPassword);
            this.Controls.Add(this.txtNombrePerdiPassword);
            this.Controls.Add(this.txtContraOlvidada2);
            this.Controls.Add(this.txtContraOlvidada1);
            this.Name = "OlvideMiPassword";
            this.Text = "OlvideMiPassword";
            this.Load += new System.EventHandler(this.OlvideMiPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraOlvidada1;
        private System.Windows.Forms.TextBox txtContraOlvidada2;
        private System.Windows.Forms.TextBox txtNombrePerdiPassword;
        private System.Windows.Forms.Button btnCambiarPassword;
        private System.Windows.Forms.TextBox txtMailPerdiPassword;
        private System.Windows.Forms.Label llNombrePerdiPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevaPassword;
    }
}