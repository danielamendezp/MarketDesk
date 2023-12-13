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
    public partial class UIUpdatePromotion : Form
    {
        FactoryMaintenanceCreate factoryMaintenanceCreate = new FactoryMaintenanceCreate();
        FactoryMaintenanceVisualize maintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Promotion promciones = null;

        public UIUpdatePromotion()
        {
            InitializeComponent(); 
            cargarProductos();
            CentrarVentana();
            cargarPromotion();
        }
        private void cargarPromotion()
        {
            listBox1.Items.Clear();
            List<Promotion> Promotion = null;
            Promotion = maintenanceVisualize.GetPromotions();

            if (Promotion != null)
            {
                foreach (Promotion item in Promotion)
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
        public void cargarProductos()
        {
            List<Product> products = maintenanceVisualize.GetProducts();

            foreach (Product product in products)
            {
                jCboProductos.Items.Add(product);
            }
        }


        private bool visualizar()
        {
            promciones = maintenanceVisualize.GetPromotionByFilter(jDescripcionOferta.Text);

            if (promciones != null)
            {
                jFechaInicio.Value = promciones.InitialTime;
                jFechaFinal.Value = promciones.FinalTime;
                int indexPromotionProduct = jCboProductos.FindStringExact(promciones.PromotionProduct.ToString());
                if (indexPromotionProduct != -1)
                {
                    jCboProductos.SelectedIndex = indexPromotionProduct;
                }
                jNumCantidad.Value = promciones.QtyPromotionProduct;
                jDescripcionOferta.Text = promciones.Description;
                jMontoCompra.Text = promciones.BuyAmount.ToString();
                jDescuento.Text = (promciones.Discount*100).ToString();
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro el valor", "Mensaje Informativo");
                return false;
            }
        }

        private void jDescripcionOferta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jButActualizar_Click_1(object sender, EventArgs e)
        {
            int IdPromotion = 0;
            DateTime InitialTime = DateTime.Now;
            DateTime FinalTime = DateTime.Now;
            Product PromotionProduct = null;
            Product GiftPromotion = null;
            int QtyPromotionProduct = 0;
            int QtyGiftPromotion = 0;
            string Description = "";
            double Discount = 0;
            double BuyAmount = 0;

            if (jFechaInicio.Value != null && jFechaFinal.Value != null
                && jDescuento.Text.Length > 0 &&
                jDescripcionOferta.Text.Length > 0)
            {
                InitialTime = jFechaInicio.Value;
                FinalTime = jFechaFinal.Value;
                PromotionProduct = (Product)jCboProductos.SelectedItem;
                QtyPromotionProduct = (int)jNumCantidad.Value;
                Description = jDescripcionOferta.Text;
                Discount = double.Parse(jDescuento.Text.Replace("%", "")) / 100;
                if (jMontoCompra.Text.Length > 1)
                {
                    BuyAmount = double.Parse(jMontoCompra.Text.Replace("₡", ""));
                }

                factoryMaintenanceUpdate.CreatePromotion(promciones.IdPromotion, InitialTime, FinalTime, PromotionProduct, GiftPromotion, QtyPromotionProduct, QtyGiftPromotion, Description, Discount, BuyAmount);
            }
            else
            {
                MessageBox.Show("Algun dato incompleto", "Mensaje");
            }
            cargarPromotion();
        }

        private void jAgregar_Click_1(object sender, EventArgs e)
        {


            int IdPromotion = 0;
            DateTime InitialTime = DateTime.Now;
            DateTime FinalTime = DateTime.Now;
            Product PromotionProduct = null;
            Product GiftPromotion = null;
            int QtyPromotionProduct = 0;
            int QtyGiftPromotion = 0;
            string Description = "";
            double Discount = 0;
            double BuyAmount = 0;

            if (jFechaInicio.Value != null && jFechaFinal.Value != null && jCboProductos.SelectedIndex > -1
                && jDescuento.Text.Length > 0 && jMontoCompra.Text.Length > 0 &&
                jDescripcionOferta.Text.Length > 0)
            {
                InitialTime = jFechaInicio.Value;
                FinalTime = jFechaFinal.Value;
                PromotionProduct = (Product)jCboProductos.SelectedItem;
                QtyPromotionProduct = (int)jNumCantidad.Value;
                Description = jDescripcionOferta.Text;
                if (jDescuento.Text.Length > 1)
                {
                    Discount = double.Parse(jDescuento.Text.Replace("%", "")) / 100;
                }
               
                if (jMontoCompra.Text.Length>1)
                {
                    BuyAmount = double.Parse(jMontoCompra.Text.Replace("₡", ""));
                }
                factoryMaintenanceCreate.CreatePromotion(InitialTime, FinalTime, PromotionProduct, GiftPromotion, QtyPromotionProduct, QtyGiftPromotion, Description, Discount, BuyAmount);
            }
            else
            {
                MessageBox.Show("Algun dato incompleto", "Mensaje");
            }
            cargarPromotion();
        }

        private void jButEliminar_Click_1(object sender, EventArgs e)
        {
            factoryMaintenanceDelete.DeletePromotion(promciones.IdPromotion.ToString());
            cargarPromotion();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jDescripcionOferta.Text = ((Promotion)listBox1.SelectedItem).Description;

            visualizar();
        }
    }
}
