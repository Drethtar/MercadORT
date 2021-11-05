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

        private void CambiarContra()
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
                    return;
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

                string query = "update Usuario set PasswordUsuario='" + txtNuevaPassword.Text + "' where NombreUsuario='" + txtNombrePerdiPassword.Text + "' and MailUsuario='" + txtMailPerdiPassword.Text + "' and PasswordUsuario='" + txtContraOlvidada1.Text + "'";
                command.CommandText = query;
                command.ExecuteNonQuery();




                MessageBox.Show("Su contraseña fue cambiada con exito!");
                connection.Close();

                new Login().ShowDialog();
                this.Show();
                new CambiarMiPassword();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa algo salio mal... " + ex);
            }
        }

        
        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            CambiarContra();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog(); 
            this.Show();
            new CambiarMiPassword(); 
            this.Close();
        }

        private void txtNombrePerdiPassword_Leave(object sender, EventArgs e)
        {
            if (txtNombrePerdiPassword.Text == "")
            {
                txtNombrePerdiPassword.Text = "Usuario";

                txtNombrePerdiPassword.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombrePerdiPassword_Enter(object sender, EventArgs e)
        {
            if (txtNombrePerdiPassword.Text == "Usuario")
            {
                txtNombrePerdiPassword.Text = "";

                txtNombrePerdiPassword.ForeColor = Color.Black;
            }
        }

        private void txtMailPerdiPassword_Leave(object sender, EventArgs e)
        {
            if (txtMailPerdiPassword.Text == "")
            {
                txtMailPerdiPassword.Text = "ejemplo@gmail.com";

                txtMailPerdiPassword.ForeColor = Color.DarkGray;
            }
        }

        private void txtMailPerdiPassword_Enter(object sender, EventArgs e)
        {
            if (txtMailPerdiPassword.Text == "ejemplo@gmail.com")
            {
                txtMailPerdiPassword.Text = "";

                txtMailPerdiPassword.ForeColor = Color.Black;
            }
        }

        private void txtNuevaPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CambiarContra();
            }
        }

        private void txtContraOlvidada1_Enter(object sender, EventArgs e)
        {
            if (txtContraOlvidada1.Text == "Contraseña actual")
            {
                txtContraOlvidada1.Text = "";

                txtContraOlvidada1.ForeColor = Color.Black;

                txtContraOlvidada1.PasswordChar = '*';
            }
        }

        private void txtContraOlvidada1_Leave(object sender, EventArgs e)
        {
            if (txtContraOlvidada1.Text == "")
            {
                txtContraOlvidada1.Text = "Contraseña actual";

                txtContraOlvidada1.ForeColor = Color.DarkGray;

                txtContraOlvidada1.PasswordChar = (char)0;
            }
        }

        private void txtContraOlvidada2_Leave(object sender, EventArgs e)
        {
            if (txtContraOlvidada2.Text == "")
            {
                txtContraOlvidada2.Text = "Repetir contraseña";

                txtContraOlvidada2.ForeColor = Color.DarkGray;

                txtContraOlvidada2.PasswordChar = (char)0;
            }
        }

        private void txtContraOlvidada2_Enter(object sender, EventArgs e)
        {
            if (txtContraOlvidada2.Text == "Repetir contraseña")
            {
                txtContraOlvidada2.Text = "";

                txtContraOlvidada2.ForeColor = Color.Black;

                txtContraOlvidada2.PasswordChar = '*';
            }
        }

        private void txtNuevaPassword_Leave(object sender, EventArgs e)
        {
            if (txtNuevaPassword.Text == "")
            {
                txtNuevaPassword.Text = "Contraseña nueva";

                txtNuevaPassword.ForeColor = Color.DarkGray;

                txtNuevaPassword.PasswordChar = (char)0;
            }
        }

        private void txtNuevaPassword_Enter(object sender, EventArgs e)
        {
            if (txtNuevaPassword.Text == "Contraseña nueva")
            {
                txtNuevaPassword.Text = "";

                txtNuevaPassword.ForeColor = Color.Black;

                txtNuevaPassword.PasswordChar = '*';
            }
        }

    }
}
