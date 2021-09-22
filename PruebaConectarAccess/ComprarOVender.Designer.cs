
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
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.llNombreUsuario = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.llNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llNombreUsuario.Location = new System.Drawing.Point(345, 9);
            this.llNombreUsuario.Name = "llNombreUsuario";
            this.llNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.llNombreUsuario.Size = new System.Drawing.Size(63, 32);
            this.llNombreUsuario.TabIndex = 3;
            this.llNombreUsuario.Text = "123";
            this.llNombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(672, 406);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(116, 32);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // ComprarOVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.llNombreUsuario);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnComprar);
            this.Name = "ComprarOVender";
            this.Text = "IniciasteSesion";
            this.Load += new System.EventHandler(this.ComprarOVender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label llNombreUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}