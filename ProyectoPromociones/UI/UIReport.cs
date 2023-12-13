using Microsoft.Reporting.WinForms;
using ProyectoPromociones.BLL;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProyectoPromociones.UI
{
    public partial class UIReport : Form
    {
        DateTime InitialTime=DateTime.Now;
        DateTime FinalTime=DateTime.Now;
        FactoryMaintenanceVisualize maintenanceVisualize= new FactoryMaintenanceVisualize();
        public UIReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CARGAR REPORTES
        /// </summary>
        private void CargarReporte()
        {
            InitialTime = dateTimePicker3.Value;
            FinalTime = dateTimePicker4.Value;
            dataSetPromo.Promotion.Clear();
            // Obtener la lista completa de promociones
            List<Promotion> lista = maintenanceVisualize.GetPromotions();

            // Filtrar la lista por el rango de fechas
            List<Promotion> listaFiltro = lista.Where(item => item.InitialTime >= InitialTime && item.FinalTime <= FinalTime).ToList();

            // Crear un BindingList a partir de la lista filtrada
            BindingList<Promotion> bindingList = new BindingList<Promotion>(listaFiltro);

            // Limpiar el DataSource actual del BindingSource
            PromotionBindingSource.DataSource = null;

            // Asignar el BindingList como nuevo DataSource del BindingSource
            PromotionBindingSource.DataSource = bindingList;

            foreach (Promotion promotion in listaFiltro)
            {
                // Crear una nueva fila en el DataTable
                DataSetPromo.PromotionRow newRow = dataSetPromo.Promotion.NewPromotionRow();

                // Asignar los valores de la promoción a la nueva fila
                newRow.IdPromotion= promotion.IdPromotion;
                newRow.Description = promotion.Description;
                newRow.InitialTime= promotion.InitialTime;
                newRow.FinalTime = promotion.FinalTime;
                // ...

                // Agregar la nueva fila al DataTable
                dataSetPromo.Promotion.AddPromotionRow(newRow);
            }
            // Actualizar el informe
            reportViewer2.RefreshReport();
        }


        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void UIReport_Load_1(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            
        }

        private void dataSetPromoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
