using ProyectoPromociones.BLL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Enum;
using ProyectoPromociones.Persistencia;
using ProyectoPromociones.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using log4net;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProyectoPromociones.UI;
using ProyectoPromociones.Interface;
using System.Net;
using ProyectoPromociones.DAL;
using Header = ProyectoPromociones.Entities.Header;

namespace ProyectoPromociones.Patrones
{
    public class FactoryMaintenanceVisualize
    {/// <summary>
     /// METODOS PARA VISUALIZAR EN SQL
     /// </summary>
        public List<Category> GetCategory()
        {
            BLLCategory bllCategory = new BLLCategory();
            List<Category> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllCategory devuelve IEnumerable<object>
                list = bllCategory.GetAllCategory().Result.ToList();
            }
            return list;
        }
        public Category GetCategoryById(int id)
        {
            BLLCategory bllCategory = new BLLCategory();
            Category category = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                category = bllCategory.GetCategoryById(id.ToString());
            }
            return category;
        }
        public Category GetCategoryByFilter(string nombre)
        {
            BLLCategory bllCategory = new BLLCategory();
            List<Category> listCategory = null;
            Category Category = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listCategory = bllCategory.GetCategoryByFilter(nombre);
            }
            foreach (Category item in listCategory)
            {
                if (nombre == item.Name)
                {
                    Category = item; break;
                }
                else
                {
                    Category = null;
                }
            }
            return Category;
        }

        public List<Payment> GetPayment()
        {
            BLLPayment bllPayment = new BLLPayment();
            List<Payment> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllPayment devuelve IEnumerable<object>
                list = bllPayment.GetAllPayment().Result.ToList();
            }
            return list;
        }
        public Payment GetPaymentById(int id)
        {
            BLLPayment bllPayment = new BLLPayment();
            Payment Payment = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                Payment = bllPayment.GetPaymentById(id.ToString());
            }
            return Payment;
        }
        public Payment GetPaymentByFilter(string nombre)
        {
            BLLPayment bllPayment = new BLLPayment();
            List<Payment> listPayment = null;
            Payment Payment = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listPayment = bllPayment.GetPaymentByFilter(nombre);
            }
            foreach (Payment item in listPayment)
            {
                if (nombre == item.PaymentName)
                {
                    Payment = item; break;
                }
                else
                {
                    Payment = null;
                }
            }
            return Payment;
        }

        public List<Supplier> GetSuppliers()
        {
            BLLSupplier bllSupplier = new BLLSupplier();
            List<Supplier> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllSupplier.GetAllSupplier().Result.ToList();
            }
            return list;
        }
        public List<Detail> GetDetails()
        {
            BLLDetail bllDetail = new BLLDetail();
            List<Detail> list = new List<Detail>();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllDetail devuelve IEnumerable<object>
                list = bllDetail.GetAllDetail().Result.ToList();
            }
            return list;
        }
        public List<Header> GetHeaders()
        {
            BLLHeader bllHeader = new BLLHeader();
            List<Header> list = new List<Header>();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllHeader.GetAllHeader().Result.ToList();
            }
            return list;
        }

        public List<Promotion> GetPromotions()
        {
            BLLPromotion bllPromotion = new BLLPromotion();
            List<Promotion> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllPromotion.GetAllPromotion().Result.ToList();
            }
            return list;
        }

        public List<Product> GetProducts()
        {
            BLLProduct bllProduct = new BLLProduct();
            List<Product> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllProduct.GetAllProduct().Result.ToList();
            }
            return list;
        }
        public List<Customer> GetCustomer()
        {
            BLLCustomer bllCustomer = new BLLCustomer();
            List<Customer> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllCustomer.GetAllCustomer().Result.ToList();
            }
            return list;
        }
        public List<Business> GetBusiness()
        {
            BLLBusiness bllBusiness = new BLLBusiness();
            List<Business> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllBusiness.GetAllBusiness().Result.ToList();
            }
            return list;
        }

        public List<Usser> GetUsser()
        {
            BLLUsser bllUsser = new BLLUsser();
            List<Usser> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllUsser.GetAllUsser().Result.ToList();
            }
            return list;
        }
        public List<Promotion> GetPromotionsByDate()
        {
            BLLPromotion bllPromotion = new BLLPromotion();
            List<Promotion> list = new List<Promotion>();
            List<Promotion> listDate = new List<Promotion>();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                list = bllPromotion.GetAllPromotion().Result.ToList();
            }

            foreach(var item in list)
            {
                if(item.FinalTime>DateTime.Now&& item.InitialTime < DateTime.Now)
                {
                    listDate.Add(item);
                }
            }
            return listDate;
        }

        public Supplier GetSupplierByFilter(string name)
        {
            BLLSupplier bllSupplier = new BLLSupplier();
            List<Supplier> listSupplier = null;
            Supplier Supplier = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listSupplier = bllSupplier.GetSupplierByFilter(name);
            }
            foreach (Supplier item in listSupplier)
            {
                if (name == item.Name)
                {
                    Supplier = item; break;
                }
                else
                {
                    Supplier = null;
                }
            }
            return Supplier;
        }
        public Supplier GetSupplierById(Supplier pSupplier)
        {
            BLLSupplier bllSupplier = new    BLLSupplier();
            Supplier supplier = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                supplier = bllSupplier.GetSupplierById(pSupplier.IdSupplier.ToString());
            }
            return supplier;
        }
        public Customer GetCustomerById(Customer pCustomer)
        {
            BLLCustomer bllCustomer = new BLLCustomer();
            Customer customer = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                customer = bllCustomer.GetCustomerById(pCustomer.IdCustomer.ToString());
            }
            return customer;
        }
        public Customer GetCustomerByFilter(string name)
        {
            BLLCustomer bllCustomer = new BLLCustomer();
            List<Customer> listCustomer = null;
            Customer Customer = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listCustomer = bllCustomer.GetCustomerByFilter(name);
            }
            foreach (Customer item in listCustomer)
            {
                if (name == item.Name)
                {
                    Customer = item; break;
                }
                else
                {
                    Customer = null;
                }
            }
            return Customer;
        }
        public Header GetHeaderById(Header pHeader)
        {
            BLLHeader bllHeader = new BLLHeader();
            Header header = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                header = bllHeader.GetHeaderById(pHeader.IdHeader.ToString());
            }
            return header;
        }

        public Header GetHeaderByFilter(DateTime fecha)
        {
            BLLHeader bllHeader =new BLLHeader();
            List<Header> listHeader = null;
            Header Header = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listHeader = bllHeader.GetHeaderByFilter(fecha.ToString());
            }
            foreach (Header item in listHeader)
            {
                if (fecha == item.IssueDate)
                {
                    Header = item; break;
                }
                else
                {
                    Header= null;
                }
            }
            return Header;
        }

        

        public Usser GetUserById(Usser pUser)
        {
            BLLUsser bllUser = new BLLUsser();
            Usser user = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                user = bllUser.GetUsserById(pUser.IdUsser.ToString());
            }
            return user;
        }
        public Usser GetUsserByFilter(string pUserName)
        {
            BLLUsser bllUsser = new BLLUsser();
            List<Usser> listUsser = null;
            Usser Usser = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listUsser = bllUsser.GetUsserByFilter(pUserName);
            }
            foreach (Usser item in listUsser)
            {
                if (pUserName == item.UserName || pUserName==item.PersonName)
                {
                    Usser = item; break;
                }
                else
                {
                    Usser = null;
                }
            }
            return Usser;
        }

        public Detail GetDetailById(Detail pDetail)
        {
            BLLDetail bllDetail = new BLLDetail();
            Detail detail = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                detail = bllDetail.GetDetailById(pDetail.IdDetail.ToString());
            }
            return detail;
        }

        public Address GetAddressById(Address pAddress)
        {
            BLLAddress bllAddress = null;
            Address address = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                address = bllAddress.GetAddressById(pAddress.IdAddress.ToString());
            }
            return address;
        }


        public int GetAddressLastRow()
        {
            int data = 0;
            int biggest = 0;
            BLLAddress bllAddress = new BLLAddress();
            List<Address> list = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Suponiendo que GetAllAddress devuelve IEnumerable<object>
                list = bllAddress.GetAllAddress().Result.ToList();
            }

            foreach (Address item in list)
            {

                if (item.IdAddress > biggest)
                {
                    data = item.IdAddress;
                }
                biggest = item.IdAddress;
            }
            return data+1;
        }

        public Product GetProductByFilter(string pCodigoBarras)
        {
            BLLProduct bllProduct = new BLLProduct();
            List<Product> listProduct = null;
            Product product = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listProduct = bllProduct.GetProductByFilter(pCodigoBarras.ToString());
            }
            foreach(Product item in listProduct)
            {
                if (pCodigoBarras == item.CodigoBarras)
                {
                    product = item; break;
                }
                else
                {
                    product = null;
                }
            }
            return product;
        }

        public Promotion GetPromotionById(int id)
        {
            BLLPromotion bllPromotion = null;
            Promotion Promotion = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                Promotion = bllPromotion.GetPromotionById(id.ToString());
            }
            return Promotion;

        }
        public Promotion GetPromotionByFilter(string description)
        {
            BLLPromotion bllPromotion = new BLLPromotion();
            List<Promotion> listPromotion = null;
            Promotion Promotion = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                listPromotion = bllPromotion.GetPromotionByFilter(description.ToString());
            }
            foreach (Promotion item in listPromotion)
            {
                if (description == item.Description)
                {
                    Promotion = item; break;
                }
                else
                {
                    Promotion = null;
                }
            }
            return Promotion;
        }

        public Product GetProductById(int id)
        {
            BLLProduct bllProduct = new BLLProduct();
            Product Product = null;

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                Product = bllProduct.GetProductById(id.ToString());
            }
            return Product;

        }
        public Business GetBusinessByFilter(string nombre)
            {
                BLLBusiness bllBusiness = new BLLBusiness();
            List<Business> listBusiness = null;
            Business Business = null;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    listBusiness = bllBusiness.GetBusinessByFilter(nombre);
                }
                foreach (Business item in listBusiness)
                {
                    if (nombre == item.Name)
                    {
                        Business = item; break;
                    }
                    else
                    {
                        Business = null;
                    }
                }
                return Business;
            }
        public List<Detail> GetDetailsByFilter(int id)
        {
            BLLDetail bllDetail= new BLLDetail();
            List<Detail> listDetail= new List<Detail>();
            List<Detail> lista = new List<Detail>();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {

                listDetail= bllDetail.GetDetailByFilter(id.ToString());
            }
            foreach (Detail item in listDetail)
            {
                if (id == item.Header.IdHeader)
                {
                    lista.Add( item); 
                }
            }
            return lista;
        }
    }
}
