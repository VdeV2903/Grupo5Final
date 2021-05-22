using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Grupo5Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

       

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtuser.Text))
                {
                    erroruser.SetError(txtuser, "Ingrese el usuario");
                    return;
                }
                if (string.IsNullOrEmpty(txtpass.Text))
                {
                    errorpass.SetError(txtpass, "Ingrese la contraseña");
                    return;
                }
                string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Contraseña FROM Empleados WHERE Usuario='" + txtuser.Text + "' AND Contraseña='" + txtpass.Text + "'", conexion))

                    {
                        SqlDataReader readr = cmd.ExecuteReader();
                        if (readr.Read())
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos Incorrectos");
                        }
                    }

                    conexion.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //QUITAR ADVERTENCIA DEL TXTUSER
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            erroruser.Clear();
        }
        //QUITAR ADVERTENCIA DEL TXTPASS
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorpass.Clear();
        }

      
    }
}
