using ProyectoPromociones.Patrones;
using ProyectoPromociones.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Web.UI.WebControls;

namespace ProyectoPromociones.UI
{
    public partial class UIInvoice : Form
    {
        FacadeInovice FacadeInovice= new FacadeInovice();
        FactoryBuy FactoryBuy = new FactoryBuy();
        string rutaHtml = "";
        string rutaXml = "";
        string nombreArchivoPdf = "";
        public UIInvoice()
        {
            InitializeComponent();
            CentrarVentana();
            cargarFactura();
        }

        private void CentrarVentana()
        {
            // Centra la ventana en el centro de la pantalla principal.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void cargarFactura()
        {
            rutaXml = StackRuta.SacarUltimoElemento();
            rutaHtml = StackRuta.SacarUltimoElemento();

            FacadeInovice.TransformXMLToHTML(rutaXml, rutaHtml);

            // modo 1: mostrar en WebBrowser
            webBrowser1.Url = new Uri(rutaHtml);

            string nombreArchiv = Path.GetFileNameWithoutExtension(rutaHtml).Replace("HTML", "PDF") + ".pdf";
            string ruta = Application.StartupPath + "//Facturas";
            nombreArchivoPdf = Application.StartupPath + "//Facturas" + nombreArchiv.Replace(ruta, "");
            FactoryBuy.GenerarPDFDesdeHTML(rutaHtml, nombreArchivoPdf);
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abre la nueva ventana de manera modal
            using (var item = new Form1())
            {
                item.ShowDialog();
            }
        }


        private void jButEnviarFactura_Click(object sender, EventArgs e)
        {
            string toEmailAddress = InvoicePersistencia.correo;
            string subject = "Este correo fue enviado via C-sharp";
            string body = @"<style>
                    h1{color:dodgerblue;}
                    h2{color:darkorange;}
                    </style>
                    <h1>Factura Electronica por compra en La Pulpe</h1></br>";
            List<string> attachmentPaths = new List<string>();
            attachmentPaths.Add(rutaHtml);
            attachmentPaths.Add(rutaXml);
            attachmentPaths.Add(nombreArchivoPdf);//PONER PDF
            sendMail(toEmailAddress, subject, body, attachmentPaths);
        }

        public string sendMail(string to, string asunto, string body, List<string> attachmentPaths)
        {
            string msge = "Error al enviar este correo. Por favor verifique los datos o intente más tarde.";
            string from = "danii0399@hotmail.com";
            string displayName = "Daniela Mendez";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                foreach (var attachmentPath in attachmentPaths)
                {
                    if (File.Exists(attachmentPath))
                    {
                        Attachment attachment = new Attachment(attachmentPath);
                        mail.Attachments.Add(attachment);
                    }
                    else
                    {
                        Console.WriteLine($"Attachment not found at path: {attachmentPath}");
                    }
                }

                SmtpClient client = new SmtpClient("smtp.office365.com", 587); //Aquí debes sustituir tu servidor SMTP y el puerto
                client.Credentials = new NetworkCredential(from, "Kalabrice1199");
                client.EnableSsl = true;//En caso de que tu servidor de correo no utilice cifrado SSL,poner en false


                client.Send(mail);
                msge = "¡Correo enviado exitosamente! Pronto te contactaremos.";
                MessageBox.Show("¡Correo enviado exitosamente!", "Mensaje Informativo");

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }
        private void jButPDF_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
