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
    public partial class MisPublicaciones : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public MisPublicaciones()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ComprarOVender().ShowDialog();
            this.Show();
        }

        private void MisPublicaciones_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;


            command.CommandText = "SELECT Libros.*, RelacionUsuarioLibros.IDUsuario FROM(Libros INNER JOIN RelacionUsuarioLibros ON Libros.ID = RelacionUsuarioLibros.IDLibros)";
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PublicacionMisPublicaciones publicationMisPublicaciones = new PublicacionMisPublicaciones();
                publicationMisPublicaciones.Title = reader["TituloLibro"].ToString();
                publicationMisPublicaciones.Description = reader["DescripcionLibro"].ToString();
                publicationMisPublicaciones.Precio = reader["PrecioLibro"].ToString() + "$";
                publicationMisPublicaciones.IdUsuario = reader["IDUsuario"].ToString();
                publicationMisPublicaciones.Dock = DockStyle.Top;
                MyPublicationsPanel.Controls.Add(publicationMisPublicaciones);
            }

            connection.Close();

            //carga mal las cosas, fijate bauty del futuro
        }
    }
}
