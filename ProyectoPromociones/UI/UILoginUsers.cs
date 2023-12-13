using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Patrones;
using ProyectoPromociones.Util;
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
    public partial class UILoginUsers : Form
    {
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceUpdate FactoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        Usser usser = new Usser();
        public UILoginUsers()
        {
            InitializeComponent();
            CentrarVentana();
            jTxtPassword.PasswordChar = '*';
        }

        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UILoginUsers_Load(object sender, EventArgs e)
        {

        }
        private bool datosCorrectos()
        {
            usser = factoryMaintenanceVisualize.GetUsserByFilter(jTxtUser.Text);
            if (usser != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "Mensaje informativo");
                return false;
            }
        }
        private void jButLogIn_Click(object sender, EventArgs e)
        {

            if (datosCorrectos() && usser.Password.Equals(jTxtPassword.Text))
            {
                Stack.AgregarElemento(usser);
                //FactoryMaintenanceUpdate.CreateUser(usser.IdUsser, usser.UserName, usser.PersonName, usser.Password, usser.Password, usser.ETypeUser, true, DateTime.Now);
                this.Hide();
            }
            else {
                MessageBox.Show("Contraseña incorrecta", "Mensaje informativo");
            }
        }

        private bool revisarDatos()
        {
            if (jTxtPassword.Text.Length > 0 && jTxtUser.Text.Length > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el valor", "Mensaje informativo");
                return false;
            }
        }

        private void jTxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (datosCorrectos() && jTxtPassword.Text == usser.Password)
                {

                    Stack.AgregarElemento(usser);
                    //FactoryMaintenanceUpdate.CreateUser(usser.IdUsser, usser.UserName, usser.PersonName, usser.Password, usser.Password, usser.ETypeUser, true, DateTime.Now);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Mensaje informativo");
                }
            }
        }

        private void jTxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jTxtPassword.Select();
            }
        }
    }
}
