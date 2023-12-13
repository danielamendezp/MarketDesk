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
    public class BLLCategory : IBLLCategory
    {
        public List<Category> GetCategoryByFilter(string pDescripcion)
        {
            IDALCategory _DALCategory = new DALCategory();
            return _DALCategory.GetCategoryByFilter(pDescripcion);
        }

        public Category GetCategoryById(string pIdCategory)
        {
            IDALCategory _DALCategory = new DALCategory();
            return _DALCategory.GetCategoryById(pIdCategory);
        }


        public Task<IEnumerable<Category>> GetAllCategory()
        {
            IDALCategory _DALCategory = new DALCategory();
            return _DALCategory.GetAllCategory();
        }

        public Task<Category> SaveCategory(Category pCategory)
        {
            IDALCategory _DALCategory = new DALCategory();
            Task<Category> oCategory = null;

            if (_DALCategory.GetCategoryById(pCategory.IdCategory.ToString()) == null)
                oCategory = _DALCategory.SaveCategory(pCategory);
            else
                oCategory = _DALCategory.UpdateCategory(pCategory);

            return oCategory;
        }

        public Task<bool> DeleteCategory(string pId)
        {
            IDALCategory _DALCategory = new DALCategory();

            return _DALCategory.DeleteCategory(pId);

        }

        public Task<Category> UpdateCategory(Category pCategory)
        {
            IDALCategory _DALCategory = new DALCategory();
            Task<Category> oCategory = null;

            oCategory = _DALCategory.UpdateCategory(pCategory);

            return oCategory;

        }

    }
}
