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
    public partial class REGISTRO_PRESTAMOS : Form
    {
        public REGISTRO_PRESTAMOS()
        {
            InitializeComponent();
        }

        private void txtDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorDestinatario.Clear();

        }

        private void dtpsalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorsalida.Clear();
        }

        private void dtpEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorEntrega.Clear();
        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCarnet.Clear();
        }

        private void txtCodE_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorCodE.Clear();
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorTitulo.Clear();
        }

        string CodeES, codeEM;
        string code_Prest;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDestinatario.Text))
                {
                    errorDestinatario.SetError(txtDestinatario, "Ingrese el Destinatario");

                }
                if (string.IsNullOrEmpty(dtpsalida.Text))
                {
                    errorsalida.SetError(dtpsalida, "Seleccione la fecha de salida");

                }
                if (string.IsNullOrEmpty(dtpEntrega.Text))
                {
                    errorEntrega.SetError(dtpEntrega, "Seleccione la fecha de entrega");

                }
                if (string.IsNullOrEmpty(txtCarnet.Text))
                {
                    errorCarnet.SetError(txtCarnet, "Ingrese el Carnet");

                }
                if (string.IsNullOrEmpty(txtCodE.Text))
                {
                    errorCodE.SetError(txtCodE, "Ingrese el Codigo del Empleado");
             
                }
                if (string.IsNullOrEmpty(txtTitulo.Text))
                {
                    errorTitulo.SetError(txtTitulo, "Ingrese el Titulo");
                    return;
                }

                CodeES = txtCarnet.Text;
                codeEM = txtCodE.Text;
                code_Prest = ((CodeES.Substring(0, 2) + codeEM.Substring(0, 2)).ToUpper());
                txtPrestamo.Text = code_Prest;

                string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cn))

                { 
                    conexion.Open();
                    SqlCommand cm = new SqlCommand("SP_insertprestamo", conexion);          //command
                    cm.CommandType = CommandType.StoredProcedure;   //tipo de conexion
                    cm.Parameters.Add(new SqlParameter("@v0", SqlDbType.Char, 11, "v0"));
                    cm.Parameters.Add(new SqlParameter("@v1", SqlDbType.VarChar, 75, "v1"));
                    cm.Parameters.Add(new SqlParameter("@v2", SqlDbType.Date)).Value = dtpsalida.Value.Date;
                    cm.Parameters.Add(new SqlParameter("@v3", SqlDbType.Date)).Value = dtpEntrega.Value.Date;
                    cm.Parameters.Add(new SqlParameter("@v4", SqlDbType.Char, 14, "v4"));
                    cm.Parameters.Add(new SqlParameter("@v5", SqlDbType.Char, 10, "v5"));
                    cm.Parameters.Add(new SqlParameter("@v6", SqlDbType.NChar, 25, "v6"));

                    cm.Parameters[0].Value = Convert.ToString(code_Prest);
                    cm.Parameters[1].Value = Convert.ToString(txtDestinatario.Text.ToUpper());
                    cm.Parameters[2].Value = Convert.ToString(dtpsalida.MinDate);
                    cm.Parameters[3].Value = Convert.ToString(dtpEntrega.MinDate);
                    cm.Parameters[4].Value = Convert.ToString(txtCarnet.Text.ToUpper());
                    cm.Parameters[5].Value = Convert.ToString(txtCodE.Text.ToUpper());
                    cm.Parameters[6].Value = Convert.ToString(txtTitulo.Text.ToUpper());

                    cm.ExecuteNonQuery();

                    conexion.Close();
                    clearcomponents();
                    MessageBox.Show("SE HA REGISTRADO EL PRESTAMO CORRECTAMENTE");
                }

            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clearcomponents()
        {
            txtPrestamo.Clear();
            txtDestinatario.Clear();
            dtpsalida.CustomFormat = ""; 
            dtpEntrega.CustomFormat = "";
            txtCarnet.Clear();
            txtCodE.Clear();
            txtTitulo.Clear();
        }
    }
}
