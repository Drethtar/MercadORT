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
    public partial class CambiarMiPassword : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public CambiarMiPassword()
        {
            InitializeComponent();
        }

        private void OlvideMiPassword_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string password1 = txtContraOlvidada1.Text;
                string password2 = txtContraOlvidada2.Text;

                if (password1 == password2)
                {

                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }
            

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "select * from Usuario where NombreUsuario='" + txtNombrePerdiPassword.Text + "' and PasswordUsuario='" + txtContraOlvidada1.Text +
                "' and MailUsuario='" + txtMailPerdiPassword.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {

                }
                else if (count < 1)
                {
                    MessageBox.Show("Algunos de los datos introducidos no son correctos");
                    connection.Close();
                    return;
                }
                else 
                { 
                    MessageBox.Show("Contacta a oficina tecnica");
                }

                connection.Close();
                connection.Open();

                string query = "update Usuario set PasswordUsuario='" + txtNuevaPassword.Text + "' where NombreUsuario='" + txtNombrePerdiPassword.Text + "' and MailUsuario='" + txtMailPerdiPassword.Text + "' and PasswordUsuario='"+txtContraOlvidada1.Text+"'";
                command.CommandText = query;
                command.ExecuteNonQuery();
                


                
                MessageBox.Show("Data edited bien");
                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Upa algo salio mal... " + ex);
            }
        }
    }
}
