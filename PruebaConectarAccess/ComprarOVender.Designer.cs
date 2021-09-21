
namespace PruebaConectarAccess
{
    partial class ComprarOVender
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.llNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenid@!";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(263, 386);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(108, 52);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(401, 386);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(108, 52);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // llNombreUsuario
            // 
            this.llNombreUsuario.AutoSize = true;
            this.llNombreUsuario.Location = new System.Drawing.Point(358, 35);
            this.llNombreUsuario.Name = "llNombreUsuario";
            this.llNombreUsuario.Size = new System.Drawing.Size(0, 17);
            this.llNombreUsuario.TabIndex = 3;
            this.llNombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ComprarOVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llNombreUsuario);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Name = "ComprarOVender";
            this.Text = "IniciasteSesion";
            this.Load += new System.EventHandler(this.ComprarOVender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label llNombreUsuario;
    }
}