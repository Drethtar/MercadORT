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
    public partial class PublicacionDeVenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public PublicacionDeVenta()
        {
            InitializeComponent();
        }
        private void PublicacionDeVenta_Load(object sender, EventArgs e)
        {
            llColorUtil.Hide(); cbxColorUtil.Hide(); //util
            llDescApunte.Hide(); txtDescApunte.Hide(); //apunte
            llDescLibro.Hide(); txtDescLibro.Hide(); //libro
            llDescUtil.Hide(); txtDescUtil.Hide(); //util

            llMateriaApunte.Hide(); cbxMateriaApunte.Hide(); //apunte
            llMateriaLibro.Hide(); cbxMateriaLibro.Hide(); //libro
            llPrecioApunte.Hide(); numPrecioApunte.Hide(); //apunte
            llPrecioLibro.Hide(); numPrecioLibro.Hide(); //libro
            llPrecioUtil.Hide(); numPrecioUtil.Hide(); //util
 
            llTituloApunte.Hide(); txtTituloApunte.Hide(); //apunte
            llTituloLibro.Hide(); txtTituloLibro.Hide(); //libro
            llTituloUtil.Hide(); txtTituloUtil.Hide(); //util

            btnPublicar.Hide();

            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        private void cbxQueEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQueEs.Text == "Libro")
            {
                llColorUtil.Hide(); cbxColorUtil.Hide();
                llDescApunte.Hide(); txtDescApunte.Hide();
                llDescUtil.Hide(); txtDescUtil.Hide();
                llMateriaApunte.Hide(); cbxMateriaApunte.Hide();
                llPrecioApunte.Hide(); numPrecioApunte.Hide();
                llPrecioUtil.Hide(); numPrecioUtil.Hide();

                llTituloApunte.Hide(); txtTituloApunte.Hide();
                llTituloUtil.Hide(); txtTituloUtil.Hide();

                llDescLibro.Show(); txtDescLibro.Show();
 
                llMateriaLibro.Show(); cbxMateriaLibro.Show();
                llPrecioLibro.Show(); numPrecioLibro.Show();
                llTituloLibro.Show(); txtTituloLibro.Show();

                btnPublicar.Show();

                txtTituloLibro.TabIndex = 2;
                cbxMateriaLibro.TabIndex = 3;
                numPrecioLibro.TabIndex = 4;
                txtDescLibro.TabIndex = 5;
            }
            else if (cbxQueEs.Text == "Apunte")
            {
                llColorUtil.Hide(); cbxColorUtil.Hide();
                llDescLibro.Hide(); txtDescLibro.Hide();
                llDescUtil.Hide(); txtDescUtil.Hide();

                llMateriaLibro.Hide(); cbxMateriaLibro.Hide();
                llPrecioLibro.Hide(); numPrecioLibro.Hide();
                llPrecioUtil.Hide(); numPrecioUtil.Hide();
                llTituloLibro.Hide(); txtTituloLibro.Hide();
                llTituloUtil.Hide(); txtTituloUtil.Hide();

                llDescApunte.Show(); txtDescApunte.Show();
                llMateriaApunte.Show(); cbxMateriaApunte.Show();
                llPrecioApunte.Show(); numPrecioApunte.Show();

                llTituloApunte.Show(); txtTituloApunte.Show();

                btnPublicar.Show();

                txtTituloApunte.TabIndex = 2;
                cbxMateriaApunte.TabIndex = 3;
                numPrecioApunte.TabIndex = 4;
                txtDescApunte.TabIndex = 5;
            }
            else if (cbxQueEs.Text == "Util")
            {
                llDescApunte.Hide(); txtDescApunte.Hide();
                llDescLibro.Hide(); txtDescLibro.Hide();

                llMateriaApunte.Hide(); cbxMateriaApunte.Hide(); 
                llMateriaLibro.Hide(); cbxMateriaLibro.Hide(); 
                llPrecioApunte.Hide(); numPrecioApunte.Hide();
                llPrecioLibro.Hide(); numPrecioLibro.Hide();

                llTituloApunte.Hide(); txtTituloApunte.Hide();
                llTituloLibro.Hide(); txtTituloLibro.Hide();

                llColorUtil.Show(); cbxColorUtil.Show();
                llDescUtil.Show(); txtDescUtil.Show();
                llPrecioUtil.Show(); numPrecioUtil.Show();
                llTituloUtil.Show(); txtTituloUtil.Show();

                btnPublicar.Show();

                txtTituloUtil.TabIndex = 2;
                cbxColorUtil.TabIndex = 3;
                numPrecioUtil.TabIndex = 4;
                txtDescUtil.TabIndex = 5;
            }
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if (cbxQueEs.Text == "Libro")
            {

                

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "insert into Libros (TituloLibro,MateriaLibro,DescripcionLibro,PrecioLibro) " +
                "values ('" + txtTituloLibro.Text + "','" + cbxMateriaLibro.Text + "','"
                + txtDescLibro.Text + "','" + numPrecioLibro.Text + "')";

                command.ExecuteNonQuery();

                connection.Close();
                connection.Open();

                command.CommandText = "select * from Libros where TituloLibro='" + txtTituloLibro.Text + "' and MateriaLibro='" + cbxMateriaLibro.Text + "' and DescripcionLibro='" + txtDescLibro.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                string IDDelLibro = reader["ID"].ToString();

                connection.Close();
                connection.Open();

                command.CommandText = "insert into RelacionUsuarioLibros (IDUsuario,IDLibros) " + "values ('" + Login.ObtenerDatosUsuario.IDdelUsuario + "','" + IDDelLibro + "')";
                
                command.ExecuteNonQuery();
                
                MessageBox.Show("Publicacion realizada con exito!");
                connection.Close();

                new ComprarOVender().ShowDialog();
                this.Show();
                new PublicacionDeVenta();
                this.Close();
            }
            else if (cbxQueEs.Text == "Util")
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "insert into Utiles (TituloUtiles,ColorUtiles,DescripcionUtiles,PrecioUtiles) " + "values ('" + txtTituloUtil.Text + "','" + cbxColorUtil.Text + "','" + txtDescUtil.Text + "','" + numPrecioUtil.Text + "')";

                command.ExecuteNonQuery();

                connection.Close();
                connection.Open();

                command.CommandText = "select * from Utiles where TituloUtiles='" + txtTituloUtil.Text + "' and ColorUtiles='" + cbxColorUtil.Text + "' and DescripcionUtiles='" + txtDescUtil.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                string IDDelUtil = reader["ID"].ToString();

                connection.Close();
                connection.Open();

                command.CommandText = "insert into RelacionUsuarioUtiles (IDUsuario, IDUtiles) " + "values ('" + Login.ObtenerDatosUsuario.IDdelUsuario + "','" + IDDelUtil + "')";

                command.ExecuteNonQuery();

                //
                MessageBox.Show("Publicacion realizada con exito!");
                connection.Close();

                new ComprarOVender().ShowDialog();
                this.Show();
                new PublicacionDeVenta();
                this.Close();
            }
            else if (cbxQueEs.Text == "Apunte")
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "insert into Apuntes (TituloApuntes,DescripcionApuntes,MateriaApuntes,PrecioApuntes,IDUsuario) " +
                "values ('" + txtTituloApunte.Text + "','" + txtDescApunte.Text + "','" + cbxMateriaApunte.Text + "','"
                + numPrecioApunte.Text + "','" + Login.ObtenerDatosUsuario.IDdelUsuario + "')";

                command.ExecuteNonQuery();

                MessageBox.Show("Publicacion realizada con exito!");
                connection.Close();

                new ComprarOVender().ShowDialog();
                this.Show();
                new PublicacionDeVenta();
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new ComprarOVender().ShowDialog(); 
            this.Show();
            new PublicacionDeVenta(); 
            this.Close();

        }

        private void txtDescApunte_Leave(object sender, EventArgs e)
        {
            if (txtDescApunte.Text == "")
            {
                txtDescApunte.Text = "Ej: Si es drive o fisico, sobre que tema se trata, etc.";

                txtDescApunte.ForeColor = Color.DarkGray;
            }
        }

        private void txtDescApunte_Enter(object sender, EventArgs e)
        {
            if (txtDescApunte.Text == "Ej: Si es drive o fisico, sobre que tema se trata, etc.")
            {
                txtDescApunte.Text = "";

                txtDescApunte.ForeColor = Color.Black; 
            }
        }

        private void txtDescUtil_Leave(object sender, EventArgs e)
        {
            if (txtDescUtil.Text == "")
            {
                txtDescUtil.Text = "Ej: Que tan usado está, distintas descripciones segun el útil que se este vendiendo, etc.";

                txtDescUtil.ForeColor = Color.DarkGray;
            }
        }

        private void txtDescUtil_Enter(object sender, EventArgs e)
        {
            if (txtDescUtil.Text == "Ej: Que tan usado está, distintas descripciones segun el útil que se este vendiendo, etc.")
            {
                txtDescUtil.Text = "";

                txtDescUtil.ForeColor = Color.Black;
            }
        }

        private void txtDescLibro_Leave(object sender, EventArgs e)
        {
            if (txtDescLibro.Text == "")
            {
                txtDescLibro.Text = "Ej: Que tan usado está, editorial, etc.";

                txtDescLibro.ForeColor = Color.DarkGray;
            }
        }
      

        private void txtDescLibro_Enter(object sender, EventArgs e)
        {
            if (txtDescLibro.Text == "Ej: Que tan usado está, editorial, etc.")
            {
                txtDescLibro.Text = "";

                txtDescLibro.ForeColor = Color.Black;
            }
        }
    }
}
