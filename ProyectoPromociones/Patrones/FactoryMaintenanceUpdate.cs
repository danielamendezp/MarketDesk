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
    public class FactoryMaintenanceUpdate
    {
        /// <summary>
        /// METODOS PARA ACTUALIZAR EN SQL
        /// </summary>
        public Product CreateProduct(int id,string codigoBarras, string name, int existingQuantity, Category category, Supplier supplier, double cost, double profitPercentage, double tax, double listPrice, Usser usser, byte[] photo)
        {
            Product product = new Product();
                product.IdProduct = id;//BUSCAR CONSECUTIVO EN BLL
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
                bllCategory.UpdateProduct(product);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return product;
        }
        
        public Category CreateCategory(int id, string name)
        {
            Category category = new Category ();
                category.IdCategory =id;//busscar bll
                category.Name = name;
            BLLCategory bllCategory = new BLLCategory ();

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCategory.UpdateCategory(category);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return category;
        }

        public Payment CreatePayment(int id, string name)
        {
            Payment Payment = new Payment();
            Payment.IdPayment = id;//busscar bll
            Payment.PaymentName = name;
            BLLPayment bllPayment = new BLLPayment();

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllPayment.UpdatePayment(Payment);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return Payment;
        }
        
        public Supplier CreateSupplier(int id, string name, string phoneNumber, string email)
        {
            Supplier supplier = new Supplier ();
                supplier.IdSupplier = id;//BUSCAR BLL
                supplier.Name = name;
                supplier.PhoneNumber = phoneNumber;
                supplier.Email = email;
            BLLSupplier bllSupplier = new BLLSupplier();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllSupplier.UpdateSupplier(supplier);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return supplier;
        }

        public Customer CreateCustomer(int id,string identification, string name, Address address, string nationality, bool femenino, bool masculino, DateTime birth, string phoneNumber, string email, byte[] photo)
        {
            Customer customer = new Customer ();
                customer.IdCustomer = id;
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

            BLLCustomer bllCustomer = new BLLCustomer();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllCustomer.UpdateCustomer(customer);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return customer;
        }

        public Usser CreateUser(int id, string userName, string personName, string password, string passwordValidation, EUser eTypeUser, bool active, DateTime lastLogin)
        {
            Usser usser = new Usser ();
            if (password == passwordValidation)
            {
                usser.IdUsser = id;
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
                    bllUsser.UpdateUsser(usser);
                    MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
                }
                
                return usser;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Mensaje Informativo");
                return null;
            }
        }

        public Address CreateAddress(int id,Provincias provincias, Cantones cantones, Distritos distritos, string description)
        {
            Address address = new Address ();
                address.IdAddress = id;//HAY QUE GENERAR
                address.Provincia = provincias;
                address.Canton = cantones;
                address.Distrito = distritos;
                address.Description = description;
            BLLAddress bllAddress = new BLLAddress();
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexion a la BD.
                bllAddress.UpdateAddress(address);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return address;
        }

        public Business CreateBusiness(int id, string legalID, string name, string phoneNumber, string email, byte[] photo, string billMessage, Address adress)
        {
            Business business = new Business();
            business.IdBusiness = id;
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
                // Se le coloca al Adaptador la conexion a la BD.
                bllBusiness.UpdateBusiness(business);
                MessageBox.Show("¡Actualizado!", "Mensaje Informativo");
            }
            return business;
        }

        public Promotion CreatePromotion(int id,DateTime initialTime, DateTime finalTime, Product promotionProduct, Product giftPromotion, int qtyPromotionProduct, int qtyGiftPromotion, string description, double discount, double buyAmount)
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
            promotion.IdPromotion= id;
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                // Se le coloca al Adaptador la conexión a la BD.
                if (bllPromotion.UpdatePromotion(promotion) != null)
                {
                    MessageBox.Show("¡Guardado!", "Mensaje Informativo");
                }
            }

            return promotion;
        }
    }
}
