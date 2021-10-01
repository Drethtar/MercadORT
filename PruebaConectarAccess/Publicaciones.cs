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

        private void DondeSePublicanLasCosas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void publicationsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Publicaciones_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            addLibrosFromDatabase();
            addApuntesFromDatabase();
            addUtilesFromDatabase();
        }

        private void addLibrosFromDatabase()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            
            command.CommandText = "select * from Libros";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicationItem publication = new PublicationItem();
                publication.Title = reader["TituloLibro"].ToString();
                publication.Description = reader["DescripcionLibro"].ToString();
                publication.Precio = reader["PrecioLibro"].ToString() + "$";
                publication.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(publication);
            }

            connection.Close();
        }

        private void addApuntesFromDatabase()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            
            command.CommandText = "select * from Apuntes";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Apuntes PublicacionApuntes = new Apuntes();
                PublicacionApuntes.TitleApunte = reader["TituloApuntes"].ToString();
                PublicacionApuntes.DescriptionApunte = reader["DescripcionApuntes"].ToString();
                PublicacionApuntes.PrecioApunte = reader["PrecioApuntes"].ToString() + "$";
                PublicacionApuntes.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(PublicacionApuntes);
            }

            connection.Close();
        }

        private void addUtilesFromDatabase()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;


            command.CommandText = "select * from Utiles";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Apuntes PublicacionUtiles = new Apuntes();
                PublicacionUtiles.TitleApunte = reader["TituloUtiles"].ToString();
                PublicacionUtiles.DescriptionApunte = reader["DescripcionUtiles"].ToString();
                PublicacionUtiles.PrecioApunte = reader["PrecioUtiles"].ToString() + "$";
                PublicacionUtiles.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(PublicacionUtiles);
            }

            connection.Close();
        }

        private void cbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            publicationsPanel.Controls.Clear();
            //Borra todas las publicaciones para volverlas a cargar
        }
    }
}
