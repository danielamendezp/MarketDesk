namespace ProyectoPromociones.UI
{
    partial class UIBusiness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIBusiness));
            this.Lista = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jTxtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jMskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.jTxtMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jMskIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.jTxtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.Label();
            this.jCboDistrito = new System.Windows.Forms.ComboBox();
            this.jCboCanton = new System.Windows.Forms.ComboBox();
            this.jCboProvincia = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.jButCreate = new System.Windows.Forms.Button();
            this.jButUpdate = new System.Windows.Forms.Button();
            this.jButEliminar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Lista.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.tabPage1);
            this.Lista.Controls.Add(this.tabPage2);
            this.Lista.Controls.Add(this.tabPage3);
            this.Lista.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.Location = new System.Drawing.Point(72, 80);
            this.Lista.Name = "Lista";
            this.Lista.SelectedIndex = 0;
            this.Lista.Size = new System.Drawing.Size(647, 297);
            this.Lista.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.jTxtCorreo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.jMskTelefono);
            this.tabPage1.Controls.Add(this.jTxtMessage);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.jTxtNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.jMskIdentificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(639, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(592, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(380, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 193);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // jTxtCorreo
            // 
            this.jTxtCorreo.Location = new System.Drawing.Point(147, 185);
            this.jTxtCorreo.Name = "jTxtCorreo";
            this.jTxtCorreo.Size = new System.Drawing.Size(200, 24);
            this.jTxtCorreo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Correo Electrónico";
            // 
            // jMskTelefono
            // 
            this.jMskTelefono.Location = new System.Drawing.Point(147, 131);
            this.jMskTelefono.Mask = "0000-0000";
            this.jMskTelefono.Name = "jMskTelefono";
            this.jMskTelefono.Size = new System.Drawing.Size(200, 24);
            this.jMskTelefono.TabIndex = 11;
            // 
            // jTxtMessage
            // 
            this.jTxtMessage.Location = new System.Drawing.Point(147, 238);
            this.jTxtMessage.Name = "jTxtMessage";
            this.jTxtMessage.Size = new System.Drawing.Size(200, 24);
            this.jTxtMessage.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mensaje Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa";
            // 
            // jTxtNombre
            // 
            this.jTxtNombre.Location = new System.Drawing.Point(147, 24);
            this.jTxtNombre.Name = "jTxtNombre";
            this.jTxtNombre.Size = new System.Drawing.Size(200, 24);
            this.jTxtNombre.TabIndex = 2;
            this.jTxtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula Jurídica";
            // 
            // jMskIdentificacion
            // 
            this.jMskIdentificacion.Location = new System.Drawing.Point(147, 78);
            this.jMskIdentificacion.Mask = "0-0000-0000";
            this.jMskIdentificacion.Name = "jMskIdentificacion";
            this.jMskIdentificacion.Size = new System.Drawing.Size(200, 24);
            this.jMskIdentificacion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.jTxtDescription);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Provincia);
            this.tabPage2.Controls.Add(this.jCboDistrito);
            this.tabPage2.Controls.Add(this.jCboCanton);
            this.tabPage2.Controls.Add(this.jCboProvincia);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(639, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dirección";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // jTxtDescription
            // 
            this.jTxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtDescription.Location = new System.Drawing.Point(266, 230);
            this.jTxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.jTxtDescription.Name = "jTxtDescription";
            this.jTxtDescription.Size = new System.Drawing.Size(162, 23);
            this.jTxtDescription.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Señas";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(333, 289);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(202, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Señas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Distrito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantón";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.Location = new System.Drawing.Point(160, 69);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(63, 16);
            this.Provincia.TabIndex = 3;
            this.Provincia.Text = "Provincia";
            // 
            // jCboDistrito
            // 
            this.jCboDistrito.FormattingEnabled = true;
            this.jCboDistrito.Location = new System.Drawing.Point(266, 178);
            this.jCboDistrito.Name = "jCboDistrito";
            this.jCboDistrito.Size = new System.Drawing.Size(162, 24);
            this.jCboDistrito.TabIndex = 2;
            // 
            // jCboCanton
            // 
            this.jCboCanton.FormattingEnabled = true;
            this.jCboCanton.Location = new System.Drawing.Point(266, 122);
            this.jCboCanton.Name = "jCboCanton";
            this.jCboCanton.Size = new System.Drawing.Size(162, 24);
            this.jCboCanton.TabIndex = 1;
            this.jCboCanton.SelectedIndexChanged += new System.EventHandler(this.jCboCanton_SelectedIndexChanged);
            // 
            // jCboProvincia
            // 
            this.jCboProvincia.FormattingEnabled = true;
            this.jCboProvincia.Location = new System.Drawing.Point(266, 69);
            this.jCboProvincia.Name = "jCboProvincia";
            this.jCboProvincia.Size = new System.Drawing.Size(162, 24);
            this.jCboProvincia.TabIndex = 0;
            this.jCboProvincia.SelectedIndexChanged += new System.EventHandler(this.jCboProvincia_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(639, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Empresa";
            // 
            // jButCreate
            // 
            this.jButCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButCreate.Image = ((System.Drawing.Image)(resources.GetObject("jButCreate.Image")));
            this.jButCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButCreate.Location = new System.Drawing.Point(119, 403);
            this.jButCreate.Name = "jButCreate";
            this.jButCreate.Size = new System.Drawing.Size(102, 44);
            this.jButCreate.TabIndex = 14;
            this.jButCreate.Text = "Crear";
            this.jButCreate.UseVisualStyleBackColor = true;
            this.jButCreate.Click += new System.EventHandler(this.jButCreate_Click);
            // 
            // jButUpdate
            // 
            this.jButUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButUpdate.Image = ((System.Drawing.Image)(resources.GetObject("jButUpdate.Image")));
            this.jButUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButUpdate.Location = new System.Drawing.Point(330, 403);
            this.jButUpdate.Name = "jButUpdate";
            this.jButUpdate.Size = new System.Drawing.Size(102, 44);
            this.jButUpdate.TabIndex = 13;
            this.jButUpdate.Text = "Actualizar";
            this.jButUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButUpdate.UseVisualStyleBackColor = true;
            this.jButUpdate.Click += new System.EventHandler(this.jButUpdate_Click);
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButEliminar.Location = new System.Drawing.Point(549, 403);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(102, 44);
            this.jButEliminar.TabIndex = 15;
            this.jButEliminar.Text = "Eliminar";
            this.jButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButEliminar.UseVisualStyleBackColor = true;
            this.jButEliminar.Click += new System.EventHandler(this.jButEliminar_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(27, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 194);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UIBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 479);
            this.Controls.Add(this.jButEliminar);
            this.Controls.Add(this.jButCreate);
            this.Controls.Add(this.jButUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lista);
            this.Name = "UIBusiness";
            this.Text = "UIBusiness";
            this.Lista.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Lista;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox jTxtMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox jMskIdentificacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Provincia;
        private System.Windows.Forms.ComboBox jCboDistrito;
        private System.Windows.Forms.ComboBox jCboCanton;
        private System.Windows.Forms.ComboBox jCboProvincia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox jTxtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox jMskTelefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button jButCreate;
        private System.Windows.Forms.Button jButUpdate;
        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox jTxtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
    }
}