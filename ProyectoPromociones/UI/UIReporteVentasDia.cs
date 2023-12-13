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
    public partial class UIReporteVentasDia : Form
    {
        FactoryMaintenanceVisualize maintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryBuy factoryBuy = new FactoryBuy();
        public UIReporteVentasDia()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void UIReporteVentasDia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// CARGAR REPORTES
        /// </summary>
        private void CargarReporte()
        {
            this.dataSetVentasTotalsd.Detail.Clear();
            // Obtener la lista completa de promociones
            List<Detail> lista = maintenanceVisualize.GetDetails();

            // Filtrar la lista por el rango de fechas y estado
            List<Detail> listaFiltro = lista
                .Where(item => item.Header.State == true)
                .ToList();

            // Agrupar los detalles por mes
            var ventasPorMes = listaFiltro
                .GroupBy(item => new { Mes = item.Header.IssueDate.Month, Año = item.Header.IssueDate.Year })
                .Select(group => new
                {
                    Mes = group.Key.Mes,
                    Año = group.Key.Año,
                    SumaVentas = group.Sum(detail => detail.ProductQuantity * detail.Product.ListPrice)
                })
                .OrderBy(group => group.Año)
                .ThenBy(group => group.Mes)
                .ToList();
            BindingList<Product> bindingList=new BindingList<Product>();
            
            // Recorrer los resultados
            foreach (var ventaMes in ventasPorMes)
            {
                int mes = ventaMes.Mes;
                int año = ventaMes.Año;
                double sumaVentas = ventaMes.SumaVentas;
                Product product = new Product();
                product.Name = mes.ToString() + "/"+año.ToString();
                product.Cost= sumaVentas;
                bindingList.Add(product);
                //productBindingSource.DataSource = product;
                /*DataSetVentasTotalsd.DetailRow newRow = dataSetVentasTotalsd.Detail.NewDetailRow();
                newRow.Name = ventaMes.Mes.ToString();
                newRow.Cost = ventaMes.SumaVentas;
                dataSetVentasTotalsd.Detail.AddDetailRow(newRow);*/
            }
            
            productBindingSource.DataSource = bindingList;
            // Actualizar el informe
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
