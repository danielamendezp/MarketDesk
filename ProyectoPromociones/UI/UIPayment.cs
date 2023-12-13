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

namespace ProyectoPromociones.UI
{
    public partial class UIPayment : Form
    {
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryBuy factoryBuy = new FactoryBuy();
        public UIPayment()
        {
            InitializeComponent();
            CentrarVentana();
            cargarPagos();
            cargarCustomer();
            cargarMetodosPagos();
            cargarPrecio();
        }

        private void cargarPrecio()
        {
            jLblPrecioFinal.Text = "₡ " + InvoicePersistencia.total();              
        }

        private void cargarPagos()
        {
          jCboPagos.Items.Add("Visa");
          jCboPagos.Items.Add("MasterCard");
            
        }

        private void cargarMetodosPagos()
        {
            List<Payment> payments = factoryMaintenanceVisualize.GetPayment();
            foreach (Payment payment in payments)
            {
                jCboMetodoPago.Items.Add(payment);
            }
        }
        private void cargarCustomer()
        {
            List<Customer> Customers = factoryMaintenanceVisualize.GetCustomer();
            foreach (Customer Customer in Customers)
            {
                jCboCliente.Items.Add(Customer);
            }
        }
        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoicePersistencia.promotions.Clear();
            InvoicePersistencia.descuento = 0;
            this.Hide();
            using (var item = new UIPromotion())
            {
                item.ShowDialog();
            }
        }


        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (var item = new UICustomer())
            {
                item.ShowDialog();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private Boolean verificarDatosTarjeta()
        {
            if (revisarDatosTarjeta())
            {
                PayCard payCard = new PayCard();
                payCard.CardNumber = jNumTarjeta.Text;
                payCard.CVVCVC = int.Parse(jCVC.Text);
                payCard.ExpirationDate = jCaducidad.Text;
                if (payCard.todasVerificaciones())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Boolean revisarDatosTarjeta()
        {
            if(jNumTarjeta.Text.Length>0&& jCVC.Text.Length > 0&& jCaducidad.Text.Length > 0 &&jCboCliente.SelectedIndex>-1)
            {
                return true;
            }
            else{
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
                return false;
            }
        }

        private Boolean revisarEfectivo()
        {
            if (jCash.Text.Length>0&& jCambio.Text.Length>0&& jCboCliente.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");
                return false;
            }
        }


        private void comprar()
        {
            factoryBuy.DescontarProductoInventario(InvoicePersistencia.products, InvoicePersistencia.cantidades);
            factoryBuy.GenerarDetails(InvoicePersistencia.products, InvoicePersistencia.cantidades, InvoicePersistencia.promotions, (Customer)jCboCliente.SelectedItem, 
            factoryMaintenanceVisualize.GetBusinessByFilter("La pulpe"), (Payment) jCboMetodoPago.SelectedItem, InvoicePersistencia.subTotal(), InvoicePersistencia.descuento, InvoicePersistencia.total());
            this.Hide();
            using (var item = new UIInvoice())
            {
                item.ShowDialog();
            }
        }

        private void jButComprarTarjeta_Click(object sender, EventArgs e)
        {
            if (jCboCliente.SelectedIndex > -1 && ((Payment)jCboMetodoPago.SelectedItem).PaymentName == "Tarjeta Credito/Debito" && verificarDatosTarjeta())
            {
                InvoicePersistencia.correo = ((Customer)jCboCliente.SelectedItem).Email;
                comprar();
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");

            }
        }

        private void jTxtComprarEfectivo_Click(object sender, EventArgs e)
        {
            if (jCboCliente.SelectedIndex > -1 && ((Payment)jCboMetodoPago.SelectedItem).PaymentName == "Efectivo" && revisarEfectivo())
            {
                InvoicePersistencia.correo = ((Customer)jCboCliente.SelectedItem).Email;
                comprar();
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");

            }
        }

        private void jCash_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                double vuelto = InvoicePersistencia.total() - double.Parse(jCash.Text);
                jCambio.Text = vuelto.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((((Payment)jCboMetodoPago.SelectedItem).PaymentName== "Sinpe Movil" || ((Payment)jCboMetodoPago.SelectedItem).PaymentName == "Transferencia Bancaria")&& jCboCliente.SelectedIndex > -1)
            {
                InvoicePersistencia.correo = ((Customer)jCboCliente.SelectedItem).Email;
                comprar();
            }
            else
            {
                MessageBox.Show("Llene los datos correctamente", "Mensaje Informativo");

            }
        }
    }
}
