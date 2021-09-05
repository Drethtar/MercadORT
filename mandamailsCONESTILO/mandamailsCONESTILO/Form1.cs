using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace mandamailsCONESTILO
{
    public partial class Form1 : Form
    {
        static string YourUsername = "proyectoortml@gmail.com"; 
        static string YourPassword = "gpxeexmklfvvmrzm";
        static string Destination; //sacar de la base de datos el mail del vendedor
        static string YourMessageSubject = "Te quieren  comprar .......";
        static string YourMessageBody = "XX te quiere comprar ..... ,  por favor contacte con este mail ......";

        public Form1()
        {
            InitializeComponent();

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            Destination = txtmail.Text;


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
