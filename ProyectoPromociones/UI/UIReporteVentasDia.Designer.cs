namespace ProyectoPromociones.UI
{
    partial class UIReporteVentasDia
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
            this.dataSetVentasTotalsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasTotalsd = new ProyectoPromociones.UI.DataSetVentasTotalsd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetVentasTotalsdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasTotalsdBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasTotalsdBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVentasTotalsdBindingSource
            // 
            this.dataSetVentasTotalsdBindingSource.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource.Position = 0;
            // 
            // dataSetVentasTotalsd
            // 
            this.dataSetVentasTotalsd.DataSetName = "DataSetVentasTotalsd";
            this.dataSetVentasTotalsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.productBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPromociones.UI.ReportVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1322, 584);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetVentasTotalsdBindingSource1
            // 
            this.dataSetVentasTotalsdBindingSource1.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource1.Position = 0;
            // 
            // dataSetVentasTotalsdBindingSource2
            // 
            this.dataSetVentasTotalsdBindingSource2.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource2.Position = 0;
            // 
            // dataSetVentasTotalsdBindingSource3
            // 
            this.dataSetVentasTotalsdBindingSource3.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource3.Position = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProyectoPromociones.Entities.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // UIReporteVentasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 584);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UIReporteVentasDia";
            this.Text = "UIReporteVentasDia";
            this.Load += new System.EventHandler(this.UIReporteVentasDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource;
        private DataSetVentasTotalsd dataSetVentasTotalsd;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource2;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource3;
    }
}