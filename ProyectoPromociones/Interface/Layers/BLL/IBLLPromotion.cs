using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface IBLLPromotion
    {

        List<Promotion> GetPromotionByFilter(string pDescripcion);
        Promotion GetPromotionById(string pIdPromotion);
        Task<IEnumerable<Promotion>> GetAllPromotion();
        Task<Promotion> SavePromotion(Promotion pPromotion);
        Task<bool> DeletePromotion(string pId);
    }
}
