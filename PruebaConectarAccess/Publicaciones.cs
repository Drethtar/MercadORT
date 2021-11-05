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
            new ComprarOVender().ShowDialog();
            this.Show();
            new Publicaciones();
            this.Close();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog(); 
            this.Show();
            new Publicaciones(); 
            this.Close();
        }

        private void Publicaciones_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            this.WindowState = FormWindowState.Maximized;

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
                MessageBox.Show(reader["Foto"].ToString());

                PublicationItem publication = new PublicationItem();
                publication.Title = reader["TituloLibro"].ToString();
                publication.Description = reader["DescripcionLibro"].ToString();
                publication.Precio = reader["PrecioLibro"].ToString() + "$";
                publication.IdUsuario = reader["IDUsuario"].ToString();
                publication.QueEs = "Libro";
                publication.Dock = DockStyle.Top;
                //publication.ImagenPublicacion = reader["Foto"];
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
                PublicationItem publication = new PublicationItem();
                publication.Title = reader["TituloApuntes"].ToString();
                publication.Description = reader["DescripcionApuntes"].ToString();
                publication.Precio = reader["PrecioApuntes"].ToString() + "$";
                publication.IdUsuario = reader["IDUsuario"].ToString();
                publication.QueEs = "Apunte";
                publication.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(publication);
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
                PublicationItem publication = new PublicationItem();
                publication.Title = reader["TituloUtiles"].ToString();
                publication.Description = reader["DescripcionUtiles"].ToString();
                publication.Precio = reader["PrecioUtiles"].ToString() + "$";
                publication.IdUsuario = reader["IDUsuario"].ToString();
                publication.QueEs = "Util";
                publication.Dock = DockStyle.Top;
                publicationsPanel.Controls.Add(publication);
            }

            connection.Close();
        }

        //Filtro que material es
        private void cbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaterial.Text == "Libro")
            {
                lbQueColor.Hide();
                cbxColor.Hide();
                lblMateria.Show();
                cbxMateria.Show();

                publicationsPanel.Controls.Clear();

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

                FiltroLibroMateria.CommandText = "SELECT Libros.ID, Libros.TituloLibro, Libros.MateriaLibro, Libros.PrecioLibro, RelacionUsuarioLibros.IDUsuario, Libros.DescripcionLibro FROM     (Libros INNER JOIN RelacionUsuarioLibros ON Libros.ID = RelacionUsuarioLibros.IDLibros) WHERE  (Libros.MateriaLibro = '"+cbxMateria.Text+"')";
                OleDbDataReader LectorFiltroLibroMateria = FiltroLibroMateria.ExecuteReader();

                while (LectorFiltroLibroMateria.Read())
                {
                    PublicationItem publication = new PublicationItem();
                    publication.Title = LectorFiltroLibroMateria["TituloLibro"].ToString();
                    publication.Description = LectorFiltroLibroMateria["DescripcionLibro"].ToString();
                    publication.Precio = LectorFiltroLibroMateria["PrecioLibro"].ToString() + "$";
                    publication.IdUsuario = LectorFiltroLibroMateria["IDUsuario"].ToString();
                    publication.QueEs = "Libro";
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
                    PublicationItem publication = new PublicationItem();
                    publication.Title = LectorFiltroApunteMateria["TituloApuntes"].ToString();
                    publication.Description = LectorFiltroApunteMateria["DescripcionApuntes"].ToString();
                    publication.Precio = LectorFiltroApunteMateria["PrecioApuntes"].ToString() + "$";
                    publication.IdUsuario = LectorFiltroApunteMateria["IDUsuario"].ToString();
                    publication.QueEs = "Apunte";
                    publication.Dock = DockStyle.Top;
                    publicationsPanel.Controls.Add(publication);
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

                FiltroUtilColor.CommandText = "SELECT RelacionUsuarioUtiles.IDUsuario, Utiles.ID, Utiles.TituloUtiles, Utiles.ColorUtiles, Utiles.DescripcionUtiles, Utiles.PrecioUtiles FROM (Utiles INNER JOIN RelacionUsuarioUtiles ON Utiles.ID = RelacionUsuarioUtiles.IDUtiles) WHERE  (Utiles.ColorUtiles = '" + cbxColor.Text + "')";
                OleDbDataReader LectorFiltroUtilColor = FiltroUtilColor.ExecuteReader();

                while (LectorFiltroUtilColor.Read())
                {
                    PublicationItem publication = new PublicationItem();
                    publication.Title = LectorFiltroUtilColor["TituloUtiles"].ToString();
                    publication.Description = LectorFiltroUtilColor["DescripcionUtiles"].ToString();
                    publication.Precio = LectorFiltroUtilColor["PrecioUtiles"].ToString() + "$";
                    publication.IdUsuario = LectorFiltroUtilColor["IDUsuario"].ToString();
                    publication.QueEs = "Util";
                    publication.Dock = DockStyle.Top;
                    publicationsPanel.Controls.Add(publication);
                }

                connection.Close();
            }
        }

 
    }
}
