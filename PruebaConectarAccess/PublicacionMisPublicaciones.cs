using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebaConectarAccess
{
    public partial class PublicacionMisPublicaciones : UserControl
    {
        
        public PublicacionMisPublicaciones()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
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

        private void PublicacionMisPublicaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
