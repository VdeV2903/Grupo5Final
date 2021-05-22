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


namespace BaseResgistro
{
    public partial class FrEstudiante : Form
    {
        public FrEstudiante()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //llamamos cadena de conexion
            Conexion.Conectar();
            MessageBox.Show("Conexion con exito");
            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();//objeto datatable
            string consulta = "SELECT *FROM ALUMNO";
            SqlCommand cmd = new SqlCommand(consulta,Conexion.Conectar());//comando sql

            SqlDataAdapter da = new SqlDataAdapter(cmd);//le pasamos el comando
            da.Fill(dt);//para que llene todo
            return dt;//retornamos datatable

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO ALUMNO (CODIGO, NOMBRES, APELLIDOS, DIRECCION) VALUES (@CODIGO,@NOMBRES,@APELLIDOS,@DIRECCION)";
            SqlCommand cmd1 = new SqlCommand(insertar,Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@CODIGO",txtCodigo.Text);
            cmd1.Parameters.AddWithValue("@NOMBRES",txtNom.Text);
            cmd1.Parameters.AddWithValue("@APELLIDOS",txtApelli.Text);
            cmd1.Parameters.AddWithValue("@DIRECCION",txtDir.Text);

            cmd1.ExecuteNonQuery();//ejecutamos el comando
            MessageBox.Show("Los datos fueron agregados");

            dataGridView1.DataSource = llenar_grid();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar="UPDATE ALUMNO SET CODIGO=@CODIGO,NOMBRES=@NOMBRES,APELLIDOS=@APELLIDOS,DIRECCION=@DIRECCION WHERE CODIGO=@CODIGO";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            cmd2.Parameters.AddWithValue ("@CODIGO",txtCodigo.Text);
            cmd2.Parameters.AddWithValue("@NOMBRES", txtNom.Text);
            cmd2.Parameters.AddWithValue("@APELLIDOS", txtApelli.Text);
            cmd2.Parameters.AddWithValue("@DIRECCION", txtDir.Text);

            cmd2.ExecuteNonQuery();//ejecutamos el comando

            MessageBox.Show("Los datos fueron actualizados");
            dataGridView1.DataSource = llenar_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApelli.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //llamamos la clase conexion conectar
            Conexion.Conectar();
            string eliminar = "DELETE FROM ALUMNO WHERE CODIGO=@CODIGO";
            SqlCommand cmd3 = new SqlCommand(eliminar,Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@CODIGO", txtCodigo.Text);

            cmd3.ExecuteNonQuery();//ejecutamos el comando

            MessageBox.Show("Los datos fueron eliminados");
            dataGridView1.DataSource = llenar_grid();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNom.Clear();
            txtApelli.Clear();
            txtDir.Clear();
            txtCodigo.Focus();//
        }
    }
}
