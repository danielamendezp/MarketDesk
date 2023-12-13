using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromociones.Interface
{
    public interface ICardType
    {
        string Name { get;}
        string CardNumber { get; set; }

        string ExpirationDate {  get; set; }

        int CVVCVC { get; set; }
        Boolean LuhnVerification();
        Boolean ExpirationDateTime();
        Boolean PinDigits();

        Boolean todasVerificaciones();

    }
}
