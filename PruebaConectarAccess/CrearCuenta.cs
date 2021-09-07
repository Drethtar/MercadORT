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
    public partial class CrearCuenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            connection.Open();
            CheckConnection.Text = "funca";
            connection.Close();
            
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = 0;

                //chequear que no exista el user en la db
                command.CommandText = "select * from Usuario where NombreUsuario='" + txtNombre.Text + "' or MailUsuario='" + txtMail.Text+ "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Ya existe una cuenta con los datos introducidos");
                    connection.Close();
                    return;

                }
                else if (count > 1)
                {
                    MessageBox.Show("Contactar a oficina tecnica y decir que hay mas de una cuenta con mismo Usuario Contra y mail");
                    connection.Close();
                    return;
                }

                reader.Close();
                connection.Close();
                connection.Open();

                
                command.CommandText = "select ID from Curso where Orientacion='" + cbxOrientacion.Text + "' and Anio='" + cbxCurso.Text +
                "' and Letra='" + cbxLetra.Text + "'";

                OleDbDataReader reader2 = command.ExecuteReader();
                reader2.Read();
                string IDdelCurso = reader2["ID"].ToString();

                reader2.Close();

                command.CommandText = "insert into Usuario (NombreUsuario,PasswordUsuario,MailUsuario,IDCurso) " +
                    "values ('"+txtNombre.Text+"','"+txtContra.Text+"','"+txtMail.Text+"', '" + IDdelCurso + "')";


                command.ExecuteNonQuery();


                MessageBox.Show("Saved");

                this.Hide();
                new IniciasteSesion().ShowDialog();
                this.Show();
                                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa, algo salo mal... " + ex);
            }
        }


    }
}
