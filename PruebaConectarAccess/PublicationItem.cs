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
    public partial class PublicationItem : UserControl
    {
        static string YourUsername = "pmercadort@gmail.com";
        static string YourPassword = "zqcfflunfrcekbcz";
        static string Destination = "";
        static string YourMessageSubject = "Felicidades! Alguien quiere comprarte algo!";
        static string YourMessageBody = "";
        private OleDbConnection connection = new OleDbConnection();
        public PublicationItem()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        [Category("Custom Props")]

        public string Title {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value;  }
        }

        public string Description
        {
            get { return lblDescription.Text; }
            set { lblDescription.Text = value; }
        }

        public string Precio
        {
            get { return lblPrecio.Text; }
            set { lblPrecio.Text = value; }
        }

        private string idUsuario;
        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string QueEs
        {
            get { return lblQueEs.Text; }
            set { lblQueEs.Text = value; }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuieroComprarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                YourMessageBody = "Hola! Hoy es tu dia! " + Login.ObtenerDatosUsuario.NombreDelUsuario + " quiere comprar tu '" + lblTitle.Text + "!' El correo electronico del comprador es " + Login.ObtenerDatosUsuario.MailDelUsuario + ". Contactate con esa persona para poder concretar la compra del producto. Recuerda BORRAR tu publicacion tras finalizar la venta del producto. Muchas Gracias y buen dia :D.";

                if (lblQueEs.Text == "Libro")
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    command.CommandText = "select ID from Libros where TituloLibro= '" + lblTitle.Text + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string IDLibroVendedor = reader["ID"].ToString();



                    connection.Close();
                    connection.Open();

                    command.CommandText = "select IDUsuario from RelacionUsuarioLibros where IDLibros= " + IDLibroVendedor + "";
                    OleDbDataReader reader2 = command.ExecuteReader();
                    reader2.Read();
                    string IDVendedorLibro = reader2["IDUsuario"].ToString();



                    connection.Close();
                    connection.Open();

                    command.CommandText = "select MailUsuario from Usuario where ID= " + IDVendedorLibro + "";
                    OleDbDataReader reader3 = command.ExecuteReader();
                    reader3.Read();
                    Destination = reader3["MailUsuario"].ToString();



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

                        MessageBox.Show("Se envio un correo electronico al comprador, seguramente te contacte dentro de poco.");

                    }
                    connection.Close();
                }
                else if (lblQueEs.Text == "Util")
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    command.CommandText = "select ID from Utiles where TituloUtiles= '" + lblTitle.Text + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string IDUtilVendedor = reader["ID"].ToString();

                    connection.Close();
                    connection.Open();

                    command.CommandText = "select IDUsuario from RelacionUsuarioUtiles where IDUtiles= " + IDUtilVendedor + "";
                    reader = command.ExecuteReader();
                    reader.Read();
                    string IDVendedorUtil = reader["IDUsuario"].ToString();

                    connection.Close();
                    connection.Open();

                    command.CommandText = "select MailUsuario from Usuario where ID=" + IDVendedorUtil + "";
                    reader = command.ExecuteReader();
                    reader.Read();
                    Destination = reader["MailUsuario"].ToString();

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

                        MessageBox.Show("Se envio un correo electronico al comprador, seguramente te contacte dentro de poco.");

                    }
                    connection.Close();
                }
                else if (lblQueEs.Text == "Apunte")
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;

                    command.CommandText = "select IDUsuario from Apuntes where TituloApuntes= '" + lblTitle.Text + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string IDVendedorApunte = reader["IDUsuario"].ToString();

                    connection.Close();
                    connection.Open();

                    command.CommandText = "select MailUsuario from Usuario where ID= " + IDVendedorApunte + "";
                    reader = command.ExecuteReader();
                    reader.Read();
                    Destination = reader["MailUsuario"].ToString();

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

                        MessageBox.Show("Se envio un correo electronico al comprador, seguramente te contacte dentro de poco.");

                    }
                    connection.Close();
                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Probablemente sea porque tu direccion de correo electronico no es valida. Error: " + ex);
            }


        }
    }
}
