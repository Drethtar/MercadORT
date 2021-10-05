using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using ClassLibrary1.Access;
using System.Data.OleDb;

namespace PruebaConectarAccess
{
    public partial class Login : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
        }
         
        public static class ObtenerDatosUsuario
        {
            public static string NombreDelUsuario = "";

            public static int IDdelUsuario = 0;

            public static string MailDelUsuario = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            
        }

        private void llCrearCuenta_Click(object sender, EventArgs e)
        {
            new CrearCuenta().ShowDialog();
            this.Show();
            new Login();
            this.Close();
        }

        private void IniciarSesion()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "' and PasswordUsuario='" + txtContra.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count += 1;
                }

                connection.Close();

                if (count == 1)
                {
                    connection.Open();
                    OleDbCommand command2 = new OleDbCommand();
                    command2.Connection = connection;

                    command2.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "' and PasswordUsuario='" + txtContra.Text + "'";

                    OleDbDataReader reader2 = command2.ExecuteReader();
                    reader2.Read();

                    string NombreObtenidoDelUsuario = reader2["NombreUsuario"].ToString();
                    string IDObtenidoDelUsuario = reader2["ID"].ToString();
                    string MailUsuario = reader2["MailUsuario"].ToString();

                    Login.ObtenerDatosUsuario.NombreDelUsuario = NombreObtenidoDelUsuario;
                    Login.ObtenerDatosUsuario.IDdelUsuario = Convert.ToInt32(IDObtenidoDelUsuario);
                    Login.ObtenerDatosUsuario.MailDelUsuario = MailUsuario;

                    new ComprarOVender().ShowDialog();
                    this.Show();
                    new Login();
                    this.Close();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Contactar a oficina tecnica y decir que hay mas de una cuenta con mismo Usuario Contra y mail");
                }
                else
                {
                    MessageBox.Show("Los datos introducidos son incorrectos");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa algo salio mal... " + ex);
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion();
            
        }
        private void llOlvideMiPassword_Click(object sender, EventArgs e)
        {
            new CambiarMiPassword().ShowDialog(); 
            this.Show();
            new Login(); 
            this.Close();

        }

        private void llOlvideMiPassword_Click_1(object sender, EventArgs e)
        {
            new OlvideMiContra().ShowDialog(); 
            this.Show();
            new Login();
            this.Close();
        }



        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";

                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";

                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";

                txtContra.ForeColor = Color.Black;

                txtContra.PasswordChar = '*';
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            
        if (txtContra.Text == "")
           {
               txtContra.Text = "Contraseña";

               txtContra.ForeColor = Color.DarkGray;

               txtContra.PasswordChar = (char)0;
           }

        }

        private void llCrearCuenta_MouseMove(object sender, MouseEventArgs e)
        {
            llCrearCuenta.ForeColor = Color.Blue;

        }

        private void llCrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            llCrearCuenta.ForeColor = Color.Black;
        }

        private void llOlvideMiPassword_MouseLeave(object sender, EventArgs e)
        {
            llOlvideMiPassword.ForeColor = Color.Black;
        }

        private void llOlvideMiPassword_MouseMove(object sender, MouseEventArgs e)
        {
            llOlvideMiPassword.ForeColor = Color.Blue;
        }

        private void LLCambiarPassword_MouseLeave(object sender, EventArgs e)
        {
            LLCambiarPassword.ForeColor = Color.Black;
        }

        private void LLCambiarPassword_MouseMove(object sender, MouseEventArgs e)
        {
            LLCambiarPassword.ForeColor = Color.Blue;
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }
    }
}
