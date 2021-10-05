
namespace PruebaConectarAccess
{
    partial class MisPublicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisPublicaciones));
            this.btnAtras = new System.Windows.Forms.Button();
            this.MyPublicationsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(9, 330);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 26);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // MyPublicationsPanel
            // 
            this.MyPublicationsPanel.AutoScroll = true;
            this.MyPublicationsPanel.Location = new System.Drawing.Point(95, 10);
            this.MyPublicationsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MyPublicationsPanel.Name = "MyPublicationsPanel";
            this.MyPublicationsPanel.Size = new System.Drawing.Size(496, 346);
            this.MyPublicationsPanel.TabIndex = 6;
            // 
            // MisPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.MyPublicationsPanel);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MisPublicaciones";
            this.Text = "MisPublicaciones";
            this.Load += new System.EventHandler(this.MisPublicaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel MyPublicationsPanel;
    }
}