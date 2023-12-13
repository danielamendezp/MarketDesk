using Microsoft.Reporting.WinForms;
using ProyectoPromociones.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPromociones.UI
{
    public partial class UIReportVentas : Form
    {
        public UIReportVentas()
        {
            InitializeComponent();
        }

        private void UIReportVentas_Load(object sender, EventArgs e)
        {
            detailBindingSource1.DataSource = dataSetVentas;
            //dataSetVentasBindingSource.DataSource = dataSetVentas;
            this.detailTableAdapter.Fill(this.dataSetVentas.Detail);
            //DataSetVentas.Detail.Fill,GetData();
            /*ReportDataSource reportDataSource = new ReportDataSource("DataSetVentas", detailBindingSource1.Filter);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            detailBindingSource1.DataSource = reportDataSource;
            dataSetVentasBindingSource.DataSource = reportDataSource;*/
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            detailBindingSource1.DataSource = dataSetVentas;
           // dataSetVentasBindingSource.DataSource = dataSetVentas;
            this.detailTableAdapter.Fill(this.dataSetVentas.Detail);
            //DataSetVentas.Detail.Fill,GetData();
            /*ReportDataSource reportDataSource = new ReportDataSource("DataSetVentas", detailBindingSource1.Filter);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            detailBindingSource1.DataSource = reportDataSource;
            dataSetVentasBindingSource.DataSource = reportDataSource;*/
            reportViewer1.RefreshReport();
        }

        private void dataSetVentasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void detailBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
