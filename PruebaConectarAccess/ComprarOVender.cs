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

        public static class CantidadDePublicaciones
        {
            public static int CantidadPublicaciones = 0;

            public static int CantidadLibros = 0;

            public static int CantidadUtiles = 0;

            public static int CantidadApuntes = 0;
        }
        private void ComprarOVender_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";

            llNombreUsuario.Text = "Bienvenid@! " + Login.ObtenerDatosUsuario.NombreDelUsuario;

            //////

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            command.CommandText = "select * from Libros";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count += 1;
                int CantidadLibros = count;
            }

            connection.Close();
            connection.Open();

            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;

            command2.CommandText = "select * from Utiles";

            OleDbDataReader reader2 = command2.ExecuteReader();
            int count2 = 0;

            while (reader2.Read())
            {
                count2 += 1;
                int CantidadUtiles = count2;

            }

            connection.Close();
            connection.Open();

            OleDbCommand command3 = new OleDbCommand();
            command3.Connection = connection;

            command3.CommandText = "select * from Apuntes";

            OleDbDataReader reader3 = command3.ExecuteReader();
            int count3 = 0;

            while (reader3.Read())
            {
                count3 += 1;
                int CantidadApuntes = count3;
            }

            ComprarOVender.CantidadDePublicaciones.CantidadLibros = count;
            ComprarOVender.CantidadDePublicaciones.CantidadUtiles = count2;
            ComprarOVender.CantidadDePublicaciones.CantidadApuntes = count3;

            count = count + count2 + count3;

            ComprarOVender.CantidadDePublicaciones.CantidadPublicaciones = count;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            new Publicaciones().ShowDialog(); 
            this.Show();
            new ComprarOVender();
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            new PublicacionDeVenta().ShowDialog();
            this.Show();
            new ComprarOVender();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
            this.Show();
            new ComprarOVender();
            this.Close();
        }

        private void btnMisPublicaciones_Click(object sender, EventArgs e)
        {
            new MisPublicaciones().ShowDialog(); 
            this.Show();
            new ComprarOVender();
            this.Close();
        }
    }
}
