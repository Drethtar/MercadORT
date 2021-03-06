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
using System.IO;

namespace PruebaConectarAccess
{
    public partial class MisPublicaciones : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public MisPublicaciones()
        {
            InitializeComponent();
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            new ComprarOVender().ShowDialog(); 
            this.Show();
            new MisPublicaciones(); 
            this.Close();
        }

        private void MisPublicaciones_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            this.WindowState = FormWindowState.Maximized;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;


            command.CommandText = "SELECT Libros.ID, Libros.TituloLibro, Libros.MateriaLibro, Libros.PrecioLibro, RelacionUsuarioLibros.IDUsuario, Libros.DescripcionLibro, Libros.Foto FROM     (Libros INNER JOIN RelacionUsuarioLibros ON Libros.ID = RelacionUsuarioLibros.IDLibros) WHERE  (RelacionUsuarioLibros.IDUsuario = " + Login.ObtenerDatosUsuario.IDdelUsuario+ ")";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicacionMisPublicaciones publicationMisPublicacionesLibros = new PublicacionMisPublicaciones();
                publicationMisPublicacionesLibros.Title = reader["TituloLibro"].ToString();
                publicationMisPublicacionesLibros.Description = reader["DescripcionLibro"].ToString();
                publicationMisPublicacionesLibros.Precio = reader["PrecioLibro"].ToString() + "$";
                publicationMisPublicacionesLibros.IdUsuario = reader["IDUsuario"].ToString();
                publicationMisPublicacionesLibros.QueEs = "Libro";
                publicationMisPublicacionesLibros.IDPublicacion = reader["ID"].ToString();
                publicationMisPublicacionesLibros.ImagenPublicacion = Base64ToImage(reader["Foto"].ToString());
                publicationMisPublicacionesLibros.Dock = DockStyle.Top;
                MyPublicationsPanel.Controls.Add(publicationMisPublicacionesLibros);
            } 
            
            connection.Close();
            connection.Open();

            command.CommandText = "SELECT Utiles.ID, Utiles.TituloUtiles, Utiles.ColorUtiles, Utiles.DescripcionUtiles, Utiles.PrecioUtiles, RelacionUsuarioUtiles.IDUsuario, Utiles.Foto FROM     (Utiles INNER JOIN RelacionUsuarioUtiles ON Utiles.ID = RelacionUsuarioUtiles.IDUtiles) WHERE  (RelacionUsuarioUtiles.IDUsuario = "+ Login.ObtenerDatosUsuario.IDdelUsuario +")";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicacionMisPublicaciones publicationMisPublicacionesUtiles = new PublicacionMisPublicaciones();
                publicationMisPublicacionesUtiles.Title = reader["TituloUtiles"].ToString();
                publicationMisPublicacionesUtiles.Description = reader["DescripcionUtiles"].ToString();
                publicationMisPublicacionesUtiles.Precio = reader["PrecioUtiles"].ToString() + "$";
                publicationMisPublicacionesUtiles.IdUsuario = reader["IDUsuario"].ToString();
                publicationMisPublicacionesUtiles.QueEs = "Util";
                publicationMisPublicacionesUtiles.IDPublicacion = reader["ID"].ToString();
                publicationMisPublicacionesUtiles.ImagenPublicacion = Base64ToImage(reader["Foto"].ToString());
                publicationMisPublicacionesUtiles.Dock = DockStyle.Top;
                MyPublicationsPanel.Controls.Add(publicationMisPublicacionesUtiles);
            }

            connection.Close();
            connection.Open();

            command.CommandText = "SELECT * from Apuntes Where IDUsuario = "+ Login.ObtenerDatosUsuario.IDdelUsuario +"";
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicacionMisPublicaciones publicationMisPublicacionesApuntes = new PublicacionMisPublicaciones();
                publicationMisPublicacionesApuntes.Title = reader["TituloApuntes"].ToString();
                publicationMisPublicacionesApuntes.Description = reader["DescripcionApuntes"].ToString();
                publicationMisPublicacionesApuntes.Precio = reader["PrecioApuntes"].ToString() + "$";
                publicationMisPublicacionesApuntes.IdUsuario = reader["IDUsuario"].ToString();
                publicationMisPublicacionesApuntes.QueEs = "Apunte";
                publicationMisPublicacionesApuntes.ImagenPublicacion = Base64ToImage(reader["Foto"].ToString());
                publicationMisPublicacionesApuntes.IDPublicacion = reader["ID"].ToString();
                publicationMisPublicacionesApuntes.Dock = DockStyle.Top;
                MyPublicationsPanel.Controls.Add(publicationMisPublicacionesApuntes);
            }

            connection.Close();
        }


    }
}
