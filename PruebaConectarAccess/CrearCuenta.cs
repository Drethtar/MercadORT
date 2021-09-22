﻿using System;
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
    public partial class CrearCuenta : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MercadOrt.accdb";
            
            cbxOrientacion.Hide();
            llOrientacion.Hide();
            cbxLetra.Hide();
            llLetra.Hide();
            
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = 0;
                
                //chequear que no exista el user en la db
                command.CommandText = "select * from Usuario where NombreUsuario='" + txtNombre.Text + "' or MailUsuario='" + txtMail.Text+ "'";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count += 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Ya existe una cuenta con los datos introducidos");
                    connection.Close();
                    return;

                }
                else if (count > 1)
                {
                    MessageBox.Show("Contactar a oficina tecnica y decir que hay mas de una cuenta con mismo Usuario Contra y mail");
                    connection.Close();
                    return;
                }

                reader.Close();
                connection.Close();
                connection.Open();

                
                command.CommandText = "select ID from Curso where Orientacion='" + cbxOrientacion.Text + "' and Anio='" + cbxCurso.Text +
                "' and Letra='" + cbxLetra.Text + "'";

                OleDbDataReader reader2 = command.ExecuteReader();
                reader2.Read();
                string IDdelCurso = reader2["ID"].ToString();

                reader2.Close();

                command.CommandText = "insert into Usuario (NombreUsuario,PasswordUsuario,MailUsuario,IDCurso) " +
                    "values ('"+txtNombre.Text+"','"+txtContra.Text+"','"+txtMail.Text+"', '" + IDdelCurso + "')";


                command.ExecuteNonQuery();


                MessageBox.Show("Tu cuenta se creo exitosamente!");

                connection.Close();
                
                this.Hide();
                new Login().ShowDialog();
                this.Show();            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upa, algo salo mal... " + ex);
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxOrientacion.Items.Clear();
            
            if (cbxCurso.Text == "7mo" || cbxCurso.Text == "1ro" || cbxCurso.Text == "2do")
            {
                cbxOrientacion.Items.Add("Ninguna");
            }
            else if (cbxCurso.Text == "3ro" || cbxCurso.Text == "4to" || cbxCurso.Text == "5to")
            {
                cbxOrientacion.Items.Add("TIC");
                cbxOrientacion.Items.Add("Gestion");
                cbxOrientacion.Items.Add("Medios");
                cbxOrientacion.Items.Add("Humanidades");
                cbxOrientacion.Items.Add("Diseño");

            }

            cbxOrientacion.Show();
            llOrientacion.Show();
        }

        private void cbxOrientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLetra.Items.Clear();
            
            if (cbxCurso.Text == "7mo" && cbxOrientacion.Text == "Ninguna")
            {
                cbxLetra.Items.Add("A"); cbxLetra.Items.Add("B"); cbxLetra.Items.Add("C"); cbxLetra.Items.Add("D"); cbxLetra.Items.Add("E"); cbxLetra.Items.Add("F"); cbxLetra.Items.Add("G");
            }
            else if (cbxCurso.Text == "1ro" && cbxOrientacion.Text == "Ninguna")
            {
                cbxLetra.Items.Add("A"); cbxLetra.Items.Add("B"); cbxLetra.Items.Add("C"); cbxLetra.Items.Add("D"); cbxLetra.Items.Add("E"); cbxLetra.Items.Add("F"); cbxLetra.Items.Add("G");
                cbxLetra.Items.Add("H"); cbxLetra.Items.Add("I"); cbxLetra.Items.Add("J"); cbxLetra.Items.Add("K"); cbxLetra.Items.Add("L"); cbxLetra.Items.Add("M"); cbxLetra.Items.Add("N");
                cbxLetra.Items.Add("O"); cbxLetra.Items.Add("P"); cbxLetra.Items.Add("Q"); cbxLetra.Items.Add("R"); cbxLetra.Items.Add("S"); cbxLetra.Items.Add("T");
            }
            else if (cbxCurso.Text == "2do" && cbxOrientacion.Text == "Ninguna")
            {
                cbxLetra.Items.Add("A"); cbxLetra.Items.Add("B"); cbxLetra.Items.Add("C"); cbxLetra.Items.Add("D"); cbxLetra.Items.Add("E"); cbxLetra.Items.Add("F"); cbxLetra.Items.Add("G");
                cbxLetra.Items.Add("H"); cbxLetra.Items.Add("I"); cbxLetra.Items.Add("J"); cbxLetra.Items.Add("K"); cbxLetra.Items.Add("L"); cbxLetra.Items.Add("M"); cbxLetra.Items.Add("N");
                cbxLetra.Items.Add("O"); cbxLetra.Items.Add("P");
            }
            else if (cbxCurso.Text == "3ro" && cbxOrientacion.Text == "TIC")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
                cbxLetra.Items.Add("E");
                cbxLetra.Items.Add("F");
            }
            else if (cbxCurso.Text == "4to" && cbxOrientacion.Text == "TIC")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "5to" && cbxOrientacion.Text == "TIC")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "3ro" && cbxOrientacion.Text == "Medios")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
                cbxLetra.Items.Add("E");
            }
            else if (cbxCurso.Text == "4to" && cbxOrientacion.Text == "Medios")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "5to" && cbxOrientacion.Text == "Medios")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "3ro" && cbxOrientacion.Text == "Gestion")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
            }
            else if (cbxCurso.Text == "4to" && cbxOrientacion.Text == "Gestion")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "5to" && cbxOrientacion.Text == "Gestion")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
                cbxLetra.Items.Add("D");
            }
            else if (cbxCurso.Text == "3ro" && cbxOrientacion.Text == "Diseño")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
            }
            else if (cbxCurso.Text == "4to" && cbxOrientacion.Text == "Diseño")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
            }
            else if (cbxCurso.Text == "5to" && cbxOrientacion.Text == "Diseño")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
                cbxLetra.Items.Add("C");
            }
            else if (cbxCurso.Text == "3ro" && cbxOrientacion.Text == "Humanidades")
            {
                cbxLetra.Items.Add("A");
            }
            else if (cbxCurso.Text == "4to" && cbxOrientacion.Text == "Humanidades")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
            }
            else if (cbxCurso.Text == "5to" && cbxOrientacion.Text == "Humanidades")
            {
                cbxLetra.Items.Add("A");
                cbxLetra.Items.Add("B");
            }
            cbxLetra.Show();
            llLetra.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.Show();
        }
    }
}
