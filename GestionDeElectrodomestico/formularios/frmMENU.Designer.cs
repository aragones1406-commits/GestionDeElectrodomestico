namespace Electrodomesticos
{
    partial class frmMENU
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNREPORTES = new System.Windows.Forms.Button();
            this.BTNCONSULTAS = new System.Windows.Forms.Button();
            this.BTNVENTAS = new System.Windows.Forms.Button();
            this.BTNPRODUCTOS = new System.Windows.Forms.Button();
            this.BTNCLIENTES = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.BTNREPORTES);
            this.panel1.Controls.Add(this.BTNCONSULTAS);
            this.panel1.Controls.Add(this.BTNVENTAS);
            this.panel1.Controls.Add(this.BTNPRODUCTOS);
            this.panel1.Controls.Add(this.BTNCLIENTES);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-54, -26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 208);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNREPORTES
            // 
            this.BTNREPORTES.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Bold);
            this.BTNREPORTES.Image = global::GestionDeElectrodomestico.Properties.Resources.reporte_de_negocios;
            this.BTNREPORTES.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNREPORTES.Location = new System.Drawing.Point(269, 122);
            this.BTNREPORTES.Name = "BTNREPORTES";
            this.BTNREPORTES.Size = new System.Drawing.Size(203, 49);
            this.BTNREPORTES.TabIndex = 5;
            this.BTNREPORTES.Text = "REPORTES";
            this.BTNREPORTES.UseVisualStyleBackColor = true;
            this.BTNREPORTES.Click += new System.EventHandler(this.BTNREPORTES_Click);
            // 
            // BTNCONSULTAS
            // 
            this.BTNCONSULTAS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.BTNCONSULTAS.Image = global::GestionDeElectrodomestico.Properties.Resources.consulta__1_;
            this.BTNCONSULTAS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNCONSULTAS.Location = new System.Drawing.Point(739, 121);
            this.BTNCONSULTAS.Name = "BTNCONSULTAS";
            this.BTNCONSULTAS.Size = new System.Drawing.Size(251, 48);
            this.BTNCONSULTAS.TabIndex = 4;
            this.BTNCONSULTAS.Text = "CONSULTAS";
            this.BTNCONSULTAS.UseVisualStyleBackColor = true;
            this.BTNCONSULTAS.Click += new System.EventHandler(this.BTNCONSULTAS_Click);
            // 
            // BTNVENTAS
            // 
            this.BTNVENTAS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.BTNVENTAS.Image = global::GestionDeElectrodomestico.Properties.Resources.bolsa_de_la_compra;
            this.BTNVENTAS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNVENTAS.Location = new System.Drawing.Point(996, 122);
            this.BTNVENTAS.Name = "BTNVENTAS";
            this.BTNVENTAS.Size = new System.Drawing.Size(183, 48);
            this.BTNVENTAS.TabIndex = 3;
            this.BTNVENTAS.Text = "VENTAS";
            this.BTNVENTAS.UseVisualStyleBackColor = true;
            this.BTNVENTAS.Click += new System.EventHandler(this.BTNVENTAS_Click);
            // 
            // BTNPRODUCTOS
            // 
            this.BTNPRODUCTOS.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRODUCTOS.Image = global::GestionDeElectrodomestico.Properties.Resources.comercio_electronico__1_;
            this.BTNPRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNPRODUCTOS.Location = new System.Drawing.Point(487, 122);
            this.BTNPRODUCTOS.Name = "BTNPRODUCTOS";
            this.BTNPRODUCTOS.Size = new System.Drawing.Size(236, 49);
            this.BTNPRODUCTOS.TabIndex = 2;
            this.BTNPRODUCTOS.Text = "PRODUCTOS";
            this.BTNPRODUCTOS.UseVisualStyleBackColor = true;
            this.BTNPRODUCTOS.Click += new System.EventHandler(this.BTNPRODUCTOS_Click);
            // 
            // BTNCLIENTES
            // 
            this.BTNCLIENTES.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCLIENTES.Image = global::GestionDeElectrodomestico.Properties.Resources.icons8_customer_32;
            this.BTNCLIENTES.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTNCLIENTES.Location = new System.Drawing.Point(66, 120);
            this.BTNCLIENTES.Name = "BTNCLIENTES";
            this.BTNCLIENTES.Size = new System.Drawing.Size(188, 48);
            this.BTNCLIENTES.TabIndex = 1;
            this.BTNCLIENTES.Text = "CLIENTES";
            this.BTNCLIENTES.UseVisualStyleBackColor = true;
            this.BTNCLIENTES.Click += new System.EventHandler(this.BTNCLIENTES_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPTECH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionDeElectrodomestico.Properties.Resources.plantilla_mascota_logotipo_tienda_informatica_190190_142;
            this.pictureBox1.Location = new System.Drawing.Point(83, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1125, 553);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 764);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMENU";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNREPORTES;
        private System.Windows.Forms.Button BTNCONSULTAS;
        private System.Windows.Forms.Button BTNVENTAS;
        private System.Windows.Forms.Button BTNPRODUCTOS;
        private System.Windows.Forms.Button BTNCLIENTES;
        private System.Windows.Forms.Label label1;
    }
}

