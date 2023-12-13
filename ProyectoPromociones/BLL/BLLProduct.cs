using ProyectoPromociones.DAL;
using ProyectoPromociones.Entities;
using ProyectoPromociones.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.BLL
{
    public class BLLProduct : IBLLProduct
    {
        public List<Product> GetProductByFilter(string pDescripcion)
        {
            IDALProduct _DALProduct = new DALProduct();
            return _DALProduct.GetProductByFilter(pDescripcion);
        }

        public Product GetProductById(string pIdProduct)
        {
            IDALProduct _DALProduct = new DALProduct();
            return _DALProduct.GetProductById(pIdProduct);
        }


        public Task<IEnumerable<Product>> GetAllProduct()
        {
            IDALProduct _DALProduct = new DALProduct();
            return _DALProduct.GetAllProduct();
        }

        public Task<Product> SaveProduct(Product pProduct)
        {
            IDALProduct _DALProduct = new DALProduct();
            Task<Product> oProduct = null;

            if (_DALProduct.GetProductById(pProduct.IdProduct.ToString()) == null)
                oProduct = _DALProduct.SaveProduct(pProduct);
            else
                oProduct = _DALProduct.UpdateProduct(pProduct);

            return oProduct;
        }

        public Task<bool> DeleteProduct(string pId)
        {
            IDALProduct _DALProduct = new DALProduct();

            return _DALProduct.DeleteProduct(pId);

        }

        public Task<Product> UpdateProduct(Product pProduct)
        {
            IDALProduct _DALProduct = new DALProduct();
            Task<Product> oProduct = null;

            oProduct = _DALProduct.UpdateProduct(pProduct);

            return oProduct;

        }
    }
}
