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
    public partial class jorge : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public jorge()
        {
            InitializeComponent();
        }

        private void jorge_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            connection.Open();
            CheckConnection.Text = "funca";
            connection.Close();
            
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {

            //Guid NewGUID = Guid.NewGuid();
            try{
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Usuario (NombreUsuario,PasswordUsuario,MailUsuario,IDCurso) " +
                    "values ('"+txtNombre.Text+"','"+txtContra.Text+"','"+txtMail.Text+"',1)";
            
                command.ExecuteNonQuery();
                MessageBox.Show("Saved");

                this.Hide();
                new Form1().ShowDialog();
                this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa, algo salo mal... " + ex);
            }
        }
    }
}
