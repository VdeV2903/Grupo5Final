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
    public partial class REGISTRO_LIBRO : Form
    {
        public REGISTRO_LIBRO()
        {
            InitializeComponent();
        }

        private void REGISTRO_LIBRO_Load(object sender, EventArgs e)
        {
            cargarcategorias();
            cmbcategoria.Text = "SELECCIONE...";
            cmbcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void cargarcategorias()
        {
            string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cn))
            {
                conexion.Open();
                SqlCommand cm = new SqlCommand("select nombre from Categorias;", conexion);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read() == true)
                {
                    cmbcategoria.Items.Add(dr[0]);
                }
                conexion.Close();
            }
        }
        public void clearcomponentslibro()
        {
            txttitulo.Clear();
            txtautor.Clear();
            cmbcategoria.Text = default;
            txteditorial.Clear();
        }
        string estado_default = "DISPONIBLE";
        string cod_libro;
        string tit, au;
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txttitulo.Text))
                {
                    errortitulo.SetError(txttitulo, "Ingrese el titulo");

                }
                if (string.IsNullOrEmpty(txtautor.Text))
                {
                    errorautor.SetError(txtautor, "Ingrese nombre");

                }
                if (string.IsNullOrEmpty(cmbcategoria.Text))
                {
                    errorcategoria.SetError(cmbcategoria, "Seleccione una categoria");

                }
                if (string.IsNullOrEmpty(txteditorial.Text))
                {
                    erroreditorial.SetError(txteditorial, "Ingrese la editorial");
                    return;
                }
                tit = txttitulo.Text;
                au = txtautor.Text;
                cod_libro = ((tit.Substring(0, 2) + "_" + au.Substring(0, 2)).ToUpper());
                txtcodigo.Text = cod_libro;

                string cn = ConfigurationManager.ConnectionStrings["conector"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cn))
                {
                    conexion.Open();
                    SqlCommand cm = new SqlCommand("insert_libro", conexion);          //command
                    cm.CommandType = CommandType.StoredProcedure;   //tipo de conexion
                    cm.Parameters.Add(new SqlParameter("@v0", SqlDbType.Char, 5, "v0"));
                    cm.Parameters.Add(new SqlParameter("@v1", SqlDbType.VarChar, 60, "v1"));
                    cm.Parameters.Add(new SqlParameter("@v2", SqlDbType.VarChar, 25, "v2"));
                    cm.Parameters.Add(new SqlParameter("@v3", SqlDbType.VarChar, 25, "v3"));
                    cm.Parameters.Add(new SqlParameter("@v4", SqlDbType.Char, 8, "v4"));
                    cm.Parameters.Add(new SqlParameter("@v5", SqlDbType.VarChar, 25, "v5"));

                    cm.Parameters[0].Value = Convert.ToString(cod_libro);
                    cm.Parameters[1].Value = Convert.ToString(txttitulo.Text.ToUpper());
                    cm.Parameters[2].Value = Convert.ToString(txteditorial.Text.ToUpper());
                    cm.Parameters[3].Value = Convert.ToString(txtautor.Text.ToUpper());
                    cm.Parameters[4].Value = Convert.ToString(cmbcategoria.Text.ToUpper());
                    cm.Parameters[5].Value = Convert.ToString(estado_default.ToUpper());

                    cm.ExecuteNonQuery();

                    conexion.Close();
                    clearcomponentslibro();
                    MessageBox.Show("SE HA REGISTRADO EL LIBRO CORRECTAMENTE");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
        }

        private void txttitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            errortitulo.Clear();
        }

        private void txtautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorautor.Clear();
        }

        private void cmbcategoria_Click(object sender, EventArgs e)
        {
            errorcategoria.Clear();
        }

        private void txteditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            erroreditorial.Clear();
        }
       
        
        public void generarcodigo()
        {
            
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {
            generarcodigo();
        }

        private void txtautor_TextChanged(object sender, EventArgs e)
        {
            generarcodigo();
        }
    }
}
