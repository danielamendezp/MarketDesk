namespace ProyectoPromociones.UI
{
    partial class UILoginUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILoginUsers));
            this.jButLogIn = new System.Windows.Forms.Button();
            this.jTxtPassword = new System.Windows.Forms.TextBox();
            this.jTxtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jButLogIn
            // 
            this.jButLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButLogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.jButLogIn.Image = ((System.Drawing.Image)(resources.GetObject("jButLogIn.Image")));
            this.jButLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jButLogIn.Location = new System.Drawing.Point(64, 383);
            this.jButLogIn.Name = "jButLogIn";
            this.jButLogIn.Size = new System.Drawing.Size(154, 54);
            this.jButLogIn.TabIndex = 25;
            this.jButLogIn.Text = "Log In";
            this.jButLogIn.UseVisualStyleBackColor = true;
            this.jButLogIn.Click += new System.EventHandler(this.jButLogIn_Click);
            // 
            // jTxtPassword
            // 
            this.jTxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtPassword.Location = new System.Drawing.Point(34, 308);
            this.jTxtPassword.Name = "jTxtPassword";
            this.jTxtPassword.Size = new System.Drawing.Size(204, 26);
            this.jTxtPassword.TabIndex = 22;
            this.jTxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtPassword_KeyDown);
            // 
            // jTxtUser
            // 
            this.jTxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jTxtUser.Location = new System.Drawing.Point(34, 207);
            this.jTxtUser.Name = "jTxtUser";
            this.jTxtUser.Size = new System.Drawing.Size(204, 26);
            this.jTxtUser.TabIndex = 20;
            this.jTxtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jTxtUser_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(62, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 128);
            this.label1.TabIndex = 13;
            // 
            // UILoginUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 456);
            this.Controls.Add(this.jButLogIn);
            this.Controls.Add(this.jTxtPassword);
            this.Controls.Add(this.jTxtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UILoginUsers";
            this.Text = "UILoginUsers";
            this.Load += new System.EventHandler(this.UILoginUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jButLogIn;
        private System.Windows.Forms.TextBox jTxtPassword;
        private System.Windows.Forms.TextBox jTxtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}