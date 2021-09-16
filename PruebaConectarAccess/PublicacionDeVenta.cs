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
    public partial class PublicacionDeVenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public PublicacionDeVenta()
        {
            InitializeComponent();
        }
        private void PublicacionDeVenta_Load(object sender, EventArgs e)
        {
            llColorUtil.Hide(); cbxColorUtil.Hide(); //util
            llDescApunte.Hide(); txtDescApunte.Hide(); //apunte
            llDescLibro.Hide(); txtDescLibro.Hide(); //libro
            llDescUtil.Hide(); txtDescUtil.Hide(); //util
            llEditorial.Hide(); txtEditorial.Hide(); //libro
            llMateriaApunte.Hide(); cbxMateriaApunte.Hide(); //apunte
            llMateriaLibro.Hide(); cbxMateriaLibro.Hide(); //libro
            llMateriaUtil.Hide(); cbxMateriaUtil.Hide(); //util
            llPrecioApunte.Hide(); numPrecioApunte.Hide(); //apunte
            llPrecioLibro.Hide(); numPrecioLibro.Hide(); //libro
            llPrecioUtil.Hide(); numPrecioUtil.Hide(); //util
            llTemasApunte.Hide(); txtTemasApunte.Hide(); //apunte
            llTituloApunte.Hide(); txtTituloApunte.Hide(); //apunte
            llTituloLibro.Hide(); txtTituloLibro.Hide(); //libro
            llTituloUtil.Hide(); txtTituloUtil.Hide(); //util

            btnPublicar.Hide();

            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
        }

        private void cbxQueEs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQueEs.Text == "Libro")
            {
                llColorUtil.Hide(); cbxColorUtil.Hide();
                llDescApunte.Hide(); txtDescApunte.Hide();
                llDescUtil.Hide(); txtDescUtil.Hide();
                llMateriaApunte.Hide(); cbxMateriaApunte.Hide();
                llMateriaUtil.Hide(); cbxMateriaUtil.Hide();
                llPrecioApunte.Hide(); numPrecioApunte.Hide();
                llPrecioUtil.Hide(); numPrecioUtil.Hide();
                llTemasApunte.Hide(); txtTemasApunte.Hide();
                llTituloApunte.Hide(); txtTituloApunte.Hide();
                llTituloUtil.Hide(); txtTituloUtil.Hide();

                llDescLibro.Show(); txtDescLibro.Show();
                llEditorial.Show(); txtEditorial.Show();
                llMateriaLibro.Show(); cbxMateriaLibro.Show();
                llPrecioLibro.Show(); numPrecioLibro.Show();
                llTituloLibro.Show(); txtTituloLibro.Show();

                btnPublicar.Hide();
            }
            else if (cbxQueEs.Text == "Apunte")
            {
                llColorUtil.Hide(); cbxColorUtil.Hide();
                llDescLibro.Hide(); txtDescLibro.Hide();
                llDescUtil.Hide(); txtDescUtil.Hide();
                llEditorial.Hide(); txtEditorial.Hide();
                llMateriaLibro.Hide(); cbxMateriaLibro.Hide();
                llMateriaUtil.Hide(); cbxMateriaUtil.Hide();
                llPrecioLibro.Hide(); numPrecioLibro.Hide();
                llPrecioUtil.Hide(); numPrecioUtil.Hide();
                llTituloLibro.Hide(); txtTituloLibro.Hide();
                llTituloUtil.Hide(); txtTituloUtil.Hide();

                llDescApunte.Show(); txtDescApunte.Show();
                llMateriaApunte.Show(); cbxMateriaApunte.Show();
                llPrecioApunte.Show(); numPrecioApunte.Show();
                llTemasApunte.Show(); txtTemasApunte.Show();
                llTituloApunte.Show(); txtTituloApunte.Show();

                btnPublicar.Hide();
            }
            else if (cbxQueEs.Text == "Util")
            {
                llDescApunte.Hide(); txtDescApunte.Hide();
                llDescLibro.Hide(); txtDescLibro.Hide();
                llEditorial.Hide(); txtEditorial.Hide(); 
                llMateriaApunte.Hide(); cbxMateriaApunte.Hide(); 
                llMateriaLibro.Hide(); cbxMateriaLibro.Hide(); 
                llPrecioApunte.Hide(); numPrecioApunte.Hide();
                llPrecioLibro.Hide(); numPrecioLibro.Hide();
                llTemasApunte.Hide(); txtTemasApunte.Hide(); 
                llTituloApunte.Hide(); txtTituloApunte.Hide();
                llTituloLibro.Hide(); txtTituloLibro.Hide();

                llColorUtil.Show(); cbxColorUtil.Show();
                llDescUtil.Show(); txtDescUtil.Show();
                llMateriaUtil.Show(); cbxMateriaUtil.Show();
                llPrecioUtil.Show(); numPrecioUtil.Show();
                llTituloUtil.Show(); txtTituloUtil.Show();

                btnPublicar.Hide();
            }
        }
    }
}
