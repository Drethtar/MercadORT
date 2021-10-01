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
    public partial class Apuntes : UserControl
    {
        public Apuntes()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]

        public string TitleApunte
        {
            get { return lblTitleApunte.Text; }
            set { lblTitleApunte.Text = value; }
        }

        public string DescriptionApunte
        {
            get { return lblDescriptionApunte.Text; }
            set { lblDescriptionApunte.Text = value; }
        }

        public string PrecioApunte
        {
            get { return lblPrecioApunte.Text; }
            set { lblPrecioApunte.Text = value; }
        }
        private void Apuntes_Load(object sender, EventArgs e)
        {

        }
    }
}
