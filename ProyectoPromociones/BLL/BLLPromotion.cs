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
    public class BLLPromotion : IBLLPromotion
    {
        public List<Promotion> GetPromotionByFilter(string pDescripcion)
        {
            IDALPromotion _DALPromotion = new DALPromotion();
            return _DALPromotion.GetPromotionByFilter(pDescripcion);
        }

        public Promotion GetPromotionById(string pIdPromotion)
        {
            IDALPromotion _DALPromotion = new DALPromotion();
            return _DALPromotion.GetPromotionById(pIdPromotion);
        }


        public Task<IEnumerable<Promotion>> GetAllPromotion()
        {
            IDALPromotion _DALPromotion = new DALPromotion();
            return _DALPromotion.GetAllPromotion();
        }

        public Task<Promotion> SavePromotion(Promotion pPromotion)
        {
            IDALPromotion _DALPromotion = new DALPromotion();
            Task<Promotion> oPromotion = null;
            oPromotion = _DALPromotion.SavePromotion(pPromotion);
            return oPromotion;
        }

        public Task<bool> DeletePromotion(string pId)
        {
            IDALPromotion _DALPromotion = new DALPromotion();

            return _DALPromotion.DeletePromotion(pId);

        }
        public Task<Promotion> UpdatePromotion(Promotion pPromotion)
        {
            IDALPromotion _DALPromotion = new DALPromotion();
            Task<Promotion> oPromotion = null;

                oPromotion = _DALPromotion.UpdatePromotion(pPromotion);

            return oPromotion;

        }
    }
}
