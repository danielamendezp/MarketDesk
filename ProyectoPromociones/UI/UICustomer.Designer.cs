namespace ProyectoPromociones.UI
{
    partial class UICustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UICustomer));
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.jTxtNacionality = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jButMasculine = new System.Windows.Forms.RadioButton();
            this.jButFemenine = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.jDateBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.jTxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jMskIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.jTxtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.Label();
            this.jCboDistrito = new System.Windows.Forms.ComboBox();
            this.jCboCanton = new System.Windows.Forms.ComboBox();
            this.jCboProvincia = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.jTxtEmail = new System.Windows.Forms.TextBox();
            this.jMskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.jButEliminar = new System.Windows.Forms.Button();
            this.jButCreate = new System.Windows.Forms.Button();
            this.jButUpdate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jButSubirFoto = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControlCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPage1);
            this.tabControlCliente.Controls.Add(this.tabPage2);
            this.tabControlCliente.Controls.Add(this.tabPage3);
            this.tabControlCliente.Controls.Add(this.tabPage4);
            this.tabControlCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCliente.Location = new System.Drawing.Point(12, 53);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(412, 298);
            this.tabControlCliente.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jTxtNacionality);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.jButMasculine);
            this.tabPage1.Controls.Add(this.jButFemenine);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.jDateBirth);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.jTxtNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.jMskIdentificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Generales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // jTxtNacionality
            // 
            this.jTxtNacionality.Location = new System.Drawing.Point(173, 232);
            this.jTxtNacionality.Name = "jTxtNacionality";
            this.jTxtNacionality.Size = new System.Drawing.Size(200, 22);
            this.jTxtNacionality.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nacionalidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Género";
            // 
            // jButMasculine
            // 
            this.jButMasculine.AutoSize = true;
            this.jButMasculine.Location = new System.Drawing.Point(265, 190);
            this.jButMasculine.Name = "jButMasculine";
            this.jButMasculine.Size = new System.Drawing.Size(86, 20);
            this.jButMasculine.TabIndex = 7;
            this.jButMasculine.TabStop = true;
            this.jButMasculine.Text = "Masculino";
            this.jButMasculine.UseVisualStyleBackColor = true;
            // 
            // jButFemenine
            // 
            this.jButFemenine.AutoSize = true;
            this.jButFemenine.Location = new System.Drawing.Point(173, 190);
            this.jButFemenine.Name = "jButFemenine";
            this.jButFemenine.Size = new System.Drawing.Size(85, 20);
            this.jButFemenine.TabIndex = 6;
            this.jButFemenine.TabStop = true;
            this.jButFemenine.Text = "Femenino";
            this.jButFemenine.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // jDateBirth
            // 
            this.jDateBirth.Location = new System.Drawing.Point(173, 137);
            this.jDateBirth.Name = "jDateBirth";
            this.jDateBirth.Size = new System.Drawing.Size(200, 22);
            this.jDateBirth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre y Apellidos";
            // 
            // jTxtNombre
            // 
            this.jTxtNombre.Location = new System.Drawing.Point(173, 27);
            this.jTxtNombre.Name = "jTxtNombre";
            this.jTxtNombre.Size = new System.Drawing.Size(200, 22);
            this.jTxtNombre.TabIndex = 2;
            this.jTxtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtNombre_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            // 
            // jMskIdentificacion
            // 
            this.jMskIdentificacion.Location = new System.Drawing.Point(173, 81);
            this.jMskIdentificacion.Mask = "0-0000-0000";
            this.jMskIdentificacion.Name = "jMskIdentificacion";
            this.jMskIdentificacion.Size = new System.Drawing.Size(200, 22);
            this.jMskIdentificacion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.jTxtDescription);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Provincia);
            this.tabPage2.Controls.Add(this.jCboDistrito);
            this.tabPage2.Controls.Add(this.jCboCanton);
            this.tabPage2.Controls.Add(this.jCboProvincia);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dirección";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // jTxtDescription
            // 
            this.jTxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtDescription.Location = new System.Drawing.Point(164, 235);
            this.jTxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.jTxtDescription.Name = "jTxtDescription";
            this.jTxtDescription.Size = new System.Drawing.Size(162, 23);
            this.jTxtDescription.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Señas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Distrito";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cantón";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.Location = new System.Drawing.Point(58, 69);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(63, 16);
            this.Provincia.TabIndex = 3;
            this.Provincia.Text = "Provincia";
            // 
            // jCboDistrito
            // 
            this.jCboDistrito.FormattingEnabled = true;
            this.jCboDistrito.Location = new System.Drawing.Point(164, 178);
            this.jCboDistrito.Name = "jCboDistrito";
            this.jCboDistrito.Size = new System.Drawing.Size(162, 24);
            this.jCboDistrito.TabIndex = 2;
            // 
            // jCboCanton
            // 
            this.jCboCanton.FormattingEnabled = true;
            this.jCboCanton.Location = new System.Drawing.Point(164, 122);
            this.jCboCanton.Name = "jCboCanton";
            this.jCboCanton.Size = new System.Drawing.Size(162, 24);
            this.jCboCanton.TabIndex = 1;
            this.jCboCanton.SelectedIndexChanged += new System.EventHandler(this.jCboCanton_SelectedIndexChanged);
            // 
            // jCboProvincia
            // 
            this.jCboProvincia.FormattingEnabled = true;
            this.jCboProvincia.Location = new System.Drawing.Point(164, 69);
            this.jCboProvincia.Name = "jCboProvincia";
            this.jCboProvincia.Size = new System.Drawing.Size(162, 24);
            this.jCboProvincia.TabIndex = 0;
            this.jCboProvincia.SelectedIndexChanged += new System.EventHandler(this.jCboProvincia_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.jTxtEmail);
            this.tabPage3.Controls.Add(this.jMskPhoneNumber);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(404, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contacto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // jTxtEmail
            // 
            this.jTxtEmail.Location = new System.Drawing.Point(164, 150);
            this.jTxtEmail.Name = "jTxtEmail";
            this.jTxtEmail.Size = new System.Drawing.Size(152, 22);
            this.jTxtEmail.TabIndex = 3;
            // 
            // jMskPhoneNumber
            // 
            this.jMskPhoneNumber.Location = new System.Drawing.Point(164, 88);
            this.jMskPhoneNumber.Mask = "0000-0000";
            this.jMskPhoneNumber.Name = "jMskPhoneNumber";
            this.jMskPhoneNumber.Size = new System.Drawing.Size(152, 22);
            this.jMskPhoneNumber.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Correo Electrónico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Número Celular";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(404, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lista";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButEliminar.Location = new System.Drawing.Point(314, 384);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(106, 42);
            this.jButEliminar.TabIndex = 26;
            this.jButEliminar.Text = "Eliminar";
            this.jButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButEliminar.UseVisualStyleBackColor = true;
            this.jButEliminar.Click += new System.EventHandler(this.jButEliminar_Click);
            // 
            // jButCreate
            // 
            this.jButCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButCreate.Image = ((System.Drawing.Image)(resources.GetObject("jButCreate.Image")));
            this.jButCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButCreate.Location = new System.Drawing.Point(12, 382);
            this.jButCreate.Name = "jButCreate";
            this.jButCreate.Size = new System.Drawing.Size(106, 43);
            this.jButCreate.TabIndex = 25;
            this.jButCreate.Text = "Crear";
            this.jButCreate.UseVisualStyleBackColor = true;
            this.jButCreate.Click += new System.EventHandler(this.jButCreate_Click);
            // 
            // jButUpdate
            // 
            this.jButUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButUpdate.Image = ((System.Drawing.Image)(resources.GetObject("jButUpdate.Image")));
            this.jButUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButUpdate.Location = new System.Drawing.Point(158, 382);
            this.jButUpdate.Name = "jButUpdate";
            this.jButUpdate.Size = new System.Drawing.Size(106, 44);
            this.jButUpdate.TabIndex = 24;
            this.jButUpdate.Text = "Actualizar";
            this.jButUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButUpdate.UseVisualStyleBackColor = true;
            this.jButUpdate.Click += new System.EventHandler(this.jButUpdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(437, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 226);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // jButSubirFoto
            // 
            this.jButSubirFoto.Image = ((System.Drawing.Image)(resources.GetObject("jButSubirFoto.Image")));
            this.jButSubirFoto.Location = new System.Drawing.Point(602, 313);
            this.jButSubirFoto.Name = "jButSubirFoto";
            this.jButSubirFoto.Size = new System.Drawing.Size(34, 35);
            this.jButSubirFoto.TabIndex = 33;
            this.jButSubirFoto.UseVisualStyleBackColor = true;
            this.jButSubirFoto.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(6, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 220);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UICustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 436);
            this.Controls.Add(this.jButSubirFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jButEliminar);
            this.Controls.Add(this.jButCreate);
            this.Controls.Add(this.jButUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlCliente);
            this.Name = "UICustomer";
            this.Text = "UICustomer";
            this.tabControlCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox jMskIdentificacion;
        private System.Windows.Forms.TextBox jTxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker jDateBirth;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton jButMasculine;
        private System.Windows.Forms.RadioButton jButFemenine;
        private System.Windows.Forms.TextBox jTxtNacionality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Provincia;
        private System.Windows.Forms.ComboBox jCboDistrito;
        private System.Windows.Forms.ComboBox jCboCanton;
        private System.Windows.Forms.ComboBox jCboProvincia;
        private System.Windows.Forms.TextBox jTxtEmail;
        private System.Windows.Forms.MaskedTextBox jMskPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.Button jButCreate;
        private System.Windows.Forms.Button jButUpdate;
        private System.Windows.Forms.TextBox jTxtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button jButSubirFoto;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBox1;
    }
}