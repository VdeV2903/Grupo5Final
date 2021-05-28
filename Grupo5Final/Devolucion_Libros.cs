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
    public partial class Devolucion_Libros : Form
    {
        public Devolucion_Libros()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cn))
            {
                try
                {
                    conexion.Open();
                    string query = "select ISNULL(Codigo_Prestamo,0) AS LASTID from Prestamo";
                    SqlCommand cmd1 = new SqlCommand(query,conexion);
                    int code = Convert.ToInt32(cmd1.ExecuteScalar());
                    int var = Convert.ToInt32(txtCodPrest.Text);

                    if (code == var)
                    {
                        SqlCommand cmd = new SqlCommand("Select * from Prestamo where Codigo_prestamo="+var+"", conexion);
                        SqlDataAdapter adt = new SqlDataAdapter();
                        adt.SelectCommand = cmd;
                        DataTable T_Prestamo = new DataTable();
                        adt.Fill(T_Prestamo);
                        dtgDevolucion.DataSource = T_Prestamo;
                    }
                    else
                        MessageBox.Show("No se encontro registro del prestamo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clearcomponents();
        }
        public void clearcomponents()
        {
            txtCodPrest.Clear();
        }
    }
}
