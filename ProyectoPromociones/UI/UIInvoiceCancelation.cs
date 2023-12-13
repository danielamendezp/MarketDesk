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
    public partial class UIInvoiceCancelation : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryBuy FactoryBuy = new FactoryBuy();
        public UIInvoiceCancelation()
        {
            InitializeComponent();
            CentrarVentana();
            cargarHeader();
        }

        private void cargarHeader()
        {
            jLstInvoice.Items.Clear();
            List<Header> headers=factoryMaintenanceVisualize.GetHeaders();
            if (headers != null)
            {
                foreach (Header header in headers)
                {
                    jLstInvoice.Items.Add(header);
                }
            }
        }
        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void jLblBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void jButCancelar_Click(object sender, EventArgs e)
        {
            if (((Header)jLstInvoice.SelectedItem).State)
            {
                FactoryBuy.CancelarHeader((Header)jLstInvoice.SelectedItem);
                cargarHeader();
            }
            else
            {
                MessageBox.Show("Factura ya esta inactiva", "Mensaje informativo");
            }
            
        }

        private void jTxtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
