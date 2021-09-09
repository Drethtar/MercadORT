
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
            this.SuspendLayout();
            // 
            // txtMailPerdiContra
            // 
            this.txtMailPerdiContra.Location = new System.Drawing.Point(275, 219);
            this.txtMailPerdiContra.Name = "txtMailPerdiContra";
            this.txtMailPerdiContra.Size = new System.Drawing.Size(172, 20);
            this.txtMailPerdiContra.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico";
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.Location = new System.Drawing.Point(295, 260);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(133, 23);
            this.btnRecuperarContra.TabIndex = 2;
            this.btnRecuperarContra.Text = "Recuperar Contraseña";
            this.btnRecuperarContra.UseVisualStyleBackColor = true;
            this.btnRecuperarContra.Click += new System.EventHandler(this.btnRecuperarContra_Click);
            // 
            // OlvideMiContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMailPerdiContra);
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
    }
}