using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConectarAccess
{
    public partial class ComprarOVender : Form
    {
        public ComprarOVender()
        {
            InitializeComponent();
        }

        private void ComprarOVender_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Publicaciones().ShowDialog();
            this.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PublicacionDeVenta().ShowDialog();
            this.Show();
        }
    }
}
