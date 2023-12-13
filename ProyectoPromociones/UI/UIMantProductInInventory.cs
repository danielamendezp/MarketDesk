using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;
using ProyectoPromociones.Patrones;
using ProyectoPromociones.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoPromociones.UI
{
    public partial class UIMantProductInInventory : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Product Product = new Product();
        public UIMantProductInInventory()
        {
            InitializeComponent();
            CentrarVentana();
            cargarCategoria();
            cargarSupplier();
            cargarProduct();
        }
        private void cargarProduct()
        {
            listBox1.Items.Clear();
            List<Product> Product = null;
            Product = factoryMaintenanceVisualize.GetProducts();

            if (Product != null)
            {
                foreach (Product item in Product)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
        private void cargarCategoria()
        {
            List<Category> list = factoryMaintenanceVisualize.GetCategory();
            foreach (Category c in list)
            {
                this.jCboCategory.Items.Add(c);
            }
        }
        private void cargarSupplier()
        {
            List<Supplier> list = factoryMaintenanceVisualize.GetSuppliers();
            foreach (Supplier v in list)
            {
                this.jCboSupplier.Items.Add(v);
            }
        }
        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Image SetImageFromBytes(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
            {
                return null; // O puedes devolver una imagen predeterminada si lo prefieres
            }

            try
            {
                ImageConverter imageConverter = new ImageConverter();
                Image image = (Image)imageConverter.ConvertFrom(imageBytes);
                return image;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al convertir los bytes a una imagen
                Console.WriteLine($"Error al convertir bytes a imagen: {ex.Message}");
                return null;
            }
        }
        private void jButCreate_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                Usser usser = new Usser();
                usser = factoryMaintenanceVisualize.GetUsserByFilter(Stack.VerUltimoElemento().PersonName);
                factoryMaintenance.CreateProduct(jMskCodigoBarras.Text, jTxtName.Text, (int)this.numericUpDown1.Value, (Category)jCboCategory.SelectedItem,
                                                (Supplier)jCboSupplier.SelectedItem, double.Parse(jTxtCost.Text), double.Parse(jTxtProfitPercentage.Text),
                                                double.Parse(jTxtTax.Text), double.Parse(jTxtListPrice.Text), usser, GetImageBytesFromPictureBox(pictureBox1));
            }
        }

        private byte[] GetImageBytesFromPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    return ms.ToArray();
                }
            }

            // Devuelve un array vacío si no hay imagen
            return new byte[0];

        }
        private void jButUpdate_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                    Usser usser = new Usser();
                    usser = factoryMaintenanceVisualize.GetUsserByFilter(Stack.VerUltimoElemento().PersonName);
                    factoryMaintenanceUpdate.CreateProduct(Product.IdProduct, jMskCodigoBarras.Text, jTxtName.Text, (int)this.numericUpDown1.Value, (Category)jCboCategory.SelectedItem,
                                                    (Supplier)jCboSupplier.SelectedItem, double.Parse(jTxtCost.Text), double.Parse(jTxtProfitPercentage.Text),
                                                double.Parse(jTxtTax.Text), double.Parse(jTxtListPrice.Text), usser, GetImageBytesFromPictureBox(pictureBox1));
                
            }
            
        }

        private bool RevisarDatos()
        {
            if (jTxtCost.Text.Length > 0 &&
                jTxtListPrice.Text.Length > 0 &&
                jTxtName.Text.Length > 0 &&
                jTxtProfitPercentage.Text.Length > 0 &&
                jTxtTax.Text.Length > 0 &&
                jMskCodigoBarras.Text.Length > 0 &&
                jCboCategory.SelectedItem != null &&
                jCboSupplier.SelectedItem != null &&
                numericUpDown1.Value > 0 &&
                double.TryParse(jTxtCost.Text, out double cost) &&
                double.TryParse(jTxtListPrice.Text, out double listPrice) &&
                double.TryParse(jTxtProfitPercentage.Text, out double profitPercentage) &&
                double.TryParse(jTxtTax.Text, out double tax))
            {
                return true;
            }
            else
            {
             
                MessageBox.Show("Por favor, ingrese valores válidos en los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void jButEliminar_Click(object sender, EventArgs e)
        {
            
                factoryMaintenanceDelete.DeleteProduct(Product.IdProduct.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de selección de archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer las propiedades del cuadro de diálogo
            openFileDialog.Filter = "Archivos de imagen|*.bmp;*.jpg;*.jpeg;*.gif;*.png|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar imagen";

            // Mostrar el cuadro de diálogo y verificar si el usuario hizo clic en "Aceptar"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la imagen seleccionada
                string imagePath = openFileDialog.FileName;

                // Cargar la imagen en el PictureBox
                pictureBox1.Image = System.Drawing.Image.FromFile(imagePath);
            }
        }

        private void jMskCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private bool visualizar()
        {
            Product = factoryMaintenanceVisualize.GetProductByFilter(jMskCodigoBarras.Text);
            if (Product != null)
            {
                jTxtCost.Text = Product.Cost.ToString();
                jTxtListPrice.Text = Product.ListPrice.ToString();
                jTxtName.Text = Product.Name.ToString();
                jTxtProfitPercentage.Text = Product.ProfitPercentage.ToString();
                jTxtTax.Text = Product.Tax.ToString();
                jMskCodigoBarras.Text = Product.CodigoBarras.ToString();

                int indexCategory = jCboCategory.FindStringExact(Product.Category.Name);
                if (indexCategory != -1)
                {
                    jCboCategory.SelectedIndex = indexCategory;
                }
                int indexSupplier = jCboSupplier.FindStringExact(Product.Supplier.Name);
                if (jCboSupplier.SelectedIndex > -1)
                {
                    jCboSupplier.SelectedIndex = indexSupplier;
                }
                numericUpDown1.Value = Product.ExistingQuantity;
                pictureBox1.Image = SetImageFromBytes(Product.Photo);
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el valor", "Mensaje informativo");
                return false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jMskCodigoBarras.Text = ((Product)listBox1.SelectedItem).CodigoBarras;

            visualizar();
        }
    }
}
