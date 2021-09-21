using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PruebaConectarAccess
{
    public partial class ComprarOVender : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        public ComprarOVender()
        {
            InitializeComponent();
        }

        private void ComprarOVender_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";

            llNombreUsuario.Text = Login.ObtenerDatosUsuario.NombreDelUsuario;

            
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
