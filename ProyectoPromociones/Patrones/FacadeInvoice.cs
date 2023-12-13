using ProyectoPromociones.Entities;
using ProyectoPromociones.UI;
using ProyectoPromociones.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoPromociones.Patrones
{
    public class FacadeInovice
    {
        /// <summary>
        /// GENERAR FACTURA XML
        /// </summary>
        public string XmlGenerate(string carpeta, List<Detail> listaDetails, List<Promotion> listaPromociones, Header header, double Subtotal, double Taxes, double Discount, double Total, double SubtotalUSD, double TaxesUSD, double DiscountUSD, double TotalUSD)
        {
            // Asegúrate de que la carpeta exista antes de intentar guardar el archivo
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            // Genera un nombre de archivo único basado en el número de factura
            string nombreArchivo = $"Factura_{header.IdHeader}.xml";
            string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration dec = xmlDoc.CreateXmlDeclaration("1.0", null, null);
            xmlDoc.AppendChild(dec);// Se crea la raiz

            string rutaXslt = System.Windows.Forms.Application.StartupPath + "\\Xslt\\factura.xslt";
            XmlProcessingInstruction xslt = xmlDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXslt + "\"");
            xmlDoc.AppendChild(xslt);

            var nMarketDesk = xmlDoc.CreateElement("MarketDesk");
            var nHeader = xmlDoc.CreateElement("DatosFacturacion");
            var nBusiness = xmlDoc.CreateElement("Negocio");
            var nCustomer = xmlDoc.CreateElement("Cliente");
            var nProducts = xmlDoc.CreateElement("Productos");
            

            xmlDoc.AppendChild(nMarketDesk);
            nMarketDesk.AppendChild(nHeader);
            nMarketDesk.AppendChild(nBusiness);
            nMarketDesk.AppendChild(nCustomer);
            nMarketDesk.AppendChild(nProducts);
            

            nHeader.SetAttribute("NumeroFactura", header.IdHeader.ToString());
            nHeader.SetAttribute("FechaEmision", header.IssueDate.ToString());
            nBusiness.SetAttribute("Negocio", header.Business.Name);
            nBusiness.SetAttribute("CedulaJuridica", header.Business.LegalID);
            nCustomer.SetAttribute("Nombre", header.Customer.Name);
            nCustomer.SetAttribute("Identificación", header.Customer.Identification);
            nCustomer.SetAttribute("Email", header.Customer.Email);
            nCustomer.SetAttribute("Celular", header.Customer.PhoneNumber.ToString());
            
            foreach(Detail item in listaDetails){
                var nProduct = xmlDoc.CreateElement("Producto");
                nProducts.AppendChild(nProduct);
                nProduct.SetAttribute("Producto", item.Product.Name);
                nProduct.SetAttribute("Cantidad", item.ProductQuantity.ToString());
                nProduct.SetAttribute("PrecioUnitario", item.Product.ListPrice.ToString());
                nProduct.SetAttribute("PrecioTotal", (item.Product.ListPrice*item.ProductQuantity).ToString());
            }

            foreach(var item in listaPromociones)
            {
                var nPromotion = xmlDoc.CreateElement("Promociones");
                nProducts.AppendChild(nPromotion);
                nPromotion.InnerText = item.Description;
            }

            var nSubtotal = xmlDoc.CreateElement("SubTotal");
            var nTaxes = xmlDoc.CreateElement("Impuestos");
            var nDiscount = xmlDoc.CreateElement("Descuentos");
            var nTotal = xmlDoc.CreateElement("Total");
            nProducts.AppendChild(nSubtotal);
            nProducts.AppendChild(nTaxes);
            nProducts.AppendChild(nDiscount);
            nProducts.AppendChild(nTotal);

            nSubtotal.InnerText = Subtotal.ToString();
            nTaxes.InnerText = Taxes.ToString();
            nDiscount.InnerText = Discount.ToString();
            nTotal.InnerText = Total.ToString();

            var nSubtotalUSD = xmlDoc.CreateElement("SubTotalUSD");
            var nTaxesUSD = xmlDoc.CreateElement("ImpuestosUSD");
            var nDiscountUSD = xmlDoc.CreateElement("DescuentosUSD");
            var nTotalUSD = xmlDoc.CreateElement("TotalUSD");
            nProducts.AppendChild(nSubtotalUSD);
            nProducts.AppendChild(nTaxesUSD);
            nProducts.AppendChild(nDiscountUSD);
            nProducts.AppendChild(nTotalUSD);

            nSubtotalUSD.InnerText = SubtotalUSD.ToString();
            nTaxesUSD.InnerText = TaxesUSD.ToString();
            nDiscountUSD.InnerText = DiscountUSD.ToString();
            nTotalUSD.InnerText = TotalUSD.ToString();

            xmlDoc.Save(rutaCompleta);

            return rutaCompleta;
        }

        public void TransformXMLToHTML(string rutaXML, string rutaHtml)
        {
            string rutaXslt = Application.StartupPath + "\\Xslt\\factura.xslt";
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load(rutaXslt);
            myXslTrans.Transform(rutaXML, rutaHtml);
        }
    }
}
