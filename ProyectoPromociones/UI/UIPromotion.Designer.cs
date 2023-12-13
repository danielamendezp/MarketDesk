namespace ProyectoPromociones.UI
{
    partial class UIPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPromotion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.promo1 = new System.Windows.Forms.CheckBox();
            this.promo2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.promo4 = new System.Windows.Forms.CheckBox();
            this.promo3 = new System.Windows.Forms.CheckBox();
            this.jButFacturar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.jTxtsubTotal = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jTablaTotales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.jTxtDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jTxtTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTablaTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // promo1
            // 
            this.promo1.AutoSize = true;
            this.promo1.Location = new System.Drawing.Point(25, 48);
            this.promo1.Margin = new System.Windows.Forms.Padding(2);
            this.promo1.Name = "promo1";
            this.promo1.Size = new System.Drawing.Size(407, 22);
            this.promo1.TabIndex = 1;
            this.promo1.Text = "Por la compra de 2 productos el tercero a mitad de precio";
            this.promo1.UseVisualStyleBackColor = true;
            this.promo1.CheckedChanged += new System.EventHandler(this.chkBoxProductDiscount_CheckedChanged);
            // 
            // promo2
            // 
            this.promo2.AutoSize = true;
            this.promo2.Location = new System.Drawing.Point(25, 92);
            this.promo2.Margin = new System.Windows.Forms.Padding(2);
            this.promo2.Name = "promo2";
            this.promo2.Size = new System.Drawing.Size(366, 22);
            this.promo2.TabIndex = 2;
            this.promo2.Text = "Por compras mayores a 50.000, 15% de descuento";
            this.promo2.UseVisualStyleBackColor = true;
            this.promo2.CheckedChanged += new System.EventHandler(this.chkBoxPromotionDiscount_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.promo1);
            this.groupBox1.Controls.Add(this.promo4);
            this.groupBox1.Controls.Add(this.promo2);
            this.groupBox1.Controls.Add(this.promo3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(687, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(783, 229);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promociones";
            // 
            // promo4
            // 
            this.promo4.AutoSize = true;
            this.promo4.Location = new System.Drawing.Point(25, 184);
            this.promo4.Margin = new System.Windows.Forms.Padding(2);
            this.promo4.Name = "promo4";
            this.promo4.Size = new System.Drawing.Size(472, 22);
            this.promo4.TabIndex = 4;
            this.promo4.Text = "Por la compra de 2 ProductPromotion el segundo a mitad de precio";
            this.promo4.UseVisualStyleBackColor = true;
            this.promo4.CheckedChanged += new System.EventHandler(this.chkValueDiscount_CheckedChanged);
            // 
            // promo3
            // 
            this.promo3.AutoSize = true;
            this.promo3.Location = new System.Drawing.Point(25, 137);
            this.promo3.Margin = new System.Windows.Forms.Padding(2);
            this.promo3.Name = "promo3";
            this.promo3.Size = new System.Drawing.Size(397, 22);
            this.promo3.TabIndex = 3;
            this.promo3.Text = "Por la compra de 3 ProductPromotion te regalamos una";
            this.promo3.UseVisualStyleBackColor = true;
            this.promo3.CheckedChanged += new System.EventHandler(this.PromotionGift_CheckedChanged);
            // 
            // jButFacturar
            // 
            this.jButFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButFacturar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.jButFacturar.Image = ((System.Drawing.Image)(resources.GetObject("jButFacturar.Image")));
            this.jButFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButFacturar.Location = new System.Drawing.Point(1332, 623);
            this.jButFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.jButFacturar.Name = "jButFacturar";
            this.jButFacturar.Size = new System.Drawing.Size(138, 58);
            this.jButFacturar.TabIndex = 7;
            this.jButFacturar.Text = "Facturar";
            this.jButFacturar.UseVisualStyleBackColor = true;
            this.jButFacturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "SubTotal";
            // 
            // jTxtsubTotal
            // 
            this.jTxtsubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtsubTotal.Location = new System.Drawing.Point(489, 569);
            this.jTxtsubTotal.Name = "jTxtsubTotal";
            this.jTxtsubTotal.Size = new System.Drawing.Size(171, 24);
            this.jTxtsubTotal.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1492, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("regresarToolStripMenuItem.Image")));
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // jTablaTotales
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.jTablaTotales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jTablaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jTablaTotales.Location = new System.Drawing.Point(12, 54);
            this.jTablaTotales.Name = "jTablaTotales";
            this.jTablaTotales.RowHeadersWidth = 51;
            this.jTablaTotales.Size = new System.Drawing.Size(648, 481);
            this.jTablaTotales.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Descuento";
            // 
            // jTxtDescuento
            // 
            this.jTxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtDescuento.Location = new System.Drawing.Point(489, 608);
            this.jTxtDescuento.Name = "jTxtDescuento";
            this.jTxtDescuento.Size = new System.Drawing.Size(171, 24);
            this.jTxtDescuento.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total";
            // 
            // jTxtTotal
            // 
            this.jTxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtTotal.Location = new System.Drawing.Point(489, 652);
            this.jTxtTotal.Name = "jTxtTotal";
            this.jTxtTotal.Size = new System.Drawing.Size(171, 24);
            this.jTxtTotal.TabIndex = 19;
            // 
            // UIPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jTxtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jTxtDescuento);
            this.Controls.Add(this.jTablaTotales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jTxtsubTotal);
            this.Controls.Add(this.jButFacturar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIPromotion";
            this.Text = "UIPromotion";
            this.Load += new System.EventHandler(this.UIPromotion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jTablaTotales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox promo1;
        private System.Windows.Forms.CheckBox promo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button jButFacturar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox jTxtsubTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.DataGridView jTablaTotales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jTxtDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jTxtTotal;
        private System.Windows.Forms.CheckBox promo4;
        private System.Windows.Forms.CheckBox promo3;
    }
}