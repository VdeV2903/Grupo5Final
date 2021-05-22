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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {
            
           
        }
        public void sesion()
        {
            
        }
        public void deauth()
        {
            btnprestar.Enabled = false;
            btndevolver.Enabled = false;
            btnconsultar.Enabled = false;
            btnregistrar_estu.Enabled = false;
            btnregistrarlibro.Enabled = false;
            btnmodlibro.Enabled = false;
            btnmodestu.Enabled = false;
        }
        public void auth_ok()
        {
            btnprestar.Enabled = true;
            btndevolver.Enabled = true;
            btnconsultar.Enabled = true;
            btnregistrar_estu.Enabled = true;
            btnregistrarlibro.Enabled = true;
            btnmodlibro.Enabled = true;
            btnmodestu.Enabled = true;
        }
        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
            
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            abrirhija(new CONSULTA_LIBROS());
        }
    }
}
