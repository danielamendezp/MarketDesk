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
using ProyectoPromociones.Enum.ProyectoPromociones.Enum;

namespace ProyectoPromociones.Patrones
{
    public class FactoryMaintenanceCreate
    {
        /// <summary>
        /// METODOS PARA GUARDAR EN SQL
        /// </summary>
        public Product CreateProduct(string codigoBarras, string name, int existingQuantity, Category category, Supplier supplier, double cost, double profitPercentage, double tax, double listPrice, Usser usser, byte[] photo)
        {
            Product product = new Product();
              //  product.IdProduct = 1;
                product.CodigoBarras= codigoBarras;
                product.Photo = photo;
                product.ProfitPercentage = profitPercentage;
                product.Cost = cost;
                product.Category = category;
                product.ExistingQuantity = existingQuantity;
                product.ListPrice = listPrice;
                product.Name = name;
                product.Supplier = supplier;
                product.User = usser;
                product.Tax = tax;
            BLLProduct bllCategory = new BLLProduct();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCategory.SaveProduct(product);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            return product;
        }
        
        public Category CreateCategory(string name)
        {
            Category category = new Category ();
               // category.IdCategory = 1;//busscar bll
                category.Name = name;
            BLLCategory bllCategory = new BLLCategory ();

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCategory.SaveCategory(category);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            return category;
        }

        public Payment CreatePayment(string name)
        {
            Payment Payment = new Payment();
            //Payment.IdPayment = 1;//busscar bll
            Payment.PaymentName = name;
            BLLPayment bllPayment = new BLLPayment();

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllPayment.SavePayment(Payment);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            return Payment;
        } 
        public Supplier CreateSupplier(string name, string phoneNumber, string email)
        {
            Supplier supplier = new Supplier ();
                //supplier.IdSupplier = 1;//BUSCAR BLL
                supplier.Name = name;
                supplier.PhoneNumber = phoneNumber;
                supplier.Email = email;
            BLLSupplier bllSupplier = new BLLSupplier();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllSupplier.SaveSupplier(supplier);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            return supplier;
        }

        public Customer CreateCustomer(string identification, string name, Address address, string nationality, bool femenino, bool masculino, DateTime birth, string phoneNumber, string email, byte[] photo)
        {
            Customer customer = new Customer ();
            customer.Identification = identification;
                customer.Name = name;
                customer.Address = address;
                customer.Nationality = nationality;
                if (femenino)
                {
                    customer.Gender = "Femenino";
                }
                else if(masculino)
                {
                        customer.Gender = "Masculino";
                }
                customer.Birth = birth;
                customer.PhoneNumber = phoneNumber;
                customer.Email = email;
                customer.Photo = photo;
            customer.Address= address;
            BLLCustomer bllCustomer = new BLLCustomer();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCustomer.SaveCustomer(customer);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            return customer;
        }

        public Usser CreateUser(string userName, string personName, string password, string passwordValidation, EUser eTypeUser, bool active, DateTime lastLogin)
        {
            Usser usser = new Usser ();
            if (password == passwordValidation)
            {
                usser.UserName = userName;
                usser.Password = password;
                usser.PersonName = personName;
                usser.Password = password;
                usser.ETypeUser = eTypeUser;
                usser.Active = active;
                usser.LastLogin = lastLogin;

                BLLUsser bllUsser = new BLLUsser();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    // Se le coloca al Adaptador la conexion a la BD.
                    bllUsser.SaveUsser(usser);
                    MessageBox.Show("¡Guardado!", "Mensaje Informativo");
                }
                return usser;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje Informativo");
                return null;
            }     
           
        }

        public Address CreateAddress(Provincias provincias, Cantones cantones, Distritos distritos, string description)
        {
            FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
            Address address = new Address ();
                address.IdAddress = factoryMaintenanceVisualize.GetAddressLastRow();
                //address.IdAddress = 1;
                address.Provincia = provincias;
                address.Canton = cantones;
                address.Distrito = distritos;
                address.Description = description;
            BLLAddress bllAddress = new BLLAddress();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllAddress.SaveAddress(address);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
            }
            
            return address;
        }

        public Business CreateBusiness(string legalID, string name, string phoneNumber, string email, byte[] photo, string billMessage, Address adress)
        {
            Business business = new Business();
                business.BillMessage = billMessage;
                business.LegalID = legalID;
                business.Name = name;
                business.PhoneNumber = phoneNumber;
                business.Email = email;
                business.Photo = photo;
                business.Address = adress;
            BLLBusiness bllBusiness = new BLLBusiness();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                bllBusiness.SaveBusiness(business);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo"); 

            }
            return business;
        }
        public Promotion CreatePromotion(DateTime initialTime, DateTime finalTime, Product promotionProduct, Product giftPromotion, int qtyPromotionProduct, int qtyGiftPromotion, string description, double discount, double buyAmount)
        {
            Promotion promotion = new Promotion();

            BLLPromotion bllPromotion = new BLLPromotion();

            // Se asignan los valores proporcionados como parámetros
            promotion.InitialTime = initialTime;
            promotion.FinalTime = finalTime;
            promotion.PromotionProduct = promotionProduct;
            promotion.GiftPromotion = giftPromotion;
            promotion.QtyPromotionProduct = qtyPromotionProduct;
            promotion.QtyGiftPromotion = qtyGiftPromotion;
            promotion.Description = description;
            promotion.Discount = discount;
            promotion.BuyAmount = buyAmount;
            promotion.IdPromotion = 1;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                bllPromotion.SavePromotion(promotion);
                MessageBox.Show("¡Guardado!", "Mensaje Informativo");
                
            }

            return promotion;
        }


    }
}
