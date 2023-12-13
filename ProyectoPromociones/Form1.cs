using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;
using ProyectoPromociones.UI;
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

namespace ProyectoPromociones
{
    public partial class Form1 : Form
    {
        Usser user = null;
        public Form1()
        {
            InitializeComponent();
            CentrarVentana();
        }

        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
            using (var uiBuy = new UILoginUsers())
            {
                uiBuy.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void agregaNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIBusiness())
                {
                    item.ShowDialog();
                }
            }
        }

        private void registrarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null )
            {
                this.Hide();

                // Abre la nueva ventana de manera modal
                using (var uiBuy = new UIBuy())
                {
                    uiBuy.ShowDialog();
                }
            }

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador || user.ETypeUser == EUser.JefeCajas))
            {
                using (var item = new UICustomer())
                {
                    item.ShowDialog();
                }
            }
        }


        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIMantProductInInventory())
                {
                    item.ShowDialog();
                }
            }
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIMantSupplier())
                {
                    item.ShowDialog();
                }
            }

          
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIMantCategory())
                {
                    item.ShowDialog();
                }
            }
        }

        private void actualizaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UICreateUpdateUser())
                {
                    item.ShowDialog();
                }
            }
        }

        private void agregarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador || user.ETypeUser == EUser.JefeCajas))
            {
                using (var item = new UICustomer())
                {
                    item.ShowDialog();
                }
            }
        }

        private void agregarNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIBusiness())
                {
                    item.ShowDialog();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelaFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador|| user.ETypeUser == EUser.JefeCajas))
            {
                using (var item = new UIInvoiceCancelation())
                {
                    item.ShowDialog();
                }
            }
        }

        private void agregarTipoPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIMantPagos())
                {
                    item.ShowDialog();
                }
            }
        }

        private void mantenimientoPromocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void promocionRegaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIPromotionGift())
                {
                    item.ShowDialog();
                }
            }
        }

        private void promociónDescuentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && (user.ETypeUser == EUser.Administrador))
            {
                using (var item = new UIUpdatePromotion())
                {
                    item.ShowDialog();
                }
            }
        }

        private void reportePromocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && user.ETypeUser == EUser.Administrador)
            {
                using (var item = new UIReport())
                {
                    item.ShowDialog();
                }
            }
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && user.ETypeUser == EUser.Administrador)
            {
               using (var item = new UIReportVentas())
                {
                    item.ShowDialog();
                }
            }
        }

        private void reporteVentasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && user.ETypeUser == EUser.Administrador)
            {
                using (var item = new UIReporteVentasTotal())
                {
                    item.ShowDialog();
                }
            }
        }

        private void graficoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user = Stack.VerUltimoElemento();
            if (user != null && user.ETypeUser == EUser.Administrador)
            {
                using (var item = new UIReporteVentasDia())
                {
                    item.ShowDialog();
                }
            }
        }
    }
}
