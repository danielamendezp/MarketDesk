namespace ProyectoPromociones.UI
{
    partial class UIUpdatePromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIUpdatePromotion));
            this.Lista = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.jButEliminar = new System.Windows.Forms.Button();
            this.jButActualizar = new System.Windows.Forms.Button();
            this.jAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.jMontoCompra = new System.Windows.Forms.MaskedTextBox();
            this.jDescripcionOferta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jDescuento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jNumCantidad = new System.Windows.Forms.NumericUpDown();
            this.jCboProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.jFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Lista.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jNumCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.tabPage2);
            this.Lista.Controls.Add(this.tabPage1);
            this.Lista.Location = new System.Drawing.Point(32, 23);
            this.Lista.Name = "Lista";
            this.Lista.SelectedIndex = 0;
            this.Lista.Size = new System.Drawing.Size(933, 644);
            this.Lista.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jButEliminar);
            this.tabPage1.Controls.Add(this.jButActualizar);
            this.tabPage1.Controls.Add(this.jAgregar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Promociones con Descuento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.Location = new System.Drawing.Point(709, 355);
            this.jButEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(149, 53);
            this.jButEliminar.TabIndex = 26;
            this.jButEliminar.Text = "Eliminar";
            this.jButEliminar.UseVisualStyleBackColor = true;
            this.jButEliminar.Click += new System.EventHandler(this.jButEliminar_Click_1);
            // 
            // jButActualizar
            // 
            this.jButActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButActualizar.Image = ((System.Drawing.Image)(resources.GetObject("jButActualizar.Image")));
            this.jButActualizar.Location = new System.Drawing.Point(709, 434);
            this.jButActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.jButActualizar.Name = "jButActualizar";
            this.jButActualizar.Size = new System.Drawing.Size(149, 53);
            this.jButActualizar.TabIndex = 25;
            this.jButActualizar.Text = "Actualizar";
            this.jButActualizar.UseVisualStyleBackColor = true;
            this.jButActualizar.Click += new System.EventHandler(this.jButActualizar_Click_1);
            // 
            // jAgregar
            // 
            this.jAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jAgregar.Image = ((System.Drawing.Image)(resources.GetObject("jAgregar.Image")));
            this.jAgregar.Location = new System.Drawing.Point(709, 509);
            this.jAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.jAgregar.Name = "jAgregar";
            this.jAgregar.Size = new System.Drawing.Size(149, 53);
            this.jAgregar.TabIndex = 23;
            this.jAgregar.Text = "Agregar";
            this.jAgregar.UseVisualStyleBackColor = true;
            this.jAgregar.Click += new System.EventHandler(this.jAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.jMontoCompra);
            this.groupBox1.Controls.Add(this.jDescripcionOferta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.jDescuento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.jNumCantidad);
            this.groupBox1.Controls.Add(this.jCboProductos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jFechaInicio);
            this.groupBox1.Controls.Add(this.jFechaFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(622, 505);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para promociones con descuentos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Digite el monto de la compra";
            // 
            // jMontoCompra
            // 
            this.jMontoCompra.Location = new System.Drawing.Point(273, 396);
            this.jMontoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.jMontoCompra.Mask = "$00000";
            this.jMontoCompra.Name = "jMontoCompra";
            this.jMontoCompra.Size = new System.Drawing.Size(76, 24);
            this.jMontoCompra.TabIndex = 17;
            // 
            // jDescripcionOferta
            // 
            this.jDescripcionOferta.Location = new System.Drawing.Point(273, 462);
            this.jDescripcionOferta.Margin = new System.Windows.Forms.Padding(2);
            this.jDescripcionOferta.Name = "jDescripcionOferta";
            this.jDescripcionOferta.Size = new System.Drawing.Size(264, 24);
            this.jDescripcionOferta.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 465);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Describa la oferta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Digite la cantidad de descuento";
            // 
            // jDescuento
            // 
            this.jDescuento.Location = new System.Drawing.Point(273, 328);
            this.jDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.jDescuento.Mask = "00%";
            this.jDescuento.Name = "jDescuento";
            this.jDescuento.Size = new System.Drawing.Size(76, 24);
            this.jDescuento.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el producto en promoción:";
            // 
            // jNumCantidad
            // 
            this.jNumCantidad.Location = new System.Drawing.Point(273, 257);
            this.jNumCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.jNumCantidad.Name = "jNumCantidad";
            this.jNumCantidad.Size = new System.Drawing.Size(90, 24);
            this.jNumCantidad.TabIndex = 11;
            // 
            // jCboProductos
            // 
            this.jCboProductos.FormattingEnabled = true;
            this.jCboProductos.Location = new System.Drawing.Point(273, 191);
            this.jCboProductos.Margin = new System.Windows.Forms.Padding(2);
            this.jCboProductos.Name = "jCboProductos";
            this.jCboProductos.Size = new System.Drawing.Size(264, 25);
            this.jCboProductos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha de Finalización";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seleccione la cantidad en promoción:";
            // 
            // jFechaInicio
            // 
            this.jFechaInicio.Location = new System.Drawing.Point(273, 58);
            this.jFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.jFechaInicio.Name = "jFechaInicio";
            this.jFechaInicio.Size = new System.Drawing.Size(264, 24);
            this.jFechaInicio.TabIndex = 1;
            // 
            // jFechaFinal
            // 
            this.jFechaFinal.Location = new System.Drawing.Point(273, 128);
            this.jFechaFinal.Margin = new System.Windows.Forms.Padding(2);
            this.jFechaFinal.Name = "jFechaFinal";
            this.jFechaFinal.Size = new System.Drawing.Size(264, 24);
            this.jFechaFinal.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(27, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(866, 544);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UIUpdatePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 679);
            this.Controls.Add(this.Lista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIUpdatePromotion";
            this.Text = "UIUpdatePromotion";
            this.Lista.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jNumCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Lista;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.Button jButActualizar;
        private System.Windows.Forms.Button jAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox jMontoCompra;
        private System.Windows.Forms.TextBox jDescripcionOferta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox jDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown jNumCantidad;
        private System.Windows.Forms.ComboBox jCboProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker jFechaInicio;
        private System.Windows.Forms.DateTimePicker jFechaFinal;
        private System.Windows.Forms.ListBox listBox1;
    }
}