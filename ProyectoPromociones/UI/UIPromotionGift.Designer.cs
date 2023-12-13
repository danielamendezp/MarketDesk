namespace ProyectoPromociones.UI
{
    partial class UIPromotionGift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPromotionGift));
            this.label2 = new System.Windows.Forms.Label();
            this.jButAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jNumRegalo = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jCboProductoRegalo = new System.Windows.Forms.ComboBox();
            this.jDescripcionOferta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jCantPromocion = new System.Windows.Forms.NumericUpDown();
            this.jCboProductosPromocion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.jFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.jButActualizar = new System.Windows.Forms.Button();
            this.jButEliminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jNumRegalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCantPromocion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 17;
            // 
            // jButAgregar
            // 
            this.jButAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButAgregar.Image = ((System.Drawing.Image)(resources.GetObject("jButAgregar.Image")));
            this.jButAgregar.Location = new System.Drawing.Point(712, 518);
            this.jButAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.jButAgregar.Name = "jButAgregar";
            this.jButAgregar.Size = new System.Drawing.Size(149, 53);
            this.jButAgregar.TabIndex = 16;
            this.jButAgregar.Text = "Agregar";
            this.jButAgregar.UseVisualStyleBackColor = true;
            this.jButAgregar.Click += new System.EventHandler(this.jButAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.jNumRegalo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.jCboProductoRegalo);
            this.groupBox1.Controls.Add(this.jDescripcionOferta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.jCantPromocion);
            this.groupBox1.Controls.Add(this.jCboProductosPromocion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jFechaInicio);
            this.groupBox1.Controls.Add(this.jFechaFinal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(622, 530);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos para promociones con regalos";
            // 
            // jNumRegalo
            // 
            this.jNumRegalo.Location = new System.Drawing.Point(273, 404);
            this.jNumRegalo.Margin = new System.Windows.Forms.Padding(2);
            this.jNumRegalo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jNumRegalo.Name = "jNumRegalo";
            this.jNumRegalo.Size = new System.Drawing.Size(90, 24);
            this.jNumRegalo.TabIndex = 20;
            this.jNumRegalo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seleccione la cantidad del regalo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seleccione el producto de regalo";
            // 
            // jCboProductoRegalo
            // 
            this.jCboProductoRegalo.FormattingEnabled = true;
            this.jCboProductoRegalo.Location = new System.Drawing.Point(273, 337);
            this.jCboProductoRegalo.Margin = new System.Windows.Forms.Padding(2);
            this.jCboProductoRegalo.Name = "jCboProductoRegalo";
            this.jCboProductoRegalo.Size = new System.Drawing.Size(264, 25);
            this.jCboProductoRegalo.TabIndex = 17;
            // 
            // jDescripcionOferta
            // 
            this.jDescripcionOferta.Location = new System.Drawing.Point(273, 474);
            this.jDescripcionOferta.Margin = new System.Windows.Forms.Padding(2);
            this.jDescripcionOferta.Name = "jDescripcionOferta";
            this.jDescripcionOferta.Size = new System.Drawing.Size(264, 24);
            this.jDescripcionOferta.TabIndex = 16;
            this.jDescripcionOferta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jDescripcionOferta_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 479);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Describa la oferta";
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
            // jCantPromocion
            // 
            this.jCantPromocion.Location = new System.Drawing.Point(273, 257);
            this.jCantPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.jCantPromocion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jCantPromocion.Name = "jCantPromocion";
            this.jCantPromocion.Size = new System.Drawing.Size(90, 24);
            this.jCantPromocion.TabIndex = 11;
            this.jCantPromocion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // jCboProductosPromocion
            // 
            this.jCboProductosPromocion.FormattingEnabled = true;
            this.jCboProductosPromocion.Location = new System.Drawing.Point(273, 191);
            this.jCboProductosPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.jCboProductosPromocion.Name = "jCboProductosPromocion";
            this.jCboProductosPromocion.Size = new System.Drawing.Size(264, 25);
            this.jCboProductosPromocion.TabIndex = 9;
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
            // jButActualizar
            // 
            this.jButActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButActualizar.Image = ((System.Drawing.Image)(resources.GetObject("jButActualizar.Image")));
            this.jButActualizar.Location = new System.Drawing.Point(712, 443);
            this.jButActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.jButActualizar.Name = "jButActualizar";
            this.jButActualizar.Size = new System.Drawing.Size(149, 53);
            this.jButActualizar.TabIndex = 19;
            this.jButActualizar.Text = "Actualizar";
            this.jButActualizar.UseVisualStyleBackColor = true;
            this.jButActualizar.Click += new System.EventHandler(this.jButActualizar_Click);
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.Location = new System.Drawing.Point(712, 361);
            this.jButEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(149, 53);
            this.jButEliminar.TabIndex = 20;
            this.jButEliminar.Text = "Eliminar";
            this.jButEliminar.UseVisualStyleBackColor = true;
            this.jButEliminar.Click += new System.EventHandler(this.jButEliminar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 635);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jButEliminar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.jButActualizar);
            this.tabPage1.Controls.Add(this.jButAgregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Promociones con Regalo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha de Inicio";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(884, 544);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UIPromotionGift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIPromotionGift";
            this.Text = "UIPromotionGift";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jNumRegalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jCantPromocion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jButAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jDescripcionOferta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown jCantPromocion;
        private System.Windows.Forms.ComboBox jCboProductosPromocion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker jFechaInicio;
        private System.Windows.Forms.DateTimePicker jFechaFinal;
        private System.Windows.Forms.NumericUpDown jNumRegalo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox jCboProductoRegalo;
        private System.Windows.Forms.Button jButActualizar;
        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
    }
}