namespace Electrodomesticos.Formularios
{
    partial class frmCONSULTAS
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosOrdenadosPorNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoConMayorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasMayoresA100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeMenorValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(81, 176);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(969, 438);
            this.dgvConsultas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(426, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONSULTAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosOrdenadosPorNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosOrdenadosPorNToolStripMenuItem
            // 
            this.productosOrdenadosPorNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoConMayorPrecioToolStripMenuItem,
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem,
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem,
            this.ventasMayoresA100ToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.ventasDeMenorValorToolStripMenuItem});
            this.productosOrdenadosPorNToolStripMenuItem.Name = "productosOrdenadosPorNToolStripMenuItem";
            this.productosOrdenadosPorNToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.productosOrdenadosPorNToolStripMenuItem.Text = "LINQ CONSULTAS";
            // 
            // productoConMayorPrecioToolStripMenuItem
            // 
            this.productoConMayorPrecioToolStripMenuItem.Name = "productoConMayorPrecioToolStripMenuItem";
            this.productoConMayorPrecioToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.productoConMayorPrecioToolStripMenuItem.Text = "Producto con mayor precio";
            this.productoConMayorPrecioToolStripMenuItem.Click += new System.EventHandler(this.productoConMayorPrecioToolStripMenuItem_Click);
            // 
            // clientesOrdenadosAlfabeticamenteToolStripMenuItem
            // 
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem.Name = "clientesOrdenadosAlfabeticamenteToolStripMenuItem";
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem.Text = "Clientes ordenados alfabeticamente";
            this.clientesOrdenadosAlfabeticamenteToolStripMenuItem.Click += new System.EventHandler(this.clientesOrdenadosAlfabeticamenteToolStripMenuItem_Click);
            // 
            // productosOrdenadosAlfabeticamenteToolStripMenuItem
            // 
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem.Name = "productosOrdenadosAlfabeticamenteToolStripMenuItem";
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem.Text = "Productos ordenados alfabeticamente";
            this.productosOrdenadosAlfabeticamenteToolStripMenuItem.Click += new System.EventHandler(this.productosOrdenadosAlfabeticamenteToolStripMenuItem_Click);
            // 
            // ventasMayoresA100ToolStripMenuItem
            // 
            this.ventasMayoresA100ToolStripMenuItem.Name = "ventasMayoresA100ToolStripMenuItem";
            this.ventasMayoresA100ToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.ventasMayoresA100ToolStripMenuItem.Text = "Ventas mayores a 100$";
            this.ventasMayoresA100ToolStripMenuItem.Click += new System.EventHandler(this.ventasMayoresA100ToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.ventaToolStripMenuItem.Text = "Ventas de mayor valor";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // ventasDeMenorValorToolStripMenuItem
            // 
            this.ventasDeMenorValorToolStripMenuItem.Name = "ventasDeMenorValorToolStripMenuItem";
            this.ventasDeMenorValorToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.ventasDeMenorValorToolStripMenuItem.Text = "Ventas de menor valor";
            this.ventasDeMenorValorToolStripMenuItem.Click += new System.EventHandler(this.ventasDeMenorValorToolStripMenuItem_Click);
            // 
            // frmCONSULTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 697);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCONSULTAS";
            this.Text = "frmCONSULTAS";
            this.Load += new System.EventHandler(this.frmCONSULTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosOrdenadosPorNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoConMayorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesOrdenadosAlfabeticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosOrdenadosAlfabeticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasMayoresA100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeMenorValorToolStripMenuItem;
    }
}