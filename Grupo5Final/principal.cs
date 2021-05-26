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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        private void principal_Load(object sender, EventArgs e)
        {

        }
        public void rango(string rango)
        {

        }
        private Form activeform = null;
        private void abrirhija(Form formhija)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = formhija;
            formhija.TopLevel = false;
            formhija.FormBorderStyle = FormBorderStyle.None;
            formhija.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(formhija);
            panelcontenedor.Tag = formhija;
            formhija.Show();
            formhija.BringToFront();


            /*
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
            */
         }
        

        private void button1_Click(object sender, EventArgs e)
        {
                abrirhija(new REGISTRO_PRESTAMOS());
                
        }

        public void limpiarpanel()
        {
            panelcontenedor.Controls.Clear();
        }
        
      

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            abrirhija(new CONSULTA_LIBROS());
        }

        private void btnregistrar_estu_Click(object sender, EventArgs e)
        {
            abrirhija(new Estudiante());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnregistrarlibro_Click(object sender, EventArgs e)
        {
            abrirhija(new REGISTRO_LIBRO());
        }

        
    }
}
