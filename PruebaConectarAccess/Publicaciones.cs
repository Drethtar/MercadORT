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

            lblMateria.Hide();
            cbxMateria.Hide();
            lbQueColor.Hide();
            cbxColor.Hide();
        }

        private void addLibrosFromDatabase()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            
            command.CommandText = "SELECT Libros.*, RelacionUsuarioLibros.IDUsuario FROM(Libros INNER JOIN RelacionUsuarioLibros ON Libros.ID = RelacionUsuarioLibros.IDLibros)";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicationItem publication = new PublicationItem();
                publication.Title = reader["TituloLibro"].ToString();
                publication.Description = reader["DescripcionLibro"].ToString();
                publication.Precio = reader["PrecioLibro"].ToString() + "$";
                publication.IdUsuario = reader["IDUsuario"].ToString();
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
                PublicacionApuntes.IdUsuario = reader["IDUsuario"].ToString();
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


            command.CommandText = "SELECT Utiles.*, RelacionUsuarioUtiles.IDUsuario FROM(Utiles INNER JOIN RelacionUsuarioUtiles ON Utiles.ID = RelacionUsuarioUtiles.IDUtiles)";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Apuntes PublicacionUtiles = new Apuntes();
                PublicacionUtiles.TitleApunte = reader["TituloUtiles"].ToString();
                PublicacionUtiles.DescriptionApunte = reader["DescripcionUtiles"].ToString();
                PublicacionUtiles.PrecioApunte = reader["PrecioUtiles"].ToString() + "$";
                PublicacionUtiles.IdUsuario = reader["IDUsuario"].ToString();
                PublicacionUtiles.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(PublicacionUtiles);
            }

            connection.Close();
        }

        //Filtro De que materia es
        private void cbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaterial.Text == "Libro")
            {
                lbQueColor.Hide();
                cbxColor.Hide();
                lblMateria.Show();
                cbxMateria.Show();

                addLibrosFromDatabase();

            }
            else if (cbxMaterial.Text == "Util")
            {
                lblMateria.Hide();
                cbxMateria.Hide();
                lbQueColor.Show();
                cbxColor.Show();

                publicationsPanel.Controls.Clear();

                addUtilesFromDatabase();
            }
            else if (cbxMaterial.Text == "Apunte")
            {
                lbQueColor.Hide();
                cbxColor.Hide();
                lblMateria.Show();
                cbxMateria.Show();

                publicationsPanel.Controls.Clear();

                addApuntesFromDatabase();
            }



        }

        //Filtro de Materia y Color
        private void cbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaterial.Text == "Libro" && cbxMateria.Text != null )
            {
                publicationsPanel.Controls.Clear();

                connection.Open();
                OleDbCommand FiltroLibroMateria = new OleDbCommand();
                FiltroLibroMateria.Connection = connection;

                FiltroLibroMateria.CommandText = "select * from Libros where MateriaLibro='" + cbxMateria.Text + "'";
                OleDbDataReader LectorFiltroLibroMateria = FiltroLibroMateria.ExecuteReader();

                while (LectorFiltroLibroMateria.Read())
                {
                    PublicationItem publication = new PublicationItem();
                    publication.Title = LectorFiltroLibroMateria["TituloLibro"].ToString();
                    publication.Description = LectorFiltroLibroMateria["DescripcionLibro"].ToString();
                    publication.Precio = LectorFiltroLibroMateria["PrecioLibro"].ToString() + "$";
                    publication.IdUsuario = LectorFiltroLibroMateria["IDUsuario"].ToString();
                    publication.Dock = DockStyle.Top;
                    publicationsPanel.Controls.Add(publication);
                }

                connection.Close();
            }
            else if (cbxMaterial.Text == "Apunte" && cbxMateria.Text != null)
            {
                publicationsPanel.Controls.Clear();

                connection.Open();
                OleDbCommand FiltroApunteMateria = new OleDbCommand();
                FiltroApunteMateria.Connection = connection;

                FiltroApunteMateria.CommandText = "select * from Apuntes where MateriaApuntes='" + cbxMateria.Text + "'";
                OleDbDataReader LectorFiltroApunteMateria = FiltroApunteMateria.ExecuteReader();

                while (LectorFiltroApunteMateria.Read())
                {
                    PublicationItem publicationApuntes = new PublicationItem();
                    publicationApuntes.Title = LectorFiltroApunteMateria["TituloApuntes"].ToString();
                    publicationApuntes.Description = LectorFiltroApunteMateria["DescripcionApuntes"].ToString();
                    publicationApuntes.Precio = LectorFiltroApunteMateria["PrecioApuntes"].ToString() + "$";
                    publicationApuntes.IdUsuario = LectorFiltroApunteMateria["IDUsuario"].ToString();
                    publicationApuntes.Dock = DockStyle.Top;
                    publicationsPanel.Controls.Add(publicationApuntes);
                }

                connection.Close();
            }
        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaterial.Text == "Util" && cbxColor.Text != null)
            {
                publicationsPanel.Controls.Clear();

                connection.Open();
                OleDbCommand FiltroUtilColor = new OleDbCommand();
                FiltroUtilColor.Connection = connection;

                FiltroUtilColor.CommandText = "select * from Utiles where ColorUtiles='" + cbxColor.Text + "'";
                OleDbDataReader LectorFiltroUtilColor = FiltroUtilColor.ExecuteReader();

                while (LectorFiltroUtilColor.Read())
                {
                    PublicationItem publicationUtiles = new PublicationItem();
                    publicationUtiles.Title = LectorFiltroUtilColor["TituloUtiles"].ToString();
                    publicationUtiles.Description = LectorFiltroUtilColor["DescripcionUtiles"].ToString();
                    publicationUtiles.Precio = LectorFiltroUtilColor["PrecioUtiles"].ToString() + "$";
                    publicationUtiles.IdUsuario = LectorFiltroUtilColor["IDUsuario"].ToString();
                    publicationUtiles.Dock = DockStyle.Top;
                    publicationsPanel.Controls.Add(publicationUtiles);
                }

                connection.Close();
            }
        }
    }
}
