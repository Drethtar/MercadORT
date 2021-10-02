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
    public partial class Utiles : UserControl
    {
        public Utiles()
        {
            InitializeComponent();
        }
        
        [Category("Custom Props")]

        public string TitleUtil
        {
            get { return lblTitleUtil.Text; }
            set { lblTitleUtil.Text = value; }
        }

        public string DescriptionUtil
        {
            get { return lblDescriptionUtil.Text; }
            set { lblDescriptionUtil.Text = value; }
        }

        public string PrecioUtil
        {
            get { return lblPrecioUtil.Text; }
            set { lblPrecioUtil.Text = value; }
        }

        private string idUsuario;
        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private void Utiles_Load(object sender, EventArgs e)
        {

        }
    }
}
