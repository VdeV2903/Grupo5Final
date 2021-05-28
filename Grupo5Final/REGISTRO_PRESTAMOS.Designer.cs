
namespace Grupo5Final
{
    partial class REGISTRO_PRESTAMOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTRO_PRESTAMOS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.dtpsalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtCodE = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.errorDestinatario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorsalida = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEntrega = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCarnet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDestinatario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCarnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESTINATARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(100, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA DE SALIDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(100, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA ENTREGA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(100, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "CARNET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(100, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "CODIGO DE EMPLEADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grupo5Final.Properties.Resources.brand_1_;
            this.pictureBox1.Location = new System.Drawing.Point(1358, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinatario.Location = new System.Drawing.Point(454, 175);
            this.txtDestinatario.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(589, 35);
            this.txtDestinatario.TabIndex = 6;
            // 
            // dtpsalida
            // 
            this.dtpsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsalida.Location = new System.Drawing.Point(454, 218);
            this.dtpsalida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpsalida.Name = "dtpsalida";
            this.dtpsalida.Size = new System.Drawing.Size(589, 35);
            this.dtpsalida.TabIndex = 7;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntrega.Location = new System.Drawing.Point(454, 261);
            this.dtpEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(589, 35);
            this.dtpEntrega.TabIndex = 8;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(454, 304);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(589, 35);
            this.txtCarnet.TabIndex = 9;
            // 
            // txtCodE
            // 
            this.txtCodE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodE.Location = new System.Drawing.Point(454, 347);
            this.txtCodE.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodE.Name = "txtCodE";
            this.txtCodE.Size = new System.Drawing.Size(589, 35);
            this.txtCodE.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(454, 472);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(288, 70);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Grupo5Final.Properties.Resources.Cancel_icon_icons_com_73703;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(755, 472);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(288, 70);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(100, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "TITULO DE LIBRO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(454, 390);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(589, 35);
            this.txtTitulo.TabIndex = 15;
            // 
            // errorDestinatario
            // 
            this.errorDestinatario.ContainerControl = this;
            // 
            // errorsalida
            // 
            this.errorsalida.ContainerControl = this;
            // 
            // errorEntrega
            // 
            this.errorEntrega.ContainerControl = this;
            // 
            // errorCarnet
            // 
            this.errorCarnet.ContainerControl = this;
            // 
            // errorCodE
            // 
            this.errorCodE.ContainerControl = this;
            // 
            // errorTitulo
            // 
            this.errorTitulo.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(100, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "COD. PRESTAMO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestamo.Location = new System.Drawing.Point(454, 132);
            this.txtPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(589, 35);
            this.txtPrestamo.TabIndex = 17;
            // 
            // REGISTRO_PRESTAMOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(15)))), ((int)(((byte)(56)))));
            this.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.ClientSize = new System.Drawing.Size(1081, 693);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCodE);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dtpsalida);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "REGISTRO_PRESTAMOS";
            this.Text = "     REGISTRO DE PRESTAMOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDestinatario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorsalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCarnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.DateTimePicker dtpsalida;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtCodE;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ErrorProvider errorDestinatario;
        private System.Windows.Forms.ErrorProvider errorsalida;
        private System.Windows.Forms.ErrorProvider errorEntrega;
        private System.Windows.Forms.ErrorProvider errorCarnet;
        private System.Windows.Forms.ErrorProvider errorCodE;
        private System.Windows.Forms.ErrorProvider errorTitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrestamo;
    }
}