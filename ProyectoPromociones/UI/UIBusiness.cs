using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
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
    public partial class UIBusiness : Form
    {
        FactoryMaintenanceCreate factoryMaintenance = new FactoryMaintenanceCreate();
        FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        FactoryMaintenanceDelete factoryMaintenanceDelete = new FactoryMaintenanceDelete();
        Business business = new Business();
        public UIBusiness()
        {
            InitializeComponent();
            CargarProvincias();
            CentrarVentana();
            cargarBusiness();
        }


        private void cargarBusiness()
        {
            listBox1.Items.Clear();
            List<Business> Business = null;
            Business=factoryMaintenanceVisualize.GetBusiness();

            if(Business!=null)
            {
                foreach(Business business in Business)
                {
                    listBox1.Items.Add(business);
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

            foreach (Provincias item in lista)
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
            foreach (Distritos item in lista)
            {
                jCboDistrito.Items.Add(item);
            }
        }

        private byte[] GetImageBytesFromPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos requeridos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Devuelve un array vacío si no hay imagen
                return new byte[0];
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




        private void jButCreate_Click(object sender, EventArgs e)
        {
            if (RevisarDatos())
            {
                Provincias provincias = (Provincias)jCboProvincia.SelectedItem;
                Cantones cantones = (Cantones)jCboCanton.SelectedItem;
                Distritos distritos = (Distritos)jCboDistrito.SelectedItem;
                factoryMaintenance.CreateBusiness(this.jMskIdentificacion.Text, jTxtNombre.Text, jMskTelefono.Text, jTxtCorreo.Text,
                    GetImageBytesFromPictureBox(pictureBox1), jTxtMessage.Text,
                    factoryMaintenance.CreateAddress(provincias, cantones, distritos, jTxtDescription.Text)
                    );
            }
            cargarBusiness();
        }

        private void jCboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCantones();
        }

        private void jCboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDistritos();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void jButUpdate_Click(object sender, EventArgs e)
        {
             if (RevisarDatos())
                {
                    Provincias provincias = (Provincias)jCboProvincia.SelectedItem;
                    Cantones cantones = (Cantones)jCboCanton.SelectedItem;
                    Distritos distritos = (Distritos)jCboDistrito.SelectedItem;
                    factoryMaintenanceUpdate.CreateBusiness(business.IdBusiness, this.jMskIdentificacion.Text, jTxtNombre.Text, jMskTelefono.Text, jTxtCorreo.Text,
                   GetImageBytesFromPictureBox(pictureBox1), jTxtMessage.Text,
                   factoryMaintenanceUpdate.CreateAddress(business.Address.IdAddress, provincias, cantones, distritos, jTxtDescription.Text)
                   );
                }
            cargarBusiness();
        }
        private bool visualizar()
        {
            business = factoryMaintenanceVisualize.GetBusinessByFilter(jTxtNombre.Text);
            if (business != null)
            {
                jTxtCorreo.Text = business.Email;
                jTxtDescription.Text = business.Address.Description;
                jTxtMessage.Text = business.BillMessage;
                jTxtNombre.Text = business.Name;

                int indexProvincia = jCboProvincia.FindStringExact(business.Address.Provincia.provincia);
                if (indexProvincia != -1)
                {
                    jCboProvincia.SelectedIndex = indexProvincia;
                }

                if (jCboProvincia.SelectedIndex > -1)
                {
                    CargarCantones();

                    int indexCantones = jCboCanton.FindStringExact(business.Address.Canton.canton);
                    if (indexCantones != -1)
                    {
                        jCboCanton.SelectedIndex = indexCantones;
                    }

                    if (jCboCanton.SelectedIndex > -1)
                    {
                        CargarDistritos();

                        int indexDistritos = jCboDistrito.FindStringExact(business.Address.Distrito.distrito);
                        if (indexDistritos != -1)
                        {
                            jCboDistrito.SelectedIndex = indexDistritos;
                        }
                    }
                }
                jMskIdentificacion.Text=business.LegalID;
                jMskTelefono.Text = business.PhoneNumber;
                pictureBox1.Image= SetImageFromBytes(business.Photo);
               
                return true;
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el valor", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool RevisarDatos()
        {
            if (jTxtNombre.Text.Length > 0 && jTxtDescription.Text.Length > 0 && jTxtCorreo.Text.Length > 0 &&jTxtMessage.Text.Length>0
                 && jMskIdentificacion.Text.Length > 0 &&jMskTelefono.Text.Length>0&& jCboCanton.SelectedIndex > -1 &&
                 jCboDistrito.SelectedIndex > -1 && jCboProvincia.SelectedIndex > -1 && GetImageBytesFromPictureBox(pictureBox1).Length>0)
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
                if (RevisarDatos())
                {
                    factoryMaintenanceDelete.DeleteBusiness(business.IdBusiness.ToString());
                factoryMaintenanceDelete.DeleteAddress(business.Address.IdAddress.ToString());
            }
            cargarBusiness();
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
            jTxtNombre.Text=((Business)listBox1.SelectedItem).Name;

            visualizar();
        }
    }
}
