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
    public partial class UIMantPayment : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Payment cat = new Payment();
        public UIMantPayment()
        {
            InitializeComponent();
            CentrarVentana();
        }

        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void jButCreate_Click(object sender, EventArgs e)
        {
            if (jTxtName.Text.Length > 0)
            {
                factoryMaintenance.CreatePayment(jTxtName.Text);
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
        }


        private bool visualizar()
        {
            cat = factoryMaintenanceVisualize.GetPaymentByFilter(jTxtName.Text);
            if (cat != null)
            {
                jTxtId.Text = cat.IdPayment.ToString();
                jTxtName.Text = cat.PaymentName.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("No existe el valor", "Mensaje Informativo");
                return false;
            }
        }

        private void jButUpdate_Click_1(object sender, EventArgs e)
        {

            if (visualizar() && jTxtName.Text.Length > 0)
            {
                factoryMaintenanceUpdate.CreatePayment(cat.IdPayment, jTxtName.Text);
            }
        }

        private void jButEliminar_Click_1(object sender, EventArgs e)
        {
            if (jTxtName.Text.Length > 0 && jTxtId.Text.Length > 0)
            {
                if (visualizar())
                {
                    factoryMaintenanceDelete.DeletePayment(cat.IdPayment.ToString());
                }

            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
        }

        private void UIMantPayment_Load(object sender, EventArgs e)
        {

        }

        private void jTxtName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jTxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }
    }
}
