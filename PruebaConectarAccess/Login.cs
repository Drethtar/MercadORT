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


        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        private void llCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CrearCuenta().ShowDialog();
            this.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                command.CommandText = "select * from Usuario where NombreUsuario='" + txtUsuario.Text + "' and PasswordUsuario='" + txtContra.Text +"'";

                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    this.Hide();
                    new IniciasteSesion().ShowDialog();
                    this.Show();
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

        private void llOlvideMiPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OlvideMiPassword().ShowDialog();
            this.Show();
        }
    }
}
