namespace ProyectoPromociones.UI
{
    partial class UIMantCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIMantCategory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jTxtNameCategory = new System.Windows.Forms.TextBox();
            this.jTxtIdCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jButEliminar = new System.Windows.Forms.Button();
            this.jButCreate = new System.Windows.Forms.Button();
            this.jButUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jTxtNameCategory);
            this.groupBox1.Controls.Add(this.jTxtIdCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Categoria ";
            // 
            // jTxtNameCategory
            // 
            this.jTxtNameCategory.Location = new System.Drawing.Point(153, 148);
            this.jTxtNameCategory.Name = "jTxtNameCategory";
            this.jTxtNameCategory.Size = new System.Drawing.Size(186, 22);
            this.jTxtNameCategory.TabIndex = 4;
            this.jTxtNameCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtNameCategory_KeyDown);
            // 
            // jTxtIdCategory
            // 
            this.jTxtIdCategory.Location = new System.Drawing.Point(153, 76);
            this.jTxtIdCategory.Name = "jTxtIdCategory";
            this.jTxtIdCategory.Size = new System.Drawing.Size(186, 22);
            this.jTxtIdCategory.TabIndex = 3;
            this.jTxtIdCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtIdCategory_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consecutivo Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Categoria";
            // 
            // jButEliminar
            // 
            this.jButEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("jButEliminar.Image")));
            this.jButEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButEliminar.Location = new System.Drawing.Point(305, 277);
            this.jButEliminar.Name = "jButEliminar";
            this.jButEliminar.Size = new System.Drawing.Size(106, 42);
            this.jButEliminar.TabIndex = 29;
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
            this.jButCreate.Location = new System.Drawing.Point(3, 275);
            this.jButCreate.Name = "jButCreate";
            this.jButCreate.Size = new System.Drawing.Size(106, 43);
            this.jButCreate.TabIndex = 28;
            this.jButCreate.Text = "Crear";
            this.jButCreate.UseVisualStyleBackColor = true;
            this.jButCreate.Click += new System.EventHandler(this.jButCreate_Click);
            // 
            // jButUpdate
            // 
            this.jButUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButUpdate.Image = ((System.Drawing.Image)(resources.GetObject("jButUpdate.Image")));
            this.jButUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButUpdate.Location = new System.Drawing.Point(149, 275);
            this.jButUpdate.Name = "jButUpdate";
            this.jButUpdate.Size = new System.Drawing.Size(106, 44);
            this.jButUpdate.TabIndex = 27;
            this.jButUpdate.Text = "Actualizar";
            this.jButUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jButUpdate.UseVisualStyleBackColor = true;
            this.jButUpdate.Click += new System.EventHandler(this.jButUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(427, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 224);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Categorias";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(6, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 184);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UIMantCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.jButEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jButCreate);
            this.Controls.Add(this.jButUpdate);
            this.Name = "UIMantCategory";
            this.Text = "UIMantCategory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jTxtNameCategory;
        private System.Windows.Forms.TextBox jTxtIdCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jButEliminar;
        private System.Windows.Forms.Button jButCreate;
        private System.Windows.Forms.Button jButUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}