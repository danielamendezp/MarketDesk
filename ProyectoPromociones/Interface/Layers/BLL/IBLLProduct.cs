using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLProduct
    {

        List<Product> GetProductByFilter(string pDescripcion);
        Product GetProductById(string pIdProduct);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> SaveProduct(Product pProduct);
        Task<bool> DeleteProduct(string pId);
    }
}
