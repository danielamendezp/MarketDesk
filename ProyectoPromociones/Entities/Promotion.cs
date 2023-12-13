using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoPromociones.Entities
{
    public class Promotion
    {
        public int IdPromotion { get; set; }

        public DateTime InitialTime { get; set; }

        public DateTime FinalTime { get; set; }

        public Product PromotionProduct { get; set; }

        public Product GiftPromotion {  get; set; }

        public int QtyPromotionProduct {  get; set; }

        public int QtyGiftPromotion { get; set; }

        public string Description { get; set; }

        public double Discount { get; set; }
        public double BuyAmount { get; set; }

        public override string ToString()
        {
            return Description;
        }


    }
}
