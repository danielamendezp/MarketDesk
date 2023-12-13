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
    public partial class UIMantSupplier : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize= new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete(); 
        Supplier supplier= new Supplier();
        public UIMantSupplier()
        {
            InitializeComponent();
            CentrarVentana();
            cargarSupplier();
        }
        private void cargarSupplier()
        {
            listBox1.Items.Clear();
            List<Supplier> Supplier = null;
            Supplier = factoryMaintenanceVisualize.GetSuppliers();

            if (Supplier != null)
            {
                foreach (Supplier item in Supplier)
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
        private void jButCreate_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                factoryMaintenance.CreateSupplier(jTxtNameSupplier.Text, jMskPhoneNumber.Text, jTxtEmail.Text);
            }
            cargarSupplier();
        }

        private void jButUpdate_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                    factoryMaintenanceUpdate.CreateSupplier(supplier.IdSupplier, jTxtNameSupplier.Text, jMskPhoneNumber.Text, jTxtEmail.Text);
               
            }
            cargarSupplier();
        }
        private bool RevisarDatos()
        {
            if (jTxtEmail.Text.Length > 0 &&
                jTxtNameSupplier.Text.Length > 0 &&
                jMskPhoneNumber.Text.Length > 0)
            {
                return true;
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción según tus necesidades
                MessageBox.Show("Por favor, ingrese valores válidos en los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void jTxtNameSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jButEliminar_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                 factoryMaintenanceDelete.DeleteSupplier(supplier.IdSupplier.ToString());
                
            }
            cargarSupplier();
        }

        private bool visualizar()
        {
            supplier = factoryMaintenanceVisualize.GetSupplierByFilter(jTxtNameSupplier.Text);
            if (supplier != null)
            {
                jTxtEmail.Text = supplier.Email;
                jTxtIdSupplier.Text = supplier.IdSupplier.ToString();
                jTxtNameSupplier.Text = supplier.Name;
                jMskPhoneNumber.Text = supplier.PhoneNumber;
                return true;
            }
            else
            {
                MessageBox.Show("No existe el dato", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jTxtNameSupplier.Text = ((Supplier)listBox1.SelectedItem).Name;

            visualizar();
        }
    }
}
