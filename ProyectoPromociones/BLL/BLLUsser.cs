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
    public class BLLUsser : IBLLUsser
    {
        public List<Usser> GetUsserByFilter(string pDescripcion)
        {
            IDALUsser _DALUsser = new DALUsser();
            return _DALUsser.GetUsserByFilter(pDescripcion);
        }

        public Usser GetUsserById(string pIdUsser)
        {
            IDALUsser _DALUsser = new DALUsser();
            return _DALUsser.GetUsserById(pIdUsser);
        }


        public Task<IEnumerable<Usser>> GetAllUsser()
        {
            IDALUsser _DALUsser = new DALUsser();
            return _DALUsser.GetAllUsser();
        }

        public Task<Usser> SaveUsser(Usser pUsser)
        {
            IDALUsser _DALUsser = new DALUsser();
            Task<Usser> oUsser = null;

            if (_DALUsser.GetUsserById(pUsser.IdUsser.ToString()) == null)
                oUsser = _DALUsser.SaveUsser(pUsser);
            else
                oUsser = _DALUsser.UpdateUsser(pUsser);

            return oUsser;
        }

        public Task<bool> DeleteUsser(string pId)
        {
            IDALUsser _DALUsser = new DALUsser();

            return _DALUsser.DeleteUsser(pId);

        }

        public Task<Usser> UpdateUsser(Usser pUsser)
        {
            IDALUsser _DALUsser = new DALUsser();
            Task<Usser> oUsser = null;

            oUsser = _DALUsser.UpdateUsser(pUsser);

            return oUsser;

        }
    }
}
