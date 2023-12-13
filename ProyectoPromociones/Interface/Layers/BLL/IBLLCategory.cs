using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLCategory
    {
        List<Category> GetCategoryByFilter(string pDescripcion);
        Category GetCategoryById(string pIdCategory);
        Task<IEnumerable<Category>> GetAllCategory();
        Task<Category> SaveCategory(Category pCategory);
        Task<bool> DeleteCategory(string pId);
    }
}
