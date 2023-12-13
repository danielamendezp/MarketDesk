using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Messaging;
using System.Windows.Forms;

namespace ProyectoPromociones.Interface
{
    public class PayCard : ICardType
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CVVCVC { get; set; }

        public bool LuhnVerification()
        {
            string cardNumberStr = CardNumber.ToString();
            // Limpiar cualquier espacio en blanco y caracteres no numéricos
            cardNumberStr = new string(cardNumberStr.Where(char.IsDigit).ToArray());

            int sum = 0;
            bool doubleDigit = false;

            // Recorre los dígitos del número de tarjeta de derecha a izquierda
            for (int i = cardNumberStr.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(cardNumberStr[i].ToString());

                if (doubleDigit)
                {
                    // Si es un dígito que debe duplicarse, lo duplicamos y ajustamos si es mayor o igual a 10
                    digit *= 2;
                    if (digit >= 10)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                doubleDigit = !doubleDigit;
            }

            // La tarjeta es válida si la suma total es divisible por 10
            return sum % 10 == 0;
        }

        public bool ExpirationDateTime()
        {

            // Obtén el mes y el año actual
            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year % 100; // Tomar solo los últimos dos dígitos del año

            // Intenta analizar la fecha de vencimiento proporcionada
            if (DateTime.TryParseExact(ExpirationDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaVencimientoDateTime))
            {
                // Compara el mes y el año actual con la fecha de vencimiento
                if (fechaVencimientoDateTime.Year > añoActual || (fechaVencimientoDateTime.Year == añoActual && fechaVencimientoDateTime.Month >= mesActual))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        
        }

        public bool PinDigits()
        {
            // Verificar si el CVV tiene exactamente 3 dígitos y son numéricos
            if (CVVCVC>= 100 && CVVCVC <= 999)
            {
                return true;
            }
            // El CVV no cumple con los requisitos
            return false;
        }

        public bool todasVerificaciones()
        {
            if (PinDigits() && ExpirationDateTime() )//&& LuhnVerification())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hay algún dato incorrecto", "Mensaje Informativo");
                return false;
            }
        }
    }
}
