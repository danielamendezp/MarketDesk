namespace ProyectoPromociones.UI
{
    partial class UIReporteVentasTotal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetVentasTotalsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVentasTotalsd = new ProyectoPromociones.UI.DataSetVentasTotalsd();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dataSetVentasTotalsdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.headerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetVentasTotalsdBindingSource
            // 
            this.dataSetVentasTotalsdBindingSource.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource.Position = 0;
            this.dataSetVentasTotalsdBindingSource.CurrentChanged += new System.EventHandler(this.dataSetVentasTotalsdBindingSource_CurrentChanged);
            // 
            // dataSetVentasTotalsd
            // 
            this.dataSetVentasTotalsd.DataSetName = "DataSetVentasTotalsd";
            this.dataSetVentasTotalsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHEADER";
            reportDataSource1.Value = this.headerBindingSource;
            reportDataSource2.Name = "DataSetDetail";
            reportDataSource2.Value = this.headerBindingSource;
            reportDataSource3.Name = "DataSetVentasTotales";
            reportDataSource3.Value = this.headerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoPromociones.UI.ReportVentasV3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1341, 552);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1254, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(1129, 76);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker4.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1129, 36);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // dataSetVentasTotalsdBindingSource1
            // 
            this.dataSetVentasTotalsdBindingSource1.DataSource = this.dataSetVentasTotalsd;
            this.dataSetVentasTotalsdBindingSource1.Position = 0;
            // 
            // headerBindingSource
            // 
            this.headerBindingSource.DataSource = typeof(ProyectoPromociones.Entities.Header);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataSource = typeof(ProyectoPromociones.Entities.Detail);
            this.detailBindingSource.CurrentChanged += new System.EventHandler(this.detailBindingSource_CurrentChanged);
            // 
            // UIReporteVentasTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UIReporteVentasTotal";
            this.Text = "UIReporteVentasTotal";
            this.Load += new System.EventHandler(this.UIReporteVentasTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVentasTotalsdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource headerBindingSource;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource;
        private DataSetVentasTotalsd dataSetVentasTotalsd;
        private System.Windows.Forms.BindingSource dataSetVentasTotalsdBindingSource1;
    }
}