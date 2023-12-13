using ProyectoPromociones.Entities;
using ProyectoPromociones.Patrones;
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
    public partial class UICustomer : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Customer customer = new Customer();
        public UICustomer()
        {
            InitializeComponent();
            CargarProvincias();
            CentrarVentana();
            cargarCustomer();
        }
        private void cargarCustomer()
        {
            listBox1.Items.Clear();
            List<Customer> Customer = null;
            Customer = factoryMaintenanceVisualize.GetCustomer();

            if (Customer != null)
            {
                foreach (Customer customer in Customer)
                {
                    listBox1.Items.Add(customer);
                }
            }
        }
        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void CargarProvincias()
        {
            FacadeAddress facadeAddress = new FacadeAddress();
            List<Provincias> lista = facadeAddress.GetProvincias();
           
            foreach (var item in lista)
            {
                jCboProvincia.Items.Add(item);
            }
        }
        private void CargarCantones()
        {
            jCboCanton.Items.Clear();
            FacadeAddress facadeAddress = new FacadeAddress();
            List<Cantones> lista = facadeAddress.ObtenerCantones(int.Parse(((Provincias)jCboProvincia.SelectedItem).id));
            foreach (Cantones item in lista)
            {
                jCboCanton.Items.Add(item);
            }
        }

         private void CargarDistritos()
         {
            jCboDistrito.Items.Clear();
             FacadeAddress facadeAddress = new FacadeAddress();
             List<Distritos> lista = facadeAddress.ObtenerDistrito(int.Parse(((Provincias)jCboProvincia.SelectedItem).id), ((Cantones)jCboCanton.SelectedItem).id);
             foreach (var item in lista)
             {
                 jCboDistrito.Items.Add(item);
             }
        }
     
        private void jButCreate_Click(object sender, EventArgs e)
        {
            if (revisarDatos())
            {
                Provincias provincias = (Provincias)jCboProvincia.SelectedItem;
                Cantones cantones = (Cantones)jCboCanton.SelectedItem;
                Distritos distritos = (Distritos)jCboDistrito.SelectedItem;

                factoryMaintenance.CreateCustomer(jMskIdentificacion.Text, jTxtNombre.Text,
                    factoryMaintenance.CreateAddress(provincias, cantones, distritos, jTxtDescription.Text), 
                    jTxtNacionality.Text, jButFemenine.Checked, jButMasculine.Checked, jDateBirth.Value, jMskPhoneNumber.Text, 
                    jTxtEmail.Text, GetImageBytesFromPictureBox(pictureBox1));
            }
            cargarCustomer();
        }

        private void jCboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCantones();
        }

        private void jCboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
           CargarDistritos();
        }


        private byte[] GetImageBytesFromPictureBox(PictureBox pictureBox)
        {
            Image image = pictureBox.Image;
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, image.RawFormat);
                    return ms.ToArray();
                }
            }

            // Devuelve un array vacío si no hay imagen
            return new byte[0];

        }

        private void button1_Click_1(object sender, EventArgs e)
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
        private void jButUpdate_Click(object sender, EventArgs e)
        {
            if (revisarDatos())
            {
                Provincias provincias = (Provincias)jCboProvincia.SelectedItem;
                Cantones cantones = (Cantones)jCboCanton.SelectedItem;
                Distritos distritos = (Distritos)jCboDistrito.SelectedItem;

                factoryMaintenanceUpdate.CreateCustomer(customer.IdCustomer, jMskIdentificacion.Text, jTxtNombre.Text, 
                    factoryMaintenanceUpdate.CreateAddress( customer.Address.IdAddress,provincias, cantones, distritos, jTxtDescription.Text), 
                    jTxtNacionality.Text, jButFemenine.Checked,
                    jButMasculine.Checked, jDateBirth.Value, jMskPhoneNumber.Text, jTxtEmail.Text, GetImageBytesFromPictureBox(pictureBox1));
                
            }
            cargarCustomer();
        }
        private bool visualizar()
        {
            customer = factoryMaintenanceVisualize.GetCustomerByFilter(jTxtNombre.Text);
            if(customer != null)
            {
                jTxtNombre.Text = customer.Name;
                jTxtNacionality.Text = customer.Nationality;
                jTxtEmail.Text = customer.Email;
                jTxtDescription.Text = customer.Address.Description;

                int indexProvincia = jCboProvincia.FindStringExact(customer.Address.Provincia.provincia);
                if (indexProvincia != -1)
                {
                    jCboProvincia.SelectedIndex = indexProvincia;
                }

                if (jCboProvincia.SelectedIndex > -1)
                {
                    CargarCantones();

                    int indexCantones = jCboCanton.FindStringExact(customer.Address.Canton.canton);
                    if (indexCantones != -1)
                    {
                        jCboCanton.SelectedIndex = indexCantones;
                    }

                    if (jCboCanton.SelectedIndex > -1)
                    {
                        CargarDistritos();

                        int indexDistritos = jCboDistrito.FindStringExact(customer.Address.Distrito.distrito);
                        if (indexDistritos != -1)
                        {
                            jCboDistrito.SelectedIndex = indexDistritos;
                        }
                    }
                }

                if (customer.Gender == "Femenino")
                {
                    jButFemenine.Select();
                }
                else
                {
                    jButMasculine.Select();
                }

                jMskPhoneNumber.Text = customer.PhoneNumber;
                jMskIdentificacion.Text = customer.Identification;
                jDateBirth.Value = customer.Birth;
                pictureBox1.Image = SetImageFromBytes(customer.Photo);
                return true;
            }
            else
            {
                MessageBox.Show("No se encontro el valor", "Mensaje Informativo");
                return false;
            }
        }

        private bool revisarDatos()
        {
            if (jTxtNombre.Text.Length>0 && jTxtDescription.Text.Length>0&& jTxtEmail.Text.Length>0&&jTxtNacionality.Text.Length>0
                &&(jButMasculine.Checked||jButFemenine.Checked)&&jMskIdentificacion.Text.Length>0&&jMskPhoneNumber.Text.Length>0&& jCboCanton.SelectedIndex>-1&&
                jCboDistrito.SelectedIndex>-1&&jCboProvincia.SelectedIndex>-1&&jDateBirth.Value!=null && GetImageBytesFromPictureBox(pictureBox1).Length>0)
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
            if (revisarDatos())
            {
                
                    factoryMaintenanceDelete.DeleteCustomer(customer.IdCustomer.ToString());
                   factoryMaintenanceDelete.DeleteAddress(customer.Address.IdAddress.ToString());
            }
            cargarCustomer();
        }

        private void jTxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                visualizar();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            jTxtNombre.Text = ((Customer)listBox1.SelectedItem).Name;

            visualizar();
        }
    }
}
