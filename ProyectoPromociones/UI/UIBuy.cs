using ProyectoPromociones.Entities;
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

namespace ProyectoPromociones.UI
{
    public partial class UIBuy : Form
    {

        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        Product product = new Product();
        private List<List<string>> tabla;
        private double total=0;
        List<Product> products = new List<Product>();
        List<int> cantidades= new List<int>();

        public UIBuy()
        {
            InitializeComponent();
            CentrarVentana();
            inicializarTabla();
        }

        private void inicializarTabla()
        {
            int filas = 10;
            int columnas = 4;
            tabla = new List<List<string>>();
            jTablaTotales.Size = new Size(527, 588);
            AsignarNombresColumnas(tabla);
        }

        private void AsignarNombresColumnas(List<List<string>> tabla)
        {
            List<string> nombresColumnas = new List<string>
            {
                "Descripción", "Cantidad", "Precio Unitario", "Precio Total"
            };
            tabla.Add(nombresColumnas);
            AsignarTablaAlDataGridView(tabla);
        }


        private void AsignarTablaAlDataGridView(List<List<string>> tabla)
        {
            jTablaTotales.Rows.Clear();
            jTablaTotales.Columns.Clear();

            jTablaTotales.Size = new Size(530, 588);

            if (tabla.Count > 0)
            {
                int totalColumns = tabla[0].Count;

                for (int i = 0; i < totalColumns; i++)
                {
                    jTablaTotales.Columns.Add(tabla[0][i], tabla[0][i]);
                    jTablaTotales.Columns[i].Width = 122;
                }

                for (int i = 1; i < tabla.Count; i++)
                {
                    jTablaTotales.Rows.Add(tabla[i][0], tabla[i][1], tabla[i][2], tabla[i][3]);
                }
            }

            jTablaTotales.DefaultCellStyle.Font = new Font("Arial", 10);
            jTablaTotales.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10);
        }


        private void LlenarTabla(string nombre, string cantidad, string precioUnitario, string precioTotal)
        {
            List<string> nuevaFila = new List<string> { nombre, cantidad, precioUnitario, precioTotal };
            tabla.Add(nuevaFila);
            jTablaTotales.Size = new Size(527, 588);
            AsignarTablaAlDataGridView(tabla);
        }



        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void miCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abre la nueva ventana de manera modal
            using (var item = new UIPromotion())
            {
               item.ShowDialog();
            }
        }

        private void jButFacturar_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var item = new UIPromotion())
            {
                item.ShowDialog();
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoicePersistencia.cantidades.Clear();
            InvoicePersistencia.products.Clear();
            InvoicePersistencia.promotions.Clear();
            InvoicePersistencia.descuento = 0;
            this.Hide();
            using (var item = new Form1())
            {
                item.ShowDialog();
            }
        }

        private void jButAgregar_Click(object sender, EventArgs e)
        {
            InvoicePersistencia.listaCantidades((int)jCantidad.Value);
            InvoicePersistencia.listProduct(product);
            cargarListaProductos();
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
        private void cargarListaProductos()
        {
            jCantidad.Maximum = product.ExistingQuantity;
            if (double.TryParse(jLblPrecio.Text, out double precioUnitario) &&
            double.TryParse(jCantidad.Value.ToString(), out double cantidad))
            {
                
                double precioTotal = precioUnitario * cantidad;
                total= precioTotal+total;
                jTxtSubTotal.Text = "₡ " + total.ToString();
                LlenarTabla(jLblDescipcion.Text, jCantidad.Value.ToString(), "₡ " + jLblPrecio.Text, "₡ " + precioTotal.ToString());
            }
            else
            {
                // Manejar el caso en que la conversión no sea exitosa
                MessageBox.Show("El formato de Precio o Cantidad no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void jLblBuscar_Click(object sender, EventArgs e)
        {
            if (jTxtCodigoBarras.Text.Length > 0)
            {
                visualizar();
            }
        }

        private bool visualizar()
        {
            product=factoryMaintenanceVisualize.GetProductByFilter(jTxtCodigoBarras.Text);
            if (product != null)
            {
                jCantidad.Maximum = product.ExistingQuantity;
                jLblPrecio.Text = product.ListPrice.ToString();
                pictureBox.Image=SetImageFromBytes(product.Photo); 
                jLblDescipcion.Text=product.Name.ToString();

                return true;
            }else {
                MessageBox.Show("No se pudo encontrar el valor", "Mensaje informativo");
                return false;
            }
        }

        private void jTxtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }
    }
}
