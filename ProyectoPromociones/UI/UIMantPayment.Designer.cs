namespace ProyectoPromociones.UI
{
    partial class UIMantPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMantPayment));
            this.jButEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jTxtName = new System.Windows.Forms.TextBox();
            this.jTxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jButCreate = new System.Windows.Forms.Button();
            this.jButUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButEliminar.Location = new System.Drawing.Point(309, 262);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(106, 42);
            this.jButEliminar.TabIndex = 33;
            this.jButEliminar.Text = "Eliminar";
            this.jButEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButEliminar.UseVisualStyleBackColor = true;
            this.jButEliminar.Click += new System.EventHandler(this.jButEliminar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jTxtName);
            this.groupBox1.Controls.Add(this.jTxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 224);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Pagos";
            // 
            // jTxtName
            // 
            this.jTxtName.Location = new System.Drawing.Point(153, 148);
            this.jTxtName.Name = "jTxtName";
            this.jTxtName.Size = new System.Drawing.Size(186, 22);
            this.jTxtName.TabIndex = 4;
            this.jTxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtName_KeyDown_1);
            // 
            // jTxtId
            // 
            this.jTxtId.Location = new System.Drawing.Point(153, 76);
            this.jTxtId.Name = "jTxtId";
            this.jTxtId.Size = new System.Drawing.Size(186, 22);
            this.jTxtId.TabIndex = 3;
            this.jTxtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtId_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consecutivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Tarjeta";
            // 
            // jButCreate
            // 
            this.jButCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButCreate.Image = ((System.Drawing.Image)(resources.GetObject("jButCreate.Image")));
            this.jButCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButCreate.Location = new System.Drawing.Point(7, 260);
            this.jButCreate.Name = "jButCreate";
            this.jButCreate.Size = new System.Drawing.Size(106, 43);
            this.jButCreate.TabIndex = 32;
            this.jButCreate.Text = "Crear";
            this.jButCreate.UseVisualStyleBackColor = true;
            this.jButCreate.Click += new System.EventHandler(this.jButCreate_Click);
            // 
            // jButUpdate
            // 
            this.jButUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButUpdate.Image = ((System.Drawing.Image)(resources.GetObject("jButUpdate.Image")));
            this.jButUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButUpdate.Location = new System.Drawing.Point(153, 260);
            this.jButUpdate.Name = "jButUpdate";
            this.jButUpdate.Size = new System.Drawing.Size(106, 44);
            this.jButUpdate.TabIndex = 31;
            this.jButUpdate.Text = "Actualizar";
            this.jButUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButUpdate.UseVisualStyleBackColor = true;
            this.jButUpdate.Click += new System.EventHandler(this.jButUpdate_Click_1);
            // 
            // UIMantPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 333);
            this.Controls.Add(this.jButEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jButCreate);
            this.Controls.Add(this.jButUpdate);
            this.Name = "UIMantPayment";
            this.Text = "UIMantPayment";
            this.Load += new System.EventHandler(this.UIMantPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jTxtName;
        private System.Windows.Forms.TextBox jTxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button jButCreate;
        private System.Windows.Forms.Button jButUpdate;
    }
}