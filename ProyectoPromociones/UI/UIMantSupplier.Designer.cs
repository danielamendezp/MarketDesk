namespace ProyectoPromociones.UI
{
    partial class UIMantSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMantSupplier));
            this.jButEliminar = new System.Windows.Forms.Button();
            this.jButCreate = new System.Windows.Forms.Button();
            this.jButUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jTxtEmail = new System.Windows.Forms.TextBox();
            this.jMskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.jTxtNameSupplier = new System.Windows.Forms.TextBox();
            this.jTxtIdSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButEliminar.Location = new System.Drawing.Point(351, 393);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(106, 42);
            this.jButEliminar.TabIndex = 23;
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
            this.jButCreate.Location = new System.Drawing.Point(29, 393);
            this.jButCreate.Name = "jButCreate";
            this.jButCreate.Size = new System.Drawing.Size(106, 43);
            this.jButCreate.TabIndex = 22;
            this.jButCreate.Text = "Crear";
            this.jButCreate.UseVisualStyleBackColor = true;
            this.jButCreate.Click += new System.EventHandler(this.jButCreate_Click);
            // 
            // jButUpdate
            // 
            this.jButUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButUpdate.Image = ((System.Drawing.Image)(resources.GetObject("jButUpdate.Image")));
            this.jButUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButUpdate.Location = new System.Drawing.Point(184, 391);
            this.jButUpdate.Name = "jButUpdate";
            this.jButUpdate.Size = new System.Drawing.Size(106, 44);
            this.jButUpdate.TabIndex = 21;
            this.jButUpdate.Text = "Actualizar";
            this.jButUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButUpdate.UseVisualStyleBackColor = true;
            this.jButUpdate.Click += new System.EventHandler(this.jButUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jTxtEmail);
            this.groupBox1.Controls.Add(this.jMskPhoneNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.jTxtNameSupplier);
            this.groupBox1.Controls.Add(this.jTxtIdSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 331);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Proveedor";
            // 
            // jTxtEmail
            // 
            this.jTxtEmail.Location = new System.Drawing.Point(163, 285);
            this.jTxtEmail.Name = "jTxtEmail";
            this.jTxtEmail.Size = new System.Drawing.Size(186, 22);
            this.jTxtEmail.TabIndex = 8;
            // 
            // jMskPhoneNumber
            // 
            this.jMskPhoneNumber.Location = new System.Drawing.Point(163, 218);
            this.jMskPhoneNumber.Mask = "0000-0000";
            this.jMskPhoneNumber.Name = "jMskPhoneNumber";
            this.jMskPhoneNumber.Size = new System.Drawing.Size(186, 22);
            this.jMskPhoneNumber.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Correo Electrónico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Número Celular";
            // 
            // jTxtNameSupplier
            // 
            this.jTxtNameSupplier.Location = new System.Drawing.Point(163, 151);
            this.jTxtNameSupplier.Name = "jTxtNameSupplier";
            this.jTxtNameSupplier.Size = new System.Drawing.Size(186, 22);
            this.jTxtNameSupplier.TabIndex = 4;
            this.jTxtNameSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtNameSupplier_KeyDown);
            // 
            // jTxtIdSupplier
            // 
            this.jTxtIdSupplier.Location = new System.Drawing.Point(163, 76);
            this.jTxtIdSupplier.Name = "jTxtIdSupplier";
            this.jTxtIdSupplier.Size = new System.Drawing.Size(186, 22);
            this.jTxtIdSupplier.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consecutivo Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Proveedor";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(25, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(407, 238);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(495, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 331);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // UIMantSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.jButEliminar);
            this.Controls.Add(this.jButCreate);
            this.Controls.Add(this.jButUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "UIMantSupplier";
            this.Text = "UIMantSupplier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.Button jButCreate;
        private System.Windows.Forms.Button jButUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jTxtNameSupplier;
        private System.Windows.Forms.TextBox jTxtIdSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jTxtEmail;
        private System.Windows.Forms.MaskedTextBox jMskPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}