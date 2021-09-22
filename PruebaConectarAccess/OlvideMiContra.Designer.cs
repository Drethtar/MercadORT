
namespace PruebaConectarAccess
{
    partial class OlvideMiContra
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
            this.txtMailPerdiContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecuperarContra = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMailPerdiContra
            // 
            this.txtMailPerdiContra.Location = new System.Drawing.Point(367, 270);
            this.txtMailPerdiContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMailPerdiContra.Name = "txtMailPerdiContra";
            this.txtMailPerdiContra.Size = new System.Drawing.Size(228, 22);
            this.txtMailPerdiContra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico";
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.Location = new System.Drawing.Point(393, 320);
            this.btnRecuperarContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(177, 28);
            this.btnRecuperarContra.TabIndex = 2;
            this.btnRecuperarContra.Text = "Recuperar Contraseña";
            this.btnRecuperarContra.UseVisualStyleBackColor = true;
            this.btnRecuperarContra.Click += new System.EventHandler(this.btnRecuperarContra_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(441, 355);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(83, 28);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // OlvideMiContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailPerdiContra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OlvideMiContra";
            this.Text = "OlvideMiContra";
            this.Load += new System.EventHandler(this.OlvideMiContra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailPerdiContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecuperarContra;
        private System.Windows.Forms.Button btnAtras;
    }
}