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
    public partial class Publicaciones : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Publicaciones()
        {
            InitializeComponent();
        }
        private void Publicaciones_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";

            int CantidadRows = ComprarOVender.CantidadDePublicaciones.CantidadPublicaciones / 3;

            DondeSePublicanLasCosas.RowCount = CantidadRows;


        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ComprarOVender().ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }


    }
}
