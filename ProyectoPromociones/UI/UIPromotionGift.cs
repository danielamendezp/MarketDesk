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
    public partial class UIPromotionGift : Form
    {
        FactoryMaintenanceCreate factoryMaintenanceCreate = new FactoryMaintenanceCreate();
        FactoryMaintenanceVisualize maintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete(); 
        Promotion promciones= null;
        public UIPromotionGift()
        {
            InitializeComponent();
            cargarProductos();
            CentrarVentana();
            cargarPromotion();
        }
        /// <summary>
        /// CARGAR
        /// </summary>
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
                jCboProductoRegalo.Items.Add(product);
                jCboProductosPromocion.Items.Add(product);
            }
        }
        /// <summary>
        /// AGREGAR
        /// </summary>
        private void jButAgregar_Click(object sender, EventArgs e)
        {
            int IdPromotion = 0;
            DateTime InitialTime = DateTime.Now;
            DateTime FinalTime = DateTime.Now;
            Product PromotionProduct = null;
            Product GiftPromotion=null;
            int QtyPromotionProduct = 0;
            int QtyGiftPromotion = 0;
            string Description = "";
            double Discount = 0;
            double BuyAmount = 0;

            if(jFechaInicio.Value!=null && jFechaFinal.Value != null && jCboProductosPromocion.SelectedIndex>-1
                && jCboProductoRegalo.SelectedIndex>-1 && jCantPromocion.Value > 0 && jNumRegalo.Value > 0 && jDescripcionOferta.Text.Length > 0)
            {
                InitialTime = jFechaInicio.Value;
                FinalTime = jFechaFinal.Value;
                PromotionProduct = (Product)jCboProductosPromocion.SelectedItem;
                GiftPromotion = (Product)jCboProductoRegalo.SelectedItem;
                QtyPromotionProduct = (int)jCantPromocion.Value;
                QtyGiftPromotion = (int)jNumRegalo.Value;
                Description = jDescripcionOferta.Text;
                factoryMaintenanceCreate.CreatePromotion(InitialTime, FinalTime, PromotionProduct, GiftPromotion, QtyPromotionProduct, QtyGiftPromotion, Description, Discount, BuyAmount);
            }
            else
            {
                MessageBox.Show("Algun dato incompleto", "Mensaje");
            }
        }

        /// <summary>
        /// ACTUALIZAR
        /// </summary>
        private void jButActualizar_Click(object sender, EventArgs e)
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

            if (jFechaInicio.Value != null && jFechaFinal.Value != null && jCboProductosPromocion.SelectedIndex > -1
                && jCboProductoRegalo.SelectedIndex > -1 && jCantPromocion.Value > 0 && jNumRegalo.Value > 0 && jDescripcionOferta.Text.Length > 0)
            {
                InitialTime = jFechaInicio.Value;
                FinalTime = jFechaFinal.Value;
                PromotionProduct = (Product)jCboProductosPromocion.SelectedItem;
                GiftPromotion = (Product)jCboProductoRegalo.SelectedItem;
                QtyPromotionProduct = (int)jCantPromocion.Value;
                QtyGiftPromotion = (int)jNumRegalo.Value;
                Description = jDescripcionOferta.Text;
                factoryMaintenanceUpdate.CreatePromotion(promciones.IdPromotion, InitialTime, FinalTime, PromotionProduct, GiftPromotion, QtyPromotionProduct, QtyGiftPromotion, Description, Discount, BuyAmount);
            }
            else
            {
                MessageBox.Show("Algun dato incompleto", "Mensaje");
            }
            cargarPromotion();
        }

        private bool visualizar()
        {
            promciones = maintenanceVisualize.GetPromotionByFilter(jDescripcionOferta.Text);

            if (promciones != null)
            {
                jFechaInicio.Value = promciones.InitialTime;
                jFechaFinal.Value = promciones.FinalTime;
                jCboProductosPromocion.SelectedItem=promciones.PromotionProduct;
                jCboProductoRegalo.SelectedItem = promciones.GiftPromotion;

                int indexPromotionProduct = jCboProductoRegalo.FindStringExact(promciones.PromotionProduct.ToString());
                if (indexPromotionProduct != -1)
                {
                    jCboProductosPromocion.SelectedIndex = indexPromotionProduct;
                }
                int indexProductoRegalo = jCboProductoRegalo.FindStringExact(promciones.GiftPromotion.ToString());
                if (indexProductoRegalo != -1)
                {
                    jCboProductoRegalo.SelectedIndex = indexProductoRegalo;
                }

                if (promciones.QtyPromotionProduct != 0)
                {
                    jCantPromocion.Value = promciones.QtyPromotionProduct;
                }
                
                if (promciones.QtyGiftPromotion>0)
                {
                    jNumRegalo.Value = promciones.QtyGiftPromotion;
                }
                
                jDescripcionOferta.Text=promciones.Description;
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro el valor", "Mensaje Informativo");
                return false;
            }
            cargarPromotion();
        }

        private void jButEliminar_Click(object sender, EventArgs e)
        {
            factoryMaintenanceDelete.DeletePromotion(promciones.IdPromotion.ToString());
            cargarPromotion();
        }

        private void jDescripcionOferta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jDescripcionOferta.Text = ((Promotion)listBox1.SelectedItem).Description;

            visualizar();
        }
    }
}
