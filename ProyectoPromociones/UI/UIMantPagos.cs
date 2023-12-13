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
    public partial class UIMantPagos : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Payment pay = new Payment();
        public UIMantPagos()
        {
            InitializeComponent();
            CentrarVentana();
            cargarPayment();
        }
        private void cargarPayment()
        {
            listBox1.Items.Clear();
            List<Payment> Payment = null;
            Payment = factoryMaintenanceVisualize.GetPayment();

            if (Payment != null)
            {
                foreach (Payment item in Payment)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void jButUpdate_Click(object sender, EventArgs e)
        {
            if (jTxtName.Text.Length > 0&& pay!=null)
            {
                factoryMaintenanceUpdate.CreatePayment(pay.IdPayment, jTxtName.Text);
            }
            cargarPayment();
        }


        private bool visualizar()
        {
            pay = factoryMaintenanceVisualize.GetPaymentByFilter(jTxtName.Text);
            if (pay != null)
            {
                jTxtId.Text = pay.IdPayment.ToString();
                jTxtName.Text = pay.PaymentName.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("No existe el valor", "Mensaje Informativo");
                return false;
            }
        }

        private void jButCreate_Click_1(object sender, EventArgs e)
        {
            if (jTxtName.Text.Length > 0)
            {
                factoryMaintenance.CreatePayment(jTxtName.Text);
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
            cargarPayment();
        }

        private void jButEliminar_Click_1(object sender, EventArgs e)
        {
            if (jTxtName.Text.Length > 0 && jTxtId.Text.Length > 0 && pay != null)
            {
                    factoryMaintenanceDelete.DeletePayment(pay.IdPayment.ToString());
                

            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
            cargarPayment();
        }

        private void jTxtId_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jTxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jTxtName.Text = ((Payment)listBox1.SelectedItem).PaymentName;

            visualizar();
        }
    }
}
