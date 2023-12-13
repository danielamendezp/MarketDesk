using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IDALCategory
    {
        List<Category> GetCategoryByFilter(string pDescripcion);
        Category GetCategoryById(string pId);
        Task<IEnumerable<Category>> GetAllCategory();
        Task<Category> SaveCategory(Category pCategory);
        Task<Category> UpdateCategory(Category pCategory);
        Task<bool> DeleteCategory(string pId);
    }
}
