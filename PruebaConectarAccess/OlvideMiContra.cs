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
using System.Net;
using System.Net.Mail;

namespace PruebaConectarAccess
{
    public partial class OlvideMiContra : Form
    {
        static string YourUsername = "pmercadort@gmail.com";
        static string YourPassword = "zqcfflunfrcekbcz";
        static string Destination = "";
        static string YourMessageSubject = "Recuperacion de Contraseña";
        static string YourMessageBody = "";

        private OleDbConnection connection = new OleDbConnection();

        public OlvideMiContra()
        {
            InitializeComponent();
        }

        private void OlvideMiContra_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            Destination = txtMailPerdiContra.Text;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            int count = 0;

            command.CommandText = "select * from Usuario where MailUsuario='" + txtMailPerdiContra.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            
            command.CommandText = "select PasswordUsuario from Usuario where MailUsuario='" + txtMailPerdiContra.Text + "'";

            reader.Read();
            string PasswordARecuperar = reader["PasswordUsuario"].ToString();

            string Mail = txtMailPerdiContra.Text;

            YourMessageBody = "La contraseña de la cuenta con la direccion de correo electronico " + Mail + " es " + PasswordARecuperar+".";
        
            while (reader.Read())
            {
                count += 1;
            }

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(YourUsername, YourPassword);

                MailMessage msgObj = new MailMessage();
                msgObj.To.Add(Destination);
                msgObj.From = new MailAddress(YourUsername);
                msgObj.Subject = YourMessageSubject;
                msgObj.Body = YourMessageBody;
                client.Send(msgObj);

                MessageBox.Show("Se envio tu mail");

            }
        }
    }
}
