using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;
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
    public partial class UICreateUpdateUser : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Usser usser = new Usser();
        public UICreateUpdateUser()
        {

            InitializeComponent();
            jTxtPassword.PasswordChar = '*';
            jTxtPasswordVerification.PasswordChar = '*';
            cargarTipoUsuario();
            CentrarVentana();
            cargarUsser();
        }


        private void cargarUsser()
        {
            listBox1.Items.Clear();
            List<Usser> Usser = null;
            Usser = factoryMaintenanceVisualize.GetUsser();

            if (Usser != null)
            {
                foreach (Usser item in Usser)
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

        private void cargarTipoUsuario()
        {

            jCboUserType.Items.Add(EUser.Administrador);
            jCboUserType.Items.Add(EUser.Cajero);
            jCboUserType.Items.Add(EUser.JefeCajas);
        }

        private void jTxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void jTxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jTxtPassword.Select();
            }
        }

        private void jTxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jTxtPasswordVerification.Select();
            }
        }

        private bool RevisarDatos()
        {
            if (jTxtPassword.Text.Length > 0 &&
                jTxtPasswordVerification.Text.Length > 0 &&
                jTxtUser.Text.Length > 0 &&
                jTxtUserName.Text.Length > 0 && jCboUserType.SelectedIndex >-1)
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
        private bool visualizar()
        {
            usser = factoryMaintenanceVisualize.GetUsserByFilter(jTxtUserName.Text);
            if (usser != null)
            {
                jTxtUser.Text = usser.UserName;
                jTxtUserName.Text = usser.PersonName;
                jTxtPassword.Text = usser.Password;
                jTxtPasswordVerification.Text = usser.Password;
                jCboUserType.SelectedItem = usser.ETypeUser;
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro el valor", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jTxtUserName.Text = ((Usser)listBox1.SelectedItem).PersonName;

            visualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                factoryMaintenance.CreateUser(jTxtUser.Text, jTxtUserName.Text, jTxtPassword.Text, jTxtPasswordVerification.Text, (EUser)jCboUserType.SelectedItem, true, DateTime.Now);
            }
            cargarUsser();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (RevisarDatos())
            {

                factoryMaintenanceUpdate.CreateUser(usser.IdUsser, jTxtUser.Text, jTxtUserName.Text, jTxtPassword.Text, jTxtPasswordVerification.Text, (EUser)jCboUserType.SelectedItem, true, DateTime.Now);

            }
            cargarUsser();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (RevisarDatos())
            {

                factoryMaintenanceDelete.DeleteUser(usser);

            }
            cargarUsser();
        }
    }
}
