using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Patrones;
using ProyectoPromociones.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoPromociones.UI
{
    public partial class UIPromotion : Form
    {
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        Product product = new Product();
        private List<List<string>> tabla;
        private double total = 0;
        List<Product> lista= new List<Product>();
        List<int> cantidades= new List<int>();
        FactoryPromotion factoryPromotion = new FactoryPromotion();
        double descuentos=0;
        List<Promotion> promotions = new List<Promotion>(); 
        public UIPromotion()
        {
            InitializeComponent();
            CentrarVentana();
            inicializarTabla();
            cargarProductos();
            cargarPromociones();
        }

        private void cargarPromociones()
        {
            List<Promotion> promos = factoryMaintenanceVisualize.GetPromotionsByDate();

            // Asegúrate de que la lista no sea nula y tenga al menos un elemento
            if (promos != null && promos.Count > 0)
            {
                // Crear un array de controles promo
                CheckBox[] promoControls = { promo1, promo2, promo3, promo4 };

                // Recorrer la lista y asignar la descripción a cada control correspondiente
                for (int i = 0; i < Math.Min(promos.Count, promoControls.Length); i++)
                {
                    promoControls[i].Text = promos[i].Description;
                }
            }
        }
        private void cargarProductos()
        {
            int j = 0;
            string cantidad;
            string listPrice;
            string totalPrice="0";
            // Obtener el último elemento de la pila
            lista = InvoicePersistencia.products;
            cantidades = InvoicePersistencia.cantidades; 

            if (lista != null)
                {
                    foreach (Product product in lista)
                    {
                        
                        cantidad = cantidades[j].ToString();
                        listPrice = product.ListPrice.ToString();
                        totalPrice = (product.ListPrice* cantidades[j]).ToString();
                        LlenarTabla(product.Name, cantidad, listPrice, totalPrice);
                        j++; 
                    }
                }
                else
                {
                    MessageBox.Show("La lista de productos es nula.", "Mensaje informativo");
                }
            cargarPrecio();
        }


        private void inicializarTabla()
        {
            tabla = new List<List<string>>();
            jTablaTotales.Size = new Size(648, 481); 
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

            jTablaTotales.Size = new Size(648, 481);

            if (tabla.Count > 0)
            {
                int totalColumns = tabla[0].Count;

                for (int i = 0; i < totalColumns; i++)
                {
                    jTablaTotales.Columns.Add(tabla[0][i], tabla[0][i]);
                    jTablaTotales.Columns[i].Width = 135;
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
            jTablaTotales.Size = new Size(648, 481);
            AsignarTablaAlDataGridView(tabla);
        }



        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UIPromotion_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cargarPrecio()
        {
            jTxtsubTotal.Text = "₡ " + InvoicePersistencia.subTotal();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoicePersistencia.descuento = descuentos;
            InvoicePersistencia.promotions = promotions;
            InvoicePersistencia.total();
            this.Hide();

            // Abre la nueva ventana de manera modal
            using (var item = new UIPayment())
            {
                item.ShowDialog();
            }
        }

        private void PromotionGift_CheckedChanged(object sender, EventArgs e)
        {
            if (promo3.Checked)
            {
                cargarPromo(promo3.Text);
            }
            else
            {
                quitarPromo(promo3.Text);
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var item = new UIBuy())
            {
                item.ShowDialog();
            }
        }

        private void chkBoxProductDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (promo1.Checked)
            {
                cargarPromo(promo1.Text);
            }
            else
            {
                quitarPromo(promo1.Text);
            }
        }

        private void chkBoxPromotionDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (promo2.Checked)
            {
                cargarPromo(promo2.Text);
            }
            else
            {
                quitarPromo(promo2.Text);
            }
        }

        private void chkValueDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (promo4.Checked)
            {
                cargarPromo(promo4.Text);
            }
            else
            {
                quitarPromo(promo4.Text);
            }
           
        }

        private void cargarPromo(string promoText)
        {
            promotions.Add(factoryMaintenanceVisualize.GetPromotionByFilter(promoText));
            descuentos += factoryPromotion.CreatePromotion(lista, cantidades, promoText, InvoicePersistencia.subTotal());
            jTxtDescuento.Text = "₡ " + descuentos.ToString();
            jTxtTotal.Text = "₡ " + (InvoicePersistencia.subTotal() - descuentos).ToString();
        }
        private void quitarPromo(string promoText)
        {
            promotions.Remove(factoryMaintenanceVisualize.GetPromotionByFilter(promoText));
            descuentos -= factoryPromotion.CreatePromotion(lista, cantidades, promoText, InvoicePersistencia.subTotal());
            jTxtDescuento.Text = "₡ " + descuentos.ToString();
            jTxtTotal.Text = "₡ " + (InvoicePersistencia.subTotal() - descuentos).ToString();
        }
    }
}
