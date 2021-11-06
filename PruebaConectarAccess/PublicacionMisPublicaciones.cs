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
    public partial class PublicacionMisPublicaciones : UserControl
    {

        private OleDbConnection connection = new OleDbConnection();
        public PublicacionMisPublicaciones()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        [Category("Custom Props")]
        
        public string Title
        {
            get { return lblTitleApunte.Text; }
            set { lblTitleApunte.Text = value; }
        }

        public string Description
        {
            get { return lblDescriptionApunte.Text; }
            set { lblDescriptionApunte.Text = value; }
        }

        public string Precio
        {
            get { return lblPrecioApunte.Text; }
            set { lblPrecioApunte.Text = value; }
        }

        private string idUsuario;
        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string IDPublicacion
        {
            get { return lblIDdelaPublicacion.Text; }
            set { lblIDdelaPublicacion.Text = value; }
        }
        public string QueEs
        {
            get { return lblQueEs.Text; }
            set { lblQueEs.Text = value; }
        }

        public Image ImagenPublicacion
        {
            get { return pbFotoPublicacion.Image; }
            set { pbFotoPublicacion.Image = value; }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lblQueEs.Text == "Libro")
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                
                command.CommandText = "delete from RelacionUsuarioLibros where IDLibros="+ IDPublicacion +" and IDUsuario="+ Login.ObtenerDatosUsuario.IDdelUsuario+"";
                command.ExecuteNonQuery();

                command.CommandText = "delete from Libros where TituloLibro='"+ lblTitleApunte.Text+"' and DescripcionLibro='"+ lblDescriptionApunte.Text +"' and ID="+Convert.ToInt32(IDPublicacion)+"";
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Su Publicacion a sido borrada correctamente");

                this.Hide();
                new ComprarOVender().ShowDialog();
                this.Show();
                
            }
            else if (lblQueEs.Text == "Util")
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "delete from RelacionUsuarioUtiles where IDUtiles="+IDPublicacion+" and IDUsuario="+Login.ObtenerDatosUsuario.IDdelUsuario+"";
                command.ExecuteNonQuery();

                command.CommandText = "delete from Utiles where TituloUtiles='"+lblTitleApunte.Text+"' and DescripcionUtiles='"+lblDescriptionApunte.Text+"' and ID="+Convert.ToInt32(IDPublicacion)+"";
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Su Publicacion a sido borrada correctamente");

                this.Hide();
                new ComprarOVender().ShowDialog();
                this.Show();
            }
            else if (lblQueEs.Text == "Apunte")
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "delete from Apuntes where TituloApuntes='"+lblTitleApunte.Text+"' and DescripcionApuntes='"+lblDescriptionApunte.Text+"' and IDUsuario="+Login.ObtenerDatosUsuario.IDdelUsuario+"";
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Su Publicacion a sido borrada correctamente");

                this.Hide();
                new ComprarOVender().ShowDialog();
                this.Show();
            }

            
        }

        private void lblDescriptionApunte_Click(object sender, EventArgs e)
        {

        }
    }
}
