
namespace Grupo5Final
{
    partial class Estudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estudiante));
            this.errorcarnet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errornombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorapellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcarrera = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorcorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.ckcorreo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorcarnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorapellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcorreo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorcarnet
            // 
            this.errorcarnet.ContainerControl = this;
            // 
            // errornombre
            // 
            this.errornombre.ContainerControl = this;
            // 
            // errorapellido
            // 
            this.errorapellido.ContainerControl = this;
            // 
            // errorcarrera
            // 
            this.errorcarrera.ContainerControl = this;
            // 
            // errorcorreo
            // 
            this.errorcorreo.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "CARRERA:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "CORREO:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDOS:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(164, 177);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(772, 35);
            this.txtapellidos.TabIndex = 7;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(164, 91);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(772, 35);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(164, 349);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(772, 35);
            this.txtcorreo.TabIndex = 9;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARNET:";
            // 
            // txtcarnet
            // 
            this.txtcarnet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarnet.Location = new System.Drawing.Point(164, 5);
            this.txtcarnet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(772, 35);
            this.txtcarnet.TabIndex = 5;
            this.txtcarnet.TextChanged += new System.EventHandler(this.txtcarnet_TextChanged);
            this.txtcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarnet_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.02128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.97872F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtcarnet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtcorreo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtnombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtapellidos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbcarrera, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ckcorreo, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 526);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45317F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54683F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnguardar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(164, 435);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 83);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Grupo5Final.Properties.Resources.Cancel_icon_icons_com_73703;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(308, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 73);
            this.button2.TabIndex = 14;
            this.button2.Text = "CANCELAR";
            this.button2.UseMnemonic = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.Location = new System.Drawing.Point(4, 5);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(288, 73);
            this.btnguardar.TabIndex = 13;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click_1);
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Items.AddRange(new object[] {
            "Arquitectura",
            "Ingeniería en Sistemas y Computación ",
            "Ingeniería Industrial ",
            "Licenciatura en Administración de Empresas ",
            "Licenciatura en Ciencias Jurídicas",
            "Licenciatura en Comunicaciones",
            "Licenciatura en Contaduría Pública ",
            "Licenciatura en Diseño Gráfico",
            "Licenciatura en Idioma Inglés ",
            "Licenciatura en Informática",
            "Licenciatura en Mercadeo ",
            "Licenciatura en Negocios Internacionales",
            "Licenciatura en Psicología",
            "Técnico en Administración Turística",
            "Técnico en Diseño Gráfico",
            "Técnico en Ingeniería de Redes Computacionales",
            "Técnico en Ingeniería de Software",
            "Técnico en Mercadeo y Ventas",
            "Técnico en Relaciones Públicas"});
            this.cmbcarrera.Location = new System.Drawing.Point(164, 263);
            this.cmbcarrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(772, 37);
            this.cmbcarrera.TabIndex = 14;
            this.cmbcarrera.Text = "SELECCIONE....";
            // 
            // ckcorreo
            // 
            this.ckcorreo.AutoSize = true;
            this.ckcorreo.Checked = true;
            this.ckcorreo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcorreo.Location = new System.Drawing.Point(944, 349);
            this.ckcorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckcorreo.Name = "ckcorreo";
            this.ckcorreo.Size = new System.Drawing.Size(191, 29);
            this.ckcorreo.TabIndex = 15;
            this.ckcorreo.Text = "INSTITUCIONAL";
            this.ckcorreo.UseVisualStyleBackColor = true;
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1244, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Estudiante";
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.Estudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorcarnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errornombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorapellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcorreo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorcarnet;
        private System.Windows.Forms.ErrorProvider errornombre;
        private System.Windows.Forms.ErrorProvider errorapellido;
        private System.Windows.Forms.ErrorProvider errorcarrera;
        private System.Windows.Forms.ErrorProvider errorcorreo;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbcarrera;
        private System.Windows.Forms.CheckBox ckcorreo;
    }
}