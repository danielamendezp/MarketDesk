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
    public class BLLHeader : IBLLHeader
    {
        public List<Header> GetHeaderByFilter(string pDescripcion)
        {
            IDALHeader _DALHeader = new DALHeader();
            return _DALHeader.GetHeaderByFilter(pDescripcion);
        }

        public Header GetHeaderById(string pIdHeader)
        {
            IDALHeader _DALHeader = new DALHeader();
            return _DALHeader.GetHeaderById(pIdHeader);
        }


        public Task<IEnumerable<Header>> GetAllHeader()
        {
            IDALHeader _DALHeader = new DALHeader();
            return _DALHeader.GetAllHeader();
        }

        public Task<Header> SaveHeader(Header pHeader)
        {
            IDALHeader _DALHeader = new DALHeader();
            Task<Header> oHeader = null;

            if (_DALHeader.GetHeaderById(pHeader.IdHeader.ToString()) == null)
                oHeader = _DALHeader.SaveHeader(pHeader);
            else
                oHeader = _DALHeader.UpdateHeader(pHeader);

            return oHeader;
        }

        public Task<bool> DeleteHeader(string pId)
        {
            IDALHeader _DALHeader = new DALHeader();

            return _DALHeader.DeleteHeader(pId);

        }
        public Task<Header> UpdateHeader(Header pHeader)
        {
            IDALHeader _DALHeader = new DALHeader();
            Task<Header> oHeader = null;

            oHeader = _DALHeader.UpdateHeader(pHeader);

            return oHeader;

        }
    }
}
