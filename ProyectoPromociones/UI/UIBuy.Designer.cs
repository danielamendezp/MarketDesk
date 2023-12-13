namespace ProyectoPromociones.UI
{
    partial class UIBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIBuy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jCantidad = new System.Windows.Forms.NumericUpDown();
            this.jLblDescipcion = new System.Windows.Forms.Label();
            this.jLblPrecio = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.jTxtCodigoBarras = new System.Windows.Forms.TextBox();
            this.jLblBuscar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jButAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.jTxtSubTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jButFacturar = new System.Windows.Forms.Button();
            this.jTablaTotales = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTablaTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regresarToolStripMenuItem.Image")));
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // jCantidad
            // 
            this.jCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCantidad.Location = new System.Drawing.Point(328, 416);
            this.jCantidad.Name = "jCantidad";
            this.jCantidad.Size = new System.Drawing.Size(120, 24);
            this.jCantidad.TabIndex = 1;
            this.jCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // jLblDescipcion
            // 
            this.jLblDescipcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jLblDescipcion.Location = new System.Drawing.Point(29, 500);
            this.jLblDescipcion.Name = "jLblDescipcion";
            this.jLblDescipcion.Size = new System.Drawing.Size(371, 51);
            this.jLblDescipcion.TabIndex = 2;
            this.jLblDescipcion.Text = "Manzana Empacado 1 Kilo ";
            this.jLblDescipcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jLblPrecio
            // 
            this.jLblPrecio.AutoSize = true;
            this.jLblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jLblPrecio.Location = new System.Drawing.Point(125, 314);
            this.jLblPrecio.Name = "jLblPrecio";
            this.jLblPrecio.Size = new System.Drawing.Size(71, 29);
            this.jLblPrecio.TabIndex = 4;
            this.jLblPrecio.Text = " 1555";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(83, 329);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 169);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // jTxtCodigoBarras
            // 
            this.jTxtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtCodigoBarras.Location = new System.Drawing.Point(113, 121);
            this.jTxtCodigoBarras.Name = "jTxtCodigoBarras";
            this.jTxtCodigoBarras.Size = new System.Drawing.Size(393, 24);
            this.jTxtCodigoBarras.TabIndex = 6;
            this.jTxtCodigoBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtCodigoBarras_KeyDown);
            // 
            // jLblBuscar
            // 
            this.jLblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("jLblBuscar.Image")));
            this.jLblBuscar.Location = new System.Drawing.Point(66, 112);
            this.jLblBuscar.Name = "jLblBuscar";
            this.jLblBuscar.Size = new System.Drawing.Size(42, 46);
            this.jLblBuscar.TabIndex = 7;
            this.jLblBuscar.Click += new System.EventHandler(this.jLblBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.jButAgregar);
            this.groupBox1.Controls.Add(this.jLblPrecio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 365);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "₡";
            // 
            // jButAgregar
            // 
            this.jButAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jButAgregar.Image = ((System.Drawing.Image)(resources.GetObject("jButAgregar.Image")));
            this.jButAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButAgregar.Location = new System.Drawing.Point(335, 314);
            this.jButAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jButAgregar.Name = "jButAgregar";
            this.jButAgregar.Size = new System.Drawing.Size(116, 45);
            this.jButAgregar.TabIndex = 15;
            this.jButAgregar.Text = "Agregar";
            this.jButAgregar.UseVisualStyleBackColor = true;
            this.jButAgregar.Click += new System.EventHandler(this.jButAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código de Barras";
            // 
            // jTxtSubTotal
            // 
            this.jTxtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtSubTotal.Location = new System.Drawing.Point(794, 670);
            this.jTxtSubTotal.Name = "jTxtSubTotal";
            this.jTxtSubTotal.Size = new System.Drawing.Size(214, 26);
            this.jTxtSubTotal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(670, 670);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "SubTotal";
            // 
            // jButFacturar
            // 
            this.jButFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButFacturar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jButFacturar.Image = ((System.Drawing.Image)(resources.GetObject("jButFacturar.Image")));
            this.jButFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButFacturar.Location = new System.Drawing.Point(939, 716);
            this.jButFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jButFacturar.Name = "jButFacturar";
            this.jButFacturar.Size = new System.Drawing.Size(116, 45);
            this.jButFacturar.TabIndex = 14;
            this.jButFacturar.Text = "Facturar";
            this.jButFacturar.UseVisualStyleBackColor = true;
            this.jButFacturar.Click += new System.EventHandler(this.jButFacturar_Click);
            // 
            // jTablaTotales
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.jTablaTotales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.jTablaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jTablaTotales.Location = new System.Drawing.Point(528, 49);
            this.jTablaTotales.Name = "jTablaTotales";
            this.jTablaTotales.RowHeadersWidth = 51;
            this.jTablaTotales.Size = new System.Drawing.Size(527, 588);
            this.jTablaTotales.TabIndex = 15;
            // 
            // UIBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 770);
            this.Controls.Add(this.jTablaTotales);
            this.Controls.Add(this.jButFacturar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jTxtSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jLblBuscar);
            this.Controls.Add(this.jTxtCodigoBarras);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.jLblDescipcion);
            this.Controls.Add(this.jCantidad);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UIBuy";
            this.Text = "UIBuy";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTablaTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown jCantidad;
        private System.Windows.Forms.Label jLblDescipcion;
        private System.Windows.Forms.Label jLblPrecio;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox jTxtCodigoBarras;
        private System.Windows.Forms.Label jLblBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jTxtSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Button jButFacturar;
        private System.Windows.Forms.Button jButAgregar;
        private System.Windows.Forms.DataGridView jTablaTotales;
        private System.Windows.Forms.Label label1;
    }
}