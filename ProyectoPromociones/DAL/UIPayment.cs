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
        public UIPayment()
        {
            InitializeComponent();
            CentrarVentana();
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
            this.Hide();
            using (var item = new UIPromotion())
            {
                item.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var item = new UIInvoice())
            {
                item.ShowDialog();
            }
        }

        private void jButComprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var item = new UIInvoice())
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
    }
}
