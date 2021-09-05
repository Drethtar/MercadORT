using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary1.Access;

namespace PruebaConectarAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // comment 4 github
            this.Hide();
            new jorge().ShowDialog();   
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* if (new Interaccion().verificarConexion())
                MessageBox.Show("Conexion esta abierta");
            else
                MessageBox.Show("Fallo la conexion D:"); */
        }
    }
}
