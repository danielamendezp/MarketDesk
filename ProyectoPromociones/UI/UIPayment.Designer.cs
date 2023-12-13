namespace ProyectoPromociones.UI
{
    partial class UIPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPayment));
            this.jNumTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jDetallesPago = new System.Windows.Forms.GroupBox();
            this.jCboPagos = new System.Windows.Forms.ComboBox();
            this.jButComprarTarjeta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jCaducidad = new System.Windows.Forms.MaskedTextBox();
            this.jCVC = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.jCboMetodoPago = new System.Windows.Forms.ComboBox();
            this.jCboCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jTxtComprarEfectivo = new System.Windows.Forms.Button();
            this.jLblPrecioFinal = new System.Windows.Forms.Label();
            this.jCambio = new System.Windows.Forms.MaskedTextBox();
            this.jCash = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.jDetallesPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jNumTarjeta
            // 
            this.jNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jNumTarjeta.Location = new System.Drawing.Point(99, 197);
            this.jNumTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.jNumTarjeta.Mask = "0000-0000-0000-0000";
            this.jNumTarjeta.Name = "jNumTarjeta";
            this.jNumTarjeta.Size = new System.Drawing.Size(155, 23);
            this.jNumTarjeta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(323, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(258, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 43);
            this.label2.TabIndex = 2;
            // 
            // jDetallesPago
            // 
            this.jDetallesPago.Controls.Add(this.jCboPagos);
            this.jDetallesPago.Controls.Add(this.jButComprarTarjeta);
            this.jDetallesPago.Controls.Add(this.label7);
            this.jDetallesPago.Controls.Add(this.label6);
            this.jDetallesPago.Controls.Add(this.label5);
            this.jDetallesPago.Controls.Add(this.label4);
            this.jDetallesPago.Controls.Add(this.label3);
            this.jDetallesPago.Controls.Add(this.jCaducidad);
            this.jDetallesPago.Controls.Add(this.jCVC);
            this.jDetallesPago.Controls.Add(this.label2);
            this.jDetallesPago.Controls.Add(this.label1);
            this.jDetallesPago.Controls.Add(this.jNumTarjeta);
            this.jDetallesPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jDetallesPago.Location = new System.Drawing.Point(462, 42);
            this.jDetallesPago.Margin = new System.Windows.Forms.Padding(2);
            this.jDetallesPago.Name = "jDetallesPago";
            this.jDetallesPago.Padding = new System.Windows.Forms.Padding(2);
            this.jDetallesPago.Size = new System.Drawing.Size(397, 429);
            this.jDetallesPago.TabIndex = 5;
            this.jDetallesPago.TabStop = false;
            this.jDetallesPago.Text = "Detalles de Pago";
            // 
            // jCboPagos
            // 
            this.jCboPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCboPagos.FormattingEnabled = true;
            this.jCboPagos.Location = new System.Drawing.Point(99, 96);
            this.jCboPagos.Name = "jCboPagos";
            this.jCboPagos.Size = new System.Drawing.Size(216, 28);
            this.jCboPagos.TabIndex = 12;
            // 
            // jButComprarTarjeta
            // 
            this.jButComprarTarjeta.BackColor = System.Drawing.Color.White;
            this.jButComprarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButComprarTarjeta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jButComprarTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("jButComprarTarjeta.Image")));
            this.jButComprarTarjeta.Location = new System.Drawing.Point(90, 370);
            this.jButComprarTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.jButComprarTarjeta.Name = "jButComprarTarjeta";
            this.jButComprarTarjeta.Size = new System.Drawing.Size(239, 43);
            this.jButComprarTarjeta.TabIndex = 11;
            this.jButComprarTarjeta.Text = "Comprar";
            this.jButComprarTarjeta.UseVisualStyleBackColor = false;
            this.jButComprarTarjeta.Click += new System.EventHandler(this.jButComprarTarjeta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Tarjeta";
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(292, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 50);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CVC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Caducidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número de tarjeta";
            // 
            // jCaducidad
            // 
            this.jCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCaducidad.Location = new System.Drawing.Point(22, 291);
            this.jCaducidad.Margin = new System.Windows.Forms.Padding(2);
            this.jCaducidad.Mask = "00/00";
            this.jCaducidad.Name = "jCaducidad";
            this.jCaducidad.Size = new System.Drawing.Size(84, 23);
            this.jCaducidad.TabIndex = 6;
            // 
            // jCVC
            // 
            this.jCVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCVC.Location = new System.Drawing.Point(161, 291);
            this.jCVC.Margin = new System.Windows.Forms.Padding(2);
            this.jCVC.Mask = "000";
            this.jCVC.Name = "jCVC";
            this.jCVC.Size = new System.Drawing.Size(110, 23);
            this.jCVC.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.jCboMetodoPago);
            this.groupBox1.Controls.Add(this.jCboCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(319, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Método de pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cliente";
            // 
            // jCboMetodoPago
            // 
            this.jCboMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCboMetodoPago.FormattingEnabled = true;
            this.jCboMetodoPago.Location = new System.Drawing.Point(87, 80);
            this.jCboMetodoPago.Name = "jCboMetodoPago";
            this.jCboMetodoPago.Size = new System.Drawing.Size(214, 28);
            this.jCboMetodoPago.TabIndex = 13;
            // 
            // jCboCliente
            // 
            this.jCboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCboCliente.FormattingEnabled = true;
            this.jCboCliente.Location = new System.Drawing.Point(87, 148);
            this.jCboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.jCboCliente.Name = "jCboCliente";
            this.jCboCliente.Size = new System.Drawing.Size(214, 28);
            this.jCboCliente.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total a Cobrar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cash";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 184);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cambio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jTxtComprarEfectivo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.jLblPrecioFinal);
            this.groupBox2.Controls.Add(this.jCambio);
            this.groupBox2.Controls.Add(this.jCash);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 259);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(319, 328);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cobro en Efectivo";
            // 
            // jTxtComprarEfectivo
            // 
            this.jTxtComprarEfectivo.BackColor = System.Drawing.Color.White;
            this.jTxtComprarEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtComprarEfectivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jTxtComprarEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("jTxtComprarEfectivo.Image")));
            this.jTxtComprarEfectivo.Location = new System.Drawing.Point(41, 265);
            this.jTxtComprarEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.jTxtComprarEfectivo.Name = "jTxtComprarEfectivo";
            this.jTxtComprarEfectivo.Size = new System.Drawing.Size(239, 43);
            this.jTxtComprarEfectivo.TabIndex = 13;
            this.jTxtComprarEfectivo.Text = "Comprar";
            this.jTxtComprarEfectivo.UseVisualStyleBackColor = false;
            this.jTxtComprarEfectivo.Click += new System.EventHandler(this.jTxtComprarEfectivo_Click);
            // 
            // jLblPrecioFinal
            // 
            this.jLblPrecioFinal.AutoSize = true;
            this.jLblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jLblPrecioFinal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.jLblPrecioFinal.Location = new System.Drawing.Point(83, 67);
            this.jLblPrecioFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jLblPrecioFinal.Name = "jLblPrecioFinal";
            this.jLblPrecioFinal.Size = new System.Drawing.Size(109, 24);
            this.jLblPrecioFinal.TabIndex = 11;
            this.jLblPrecioFinal.Text = "₡ 35,580.00";
            // 
            // jCambio
            // 
            this.jCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCambio.Location = new System.Drawing.Point(41, 219);
            this.jCambio.Margin = new System.Windows.Forms.Padding(2);
            this.jCambio.Mask = "000000";
            this.jCambio.Name = "jCambio";
            this.jCambio.Size = new System.Drawing.Size(110, 23);
            this.jCambio.TabIndex = 13;
            // 
            // jCash
            // 
            this.jCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jCash.Location = new System.Drawing.Point(41, 136);
            this.jCash.Margin = new System.Windows.Forms.Padding(2);
            this.jCash.Mask = "000000";
            this.jCash.Name = "jCash";
            this.jCash.Size = new System.Drawing.Size(110, 23);
            this.jCash.TabIndex = 12;
            this.jCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jCash_KeyDown);
            // 
            // label12
            // 
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(460, 490);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(399, 204);
            this.label12.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem,
            this.agregarClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 12;
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
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(620, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 762);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jDetallesPago);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UIPayment";
            this.Text = "UIInvoice";
            this.jDetallesPago.ResumeLayout(false);
            this.jDetallesPago.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox jNumTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox jDetallesPago;
        private System.Windows.Forms.MaskedTextBox jCaducidad;
        private System.Windows.Forms.MaskedTextBox jCVC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button jButComprarTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label jLblPrecioFinal;
        private System.Windows.Forms.MaskedTextBox jCambio;
        private System.Windows.Forms.MaskedTextBox jCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Button jTxtComprarEfectivo;
        private System.Windows.Forms.ComboBox jCboCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ComboBox jCboPagos;
        private System.Windows.Forms.ComboBox jCboMetodoPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}