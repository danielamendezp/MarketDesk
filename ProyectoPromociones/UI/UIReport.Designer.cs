namespace ProyectoPromociones.UI
{
    partial class UIReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.promotionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPromo = new ProyectoPromociones.UI.DataSetPromo();
            this.PromotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionTableAdapter = new ProyectoPromociones.UI.DataSetPromoTableAdapters.PromotionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPromoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPromosV3";
            reportDataSource1.Value = this.promotionBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoPromociones.UI.ReportPROMOSV3.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1508, 564);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1296, 57);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 1;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(1296, 97);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 2;
            this.dateTimePicker4.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1421, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // promotionBindingSource1
            // 
            this.promotionBindingSource1.DataMember = "Promotion";
            this.promotionBindingSource1.DataSource = this.dataSetPromoBindingSource;
            // 
            // dataSetPromoBindingSource
            // 
            this.dataSetPromoBindingSource.DataSource = this.dataSetPromo;
            this.dataSetPromoBindingSource.Position = 0;
            this.dataSetPromoBindingSource.CurrentChanged += new System.EventHandler(this.dataSetPromoBindingSource_CurrentChanged);
            // 
            // dataSetPromo
            // 
            this.dataSetPromo.DataSetName = "DataSetPromo";
            this.dataSetPromo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PromotionBindingSource
            // 
            this.PromotionBindingSource.DataMember = "Promotion";
            this.PromotionBindingSource.DataSource = this.dataSetPromo;
            // 
            // promotionTableAdapter
            // 
            this.promotionTableAdapter.ClearBeforeFill = true;
            // 
            // UIReport
            // 
            this.ClientSize = new System.Drawing.Size(1508, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.reportViewer2);
            this.Name = "UIReport";
            this.Load += new System.EventHandler(this.UIReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPromoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PromotionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetPromociones dataSetPromociones;
        private System.Windows.Forms.BindingSource dataSetPromocionesBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DataSetPromociones dataSetPromociones1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource dataSetVentasBindingSource;
        private DataSetVentas dataSetVentas;
        private System.Windows.Forms.BindingSource dataSetVentasBindingSource1;
        private System.Windows.Forms.BindingSource dataSetPromocionesBindingSource1;
        private System.Windows.Forms.BindingSource dataSetPromocionesBindingSource2;
        private System.Windows.Forms.BindingSource dataSetPromocionesBindingSource3;
        private System.Windows.Forms.BindingSource DetailBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DataSetPromo dataSetPromo;
        private System.Windows.Forms.BindingSource dataSetPromoBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource PromotionBindingSource;
        private System.Windows.Forms.BindingSource promotionBindingSource1;
        private DataSetPromoTableAdapters.PromotionTableAdapter promotionTableAdapter;
    }
}