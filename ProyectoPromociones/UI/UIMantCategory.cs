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
    public partial class UIMantCategory : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Category cat =new Category();
        public UIMantCategory()
        {
            InitializeComponent();
            CentrarVentana();
            cargarCategory();
        }
        private void cargarCategory()
        {
            listBox1.Items.Clear();
            List<Category> Category = null;
            Category = factoryMaintenanceVisualize.GetCategory();

            if (Category != null)
            {
                foreach (Category item in Category)
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
            if (jTxtNameCategory.Text.Length > 0)
            {
                factoryMaintenance.CreateCategory(jTxtNameCategory.Text);
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
            cargarCategory();
        }

        private void jButUpdate_Click(object sender, EventArgs e)
        {
            if (jTxtNameCategory.Text.Length>0)
            {
                factoryMaintenanceUpdate.CreateCategory(cat.IdCategory, jTxtNameCategory.Text);
            }
            cargarCategory();
        }

        private void jButEliminar_Click(object sender, EventArgs e)
        {
            if (jTxtNameCategory.Text.Length>0&&jTxtIdCategory.Text.Length>0) {
                
                    factoryMaintenanceDelete.DeleteCategory(cat.IdCategory.ToString());
                
            
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
            }
            cargarCategory();
        }

        private void jTxtNameCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jTxtIdCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private bool visualizar()
        {
            cat = factoryMaintenanceVisualize.GetCategoryByFilter(jTxtNameCategory.Text);
            if(cat!=null)
            {
                jTxtIdCategory.Text = cat.IdCategory.ToString();
                jTxtNameCategory.Text = cat.Name.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("No existe el valor", "Mensaje Informativo");
                return false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jTxtNameCategory.Text = ((Category)listBox1.SelectedItem).Name;

            visualizar();
        }
    }
}
