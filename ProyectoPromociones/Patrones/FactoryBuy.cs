using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.UI;
using ProyectoPromociones.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Header = ProyectoPromociones.Entities.Header;

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDF.Elements;
using iText.Html2pdf;
using TestStack.BDDfy.Reporters;
using static QuestPDF.Helpers.Colors;

namespace ProyectoPromociones.Patrones
{
    public class FactoryBuy
    {
        public List<Detail> details = new List<Detail>();
        FacadeInovice invoice= new FacadeInovice();

        /// <summary>
        /// DATOS DE FACTURACION
        /// </summary>
        public void CreateDetail(Detail detail)
        {
            details.Add(detail);
        }
        /// <summary>
        /// DATOS DE FACTURACION
        /// </summary>
        public void DescontarProductoInventario(List<Product> listaProductos, List<int> listaCantidades) 
        {
            int i = 0;
            FactoryMaintenanceUpdate factoryMaintenanceUpdate = new FactoryMaintenanceUpdate();
            foreach(Product product in listaProductos)
            {

                factoryMaintenanceUpdate.CreateProduct(product.IdProduct, product.CodigoBarras, product.Name, product.ExistingQuantity - listaCantidades[i], 
                    product.Category, product.Supplier,
                    product.Cost, product.ProfitPercentage, product.Tax, product.ListPrice, product.User, product.Photo);
                i++;
            }
        }
        /// <summary>
        /// DATOS DE FACTURACION
        /// </summary>
        public double CambioDolar(double monto)
        {
            // Suponiendo que compraOVenta es una propiedad o variable que contiene "c" o "v"
            string compraOVenta = "c"; // Reemplaza esto con el valor correcto

            ServiceBCCR services = new ServiceBCCR();

            // Llamas al método GetDolar y obtienes el resultado
            IEnumerable<Dolar> resultado = services.GetDolar(DateTime.Now, DateTime.Now, compraOVenta);
            Dolar tipoCambio = resultado.FirstOrDefault();

            double montoDolares = monto / tipoCambio.Monto;
            return montoDolares;
        }
        public void GenerarPDFDesdeHTML(string rutaHTML, string rutaPDF)
         {
             // Configuración de la licencia de QuestPDF
             QuestPDF.Settings.License = LicenseType.Community;

             // Configuración de la fuente de fallback para el glifo U-0009
             var fallbackFont = "Arial"; // Puedes cambiar "Arial" por la fuente que desees utilizar

             // Desactivar la comprobación de glifos (opcional)
             QuestPDF.Settings.CheckIfAllTextGlyphsAreAvailable = false;

             // Crear el documento PDF
             Document.Create(container =>
             {
                 container.Page(page =>
                 {
                     // Configuración de la página
                     page.Size(PageSizes.A4);
                     page.Margin(2, QuestPDF.Infrastructure.Unit.Centimetre);
                     page.PageColor(Colors.White);

                     // Contenido de la página
                     page.Content()
                         .PaddingVertical(1, QuestPDF.Infrastructure.Unit.Centimetre)
                         .Column(x =>
                         {
                             x.Spacing(20);
                             // Configuración del texto con el estilo de texto que incluye Fallback
                             x.Item().Text(File.ReadAllText(rutaHTML));
                         });
                 });
             })
             .GeneratePdf(rutaPDF); // Generar el PDF en la ruta especificada
         }
        /*public void GenerarPDFDesdeHTML(string rutaHTML, string rutaPDF)
        {
            var htmlContent = File.ReadAllText(rutaHTML);

            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10, Bottom = 10 }
            };

            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontName = "Arial", FontSize = 12, Right = "Página [page] de [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 12, Line = true, Center = "Centro", Right = "Derecha" }
            };

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };

            var fileBytes = _converter.Convert(pdf);***

            File.WriteAllBytes(rutaPDF, fileBytes);
        }*/

        /*public void GenerarPDFDesdeHTML(string rutaHTML, string rutaPDF)
        {
                ConverterProperties prop = new ConverterProperties();
                prop.SetBaseUri("http://localhost");
                HtmlConverter.ConvertToPdf(File.ReadAllText(rutaHTML), new FileStream(rutaPDF, FileMode.Create), prop);
            
        }*/
        public void GenerarDetails(List<Product> listaProductos, List<int> listaCantidades, List<Promotion> promotions, Customer customer, Business business, Payment payment, double subtotal, double descuento, double total)
        {
            int i = 0;
            Header header=CreateHeader(customer, business, payment);
            List<Detail> details = new List<Detail>();
            double taxes = 0;
            foreach (Product product in listaProductos)
            {
                details.Add(CreateDetail(listaCantidades[i], product, header));
                taxes+= listaCantidades[i]*(product.ListPrice*product.Tax);
                i++;
            }

            string carpeta = Path.Combine(Application.StartupPath, "Facturas");

            string nombreArchivo =invoice.XmlGenerate(carpeta, details, promotions, header, subtotal, taxes, descuento, total, CambioDolar(subtotal), CambioDolar(taxes), 
                CambioDolar(descuento), CambioDolar(total));

            string nombreArchivoHML = $"HTMLFactura_{header.IdHeader}.html";
            string rutaCompletaHTML = Path.Combine(carpeta, nombreArchivoHML);

            StackRuta.AgregarElemento(rutaCompletaHTML);
            StackRuta.AgregarElemento(nombreArchivo);
            
        }

        private Detail CreateDetail(int ProductQuantity, Product product, Header header)
        {
            Detail detail = new Detail();
            detail.IdDetail = GetDetailLastRow();
            detail.Product = product;
            detail.ProductQuantity = ProductQuantity;
            detail.Header = header;

            BLLDetail bllDetail = new BLLDetail();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                bllDetail.SaveDetail(detail);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");

            }

            return detail;
        }

        private int GetDetailLastRow()
        {
            int data = 0;
            int biggest = 0;
            BLLDetail bllDetail = new BLLDetail();
            List<Detail> list = new List<Detail>();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllDetail devuelve IEnumerable<object>
                list = bllDetail.GetAllDetail().Result.ToList();
            }

            foreach (Detail item in list)
            {

                if (item.IdDetail > biggest)
                {
                    data = item.IdDetail;
                }
                biggest = item.IdDetail;
            }
            return data+1;
        }

        private Header CreateHeader(Customer customer, Business business, Payment payment)
        {
            Header header = new Header();
            header.IdHeader = GetHeaderLastRow();
            header.Customer = customer;
            header.Business = business;
            header.Payment = payment;
            header.State = true;
            header.IssueDate = DateTime.Now;
            BLLHeader bllHeader = new BLLHeader();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                bllHeader.SaveHeader(header);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");

            }

            return header;
        }

        public void CancelarHeader(Header pheader)
        {
            FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
            pheader.State = false;
            Header header = pheader;
            BLLHeader bllHeader = new BLLHeader();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                bllHeader.UpdateHeader(header);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");

            }
            CancelarDetail(factoryMaintenanceVisualize.GetDetailsByFilter(pheader.IdHeader));

        }

        

        public void CancelarDetail(List<Detail> listaDetalles)
        {
            FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
            List<Product> products=factoryMaintenanceVisualize.GetProducts();
            foreach (Detail d in listaDetalles)
            {
                foreach (Product p in products)
                {
                    if (d.Product.IdProduct==p.IdProduct)
                    {
                        p.ExistingQuantity = d.Product.ExistingQuantity+d.ProductQuantity;
                        BLLProduct bllProduct = new BLLProduct();
                        using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                        {
                            bllProduct.UpdateProduct(p);
                        }
                    }
                }
            }
        }

        private int GetHeaderLastRow()
        {
            int data = 0;
            int biggest = 0;
            BLLHeader bllHeader = new BLLHeader();
            List<Header> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllHeader devuelve IEnumerable<object>
                list = bllHeader.GetAllHeader().Result.ToList();
            }

            foreach (Header item in list)
            {

                if (item.IdHeader > biggest)
                {
                    data = item.IdHeader;
                }
                biggest = item.IdHeader;
            }
            return data+1;
        }
    }
}
