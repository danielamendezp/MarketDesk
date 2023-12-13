using Microsoft.Reporting.WinForms;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Patrones;
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
    public partial class UIReporteVentasTotal : Form
    {
        DateTime InitialTime = DateTime.Now;
        DateTime FinalTime = DateTime.Now;
        FactoryMaintenanceVisualize maintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryBuy factoryBuy = new FactoryBuy();
        public UIReporteVentasTotal()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void UIReporteVentasTotal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// CARGAR REPORTES
        /// </summary>
        private void CargarReporte()
        {
            this.dataSetVentasTotalsd.Detail.Clear();
            InitialTime = dateTimePicker3.Value;
            FinalTime = dateTimePicker4.Value;
            this.dataSetVentasTotalsd.Detail.Clear();
            // Obtener la lista completa de promociones
            List<Detail> lista = maintenanceVisualize.GetDetails();

            // Filtrar la lista por el rango de fechas
            List<Detail> listaFiltro = lista.Where(item => item.Header.State==true).ToList()
                .Where(item => item.Header.IssueDate >= InitialTime && item.Header.IssueDate <= FinalTime).ToList();

            double suma = 0;
            foreach (Detail pDetail in listaFiltro)
            {
                suma += pDetail.ProductQuantity * pDetail.Product.ListPrice;
            }

            Product product = new Product();
            product.IdProduct = 1;
            product.ListPrice = suma;
            product.Cost = factoryBuy.CambioDolar(suma);
            headerBindingSource.DataSource = null;
            headerBindingSource.DataSource = product;

            // Crear una nueva fila en el DataTable
            DataSetVentasTotalsd.DetailRow newRow = dataSetVentasTotalsd.Detail.NewDetailRow();
            newRow.IdProduct = 1;
            newRow.Cost = suma;
            newRow.ListPrice = factoryBuy.CambioDolar(suma);
            // Asignar los valores de la promoción a la nueva fila
            dataSetVentasTotalsd.Detail.AddDetailRow(newRow);
            // Actualizar el informe
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataSetVentasTotalsdBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void detailBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
