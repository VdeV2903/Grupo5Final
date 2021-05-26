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
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
            cmbcarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Estudiante_Load(object sender, EventArgs e)
        {

        }

        private void txtcarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorcarnet.Clear();
            
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            errornombre.Clear();
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorapellido.Clear();
        }

        private void txtcarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorcarrera.Clear();
        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorcorreo.Clear();
        }

    

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            clearcomponents();
        }
        public void clearcomponents()
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtapellidos.Clear();
            txtcorreo.Clear();
        }
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtcarnet.Text))
                {
                    errorcarnet.SetError(txtcarnet, "Ingrese el carnet");

                }
                if (string.IsNullOrEmpty(txtnombre.Text))
                {
                    errornombre.SetError(txtnombre, "Ingrese nombre");

                }
                if (string.IsNullOrEmpty(txtapellidos.Text))
                {
                    errorapellido.SetError(txtapellidos, "Ingrese los apellidos");

                }
                if (string.IsNullOrEmpty(cmbcarrera.Text))
                {
                    errorcarrera.SetError(cmbcarrera, "Ingrese la carrera");

                }
                if (string.IsNullOrEmpty(txtcorreo.Text))
                {
                    errorcorreo.SetError(txtcorreo, "Ingrese el correo");
                    return;
                }
                string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cn))
                {
                    conexion.Open();
                    SqlCommand cm = new SqlCommand("SP_insertalumno", conexion);          //command
                    cm.CommandType = CommandType.StoredProcedure;   //tipo de conexion
                    cm.Parameters.Add(new SqlParameter("@v0", SqlDbType.Char, 14, "v0"));
                    cm.Parameters.Add(new SqlParameter("@v1", SqlDbType.VarChar, 75, "v1"));
                    cm.Parameters.Add(new SqlParameter("@v2", SqlDbType.VarChar, 75, "v2"));
                    cm.Parameters.Add(new SqlParameter("@v3", SqlDbType.VarChar, 70, "v3"));
                    cm.Parameters.Add(new SqlParameter("@v4", SqlDbType.VarChar, 35, "v4"));


                    cm.Parameters[0].Value = Convert.ToString(txtcarnet.Text.ToUpper());
                    cm.Parameters[1].Value = Convert.ToString(txtnombre.Text.ToUpper());
                    cm.Parameters[2].Value = Convert.ToString(txtapellidos.Text.ToUpper());
                    cm.Parameters[3].Value = Convert.ToString(cmbcarrera.Text.ToUpper());
                    cm.Parameters[4].Value = Convert.ToString(txtcorreo.Text);

                    cm.ExecuteNonQuery();
                    
                    conexion.Close();
                    clearcomponents();
                    MessageBox.Show("SE HA REGISTRADO AL ESTUDIANTE CORRECTAMENTE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearcomponents();
        }
        string ext = "@mail.utec.edu.sv";
        private void txtcarnet_TextChanged(object sender, EventArgs e)
        {
            if(ckcorreo.Checked == true)
            {
                txtcorreo.Text = txtcarnet.Text + ext;
            }
            
        }
    }
}
