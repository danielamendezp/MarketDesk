namespace ProyectoPromociones.UI
{
    partial class UIInvoiceCancelation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIInvoiceCancelation));
            this.jLstInvoice = new System.Windows.Forms.ListBox();
            this.jButCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jLstInvoice
            // 
            this.jLstInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jLstInvoice.FormattingEnabled = true;
            this.jLstInvoice.ItemHeight = 20;
            this.jLstInvoice.Location = new System.Drawing.Point(12, 66);
            this.jLstInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.jLstInvoice.Name = "jLstInvoice";
            this.jLstInvoice.Size = new System.Drawing.Size(830, 244);
            this.jLstInvoice.TabIndex = 1;
            // 
            // jButCancelar
            // 
            this.jButCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jButCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jButCancelar.Image = ((System.Drawing.Image)(resources.GetObject("jButCancelar.Image")));
            this.jButCancelar.Location = new System.Drawing.Point(667, 335);
            this.jButCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.jButCancelar.Name = "jButCancelar";
            this.jButCancelar.Size = new System.Drawing.Size(175, 50);
            this.jButCancelar.TabIndex = 2;
            this.jButCancelar.Text = "Cancelar";
            this.jButCancelar.UseVisualStyleBackColor = true;
            this.jButCancelar.Click += new System.EventHandler(this.jButCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de Factura";
            // 
            // UIInvoiceCancelation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jButCancelar);
            this.Controls.Add(this.jLstInvoice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UIInvoiceCancelation";
            this.Text = "UIInvoiceCancelation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox jLstInvoice;
        private System.Windows.Forms.Button jButCancelar;
        private System.Windows.Forms.Label label4;
    }
}