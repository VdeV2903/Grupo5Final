
namespace Grupo5Final
{
    partial class Devolucion_Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion_Libros));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPrest = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgDevolucion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(34, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO PRESTAMO :";
            // 
            // txtCodPrest
            // 
            this.txtCodPrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPrest.Location = new System.Drawing.Point(320, 63);
            this.txtCodPrest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodPrest.Name = "txtCodPrest";
            this.txtCodPrest.Size = new System.Drawing.Size(504, 30);
            this.txtCodPrest.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Grupo5Final.Properties.Resources.Cancel_icon_icons_com_73703;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(971, 587);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 70);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.BackColor = System.Drawing.Color.Transparent;
            this.btnRecibir.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.btnRecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.ForeColor = System.Drawing.Color.White;
            this.btnRecibir.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibir.Image")));
            this.btnRecibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibir.Location = new System.Drawing.Point(671, 587);
            this.btnRecibir.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(206, 70);
            this.btnRecibir.TabIndex = 14;
            this.btnRecibir.Text = "RECIBIR";
            this.btnRecibir.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(860, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(175, 64);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgDevolucion
            // 
            this.dtgDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevolucion.Location = new System.Drawing.Point(39, 132);
            this.dtgDevolucion.Name = "dtgDevolucion";
            this.dtgDevolucion.RowHeadersWidth = 62;
            this.dtgDevolucion.RowTemplate.Height = 28;
            this.dtgDevolucion.Size = new System.Drawing.Size(1131, 434);
            this.dtgDevolucion.TabIndex = 17;
            // 
            // Devolucion_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.BackgroundImage = global::Grupo5Final.Properties.Resources.Background_RO;
            this.ClientSize = new System.Drawing.Size(1202, 670);
            this.Controls.Add(this.dtgDevolucion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.txtCodPrest);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Devolucion_Libros";
            this.Text = "   DEVOLUCION DE LIBRO";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPrest;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgDevolucion;
    }
}