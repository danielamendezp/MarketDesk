namespace ProyectoPromociones.UI
{
    partial class UIReportVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentas = new ProyectoPromociones.UI.DataSetVentas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new ProyectoPromociones.UI.DataSetVentasTableAdapters.DetailTableAdapter();
            this.detailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailBindingSource
            // 
            this.DetailBindingSource.DataMember = "Detail";
            this.DetailBindingSource.DataSource = this.dataSetVentas;
            // 
            // dataSetVentas
            // 
            this.dataSetVentas.DataSetName = "DataSetVentas";
            this.dataSetVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datasetdetail";
            reportDataSource1.Value = this.DetailBindingSource;
            reportDataSource2.Name = "DataSetVentas";
            reportDataSource2.Value = this.DetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPromociones.UI.ReporteVentaFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1084, 594);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetVentasBindingSource
            // 
            this.dataSetVentasBindingSource.DataSource = this.dataSetVentas;
            this.dataSetVentasBindingSource.Position = 0;
            this.dataSetVentasBindingSource.CurrentChanged += new System.EventHandler(this.dataSetVentasBindingSource_CurrentChanged);
            // 
            // detailBindingSource1
            // 
            this.detailBindingSource1.DataMember = "Detail";
            this.detailBindingSource1.DataSource = this.dataSetVentasBindingSource;
            this.detailBindingSource1.CurrentChanged += new System.EventHandler(this.detailBindingSource1_CurrentChanged);
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // detailBindingSource2
            // 
            this.detailBindingSource2.DataMember = "Detail";
            this.detailBindingSource2.DataSource = this.dataSetVentasBindingSource;
            // 
            // dataSetVentasBindingSource1
            // 
            this.dataSetVentasBindingSource1.DataSource = this.dataSetVentas;
            this.dataSetVentasBindingSource1.Position = 0;
            // 
            // dataSetVentasBindingSource2
            // 
            this.dataSetVentasBindingSource2.DataSource = this.dataSetVentas;
            this.dataSetVentasBindingSource2.Position = 0;
            // 
            // UIReportVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 594);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UIReportVentas";
            this.Text = "UIReportVentas";
            this.Load += new System.EventHandler(this.UIReportVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetVentasBindingSource;
        private DataSetVentas dataSetVentas;
        private System.Windows.Forms.BindingSource DetailBindingSource;
        private System.Windows.Forms.BindingSource detailBindingSource1;
        private DataSetVentasTableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.BindingSource detailBindingSource2;
        private System.Windows.Forms.BindingSource dataSetVentasBindingSource2;
        private System.Windows.Forms.BindingSource dataSetVentasBindingSource1;
    }
}