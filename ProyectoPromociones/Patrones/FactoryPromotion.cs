using ProyectoPromociones.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPromociones.Patrones
{
    public class FactoryPromotion
    {
        /// <summary>
        /// METODOS PARA APLICAR PROMOCIONES
        /// </summary>
        FactoryMaintenanceVisualize factoryMaintenanceVisualize = new FactoryMaintenanceVisualize();
        public double CreatePromotion(List<Product> lista, List<int> cantidad,  string descripcion, double buyAmount)
        {
            double descuento = 0;
            int i = 0;
            Promotion promo = factoryMaintenanceVisualize.GetPromotionByFilter(descripcion);
            Product productPromotion = new Product() ;
            Product productGift = new Product();
            int cantProductGift = 0;
            int cantProductPromotion = 0;
            foreach (Product item in lista)
            {
                if (item.CodigoBarras == promo.PromotionProduct.CodigoBarras)
                {
                    productPromotion= item;
                    cantProductPromotion = cantidad[i];
                }
                if (item.CodigoBarras == promo.GiftPromotion.CodigoBarras)
                {
                    productGift = item;
                    cantProductGift = cantidad[i];
                }
                i++;
            }
                if (promo != null && descripcion == promo.Description && promo.InitialTime <= DateTime.Now && promo.FinalTime >= DateTime.Now)
                {
                    if (buyAmount >= promo.BuyAmount && promo.BuyAmount > 0 && descripcion == promo.Description && promo != null)
                    {
                        descuento = buyAmount * (promo.Discount);// si cumplo con el monto de compra entonces aplico el descuento
                        return descuento;
                    }
                    if (cantProductPromotion >= promo.QtyPromotionProduct && promo.QtyPromotionProduct >0 && promo.BuyAmount > 0 && promo.PromotionProduct.CodigoBarras == productPromotion.CodigoBarras)
                    {
                    descuento = ((promo.QtyPromotionProduct - (cantProductGift % promo.QtyPromotionProduct)) * promo.PromotionProduct.ListPrice) * (promo.Discount);
                    return descuento;//si cumplo con la cantidad del producto en promocion y el producto en promocion aplico el descuento
                    }
                    
                    if (buyAmount >= promo.BuyAmount && promo.BuyAmount >0 && productGift.CodigoBarras == promo.GiftPromotion.CodigoBarras && cantProductGift >= promo.QtyGiftPromotion)
                    {
                        descuento = (promo.GiftPromotion.ListPrice * promo.QtyGiftPromotion);
                    //si cumplo con el monto de venta, el producto de regalo y la cantidad del producto de regalo
                    //entonces el precio final es el monto de compra menos el precio de los regalos
                        return descuento;
                    }
                    if (productPromotion.CodigoBarras == promo.PromotionProduct.CodigoBarras && cantProductPromotion >=  promo.QtyPromotionProduct  && productGift.CodigoBarras == promo.GiftPromotion.CodigoBarras && cantProductGift >= promo.QtyGiftPromotion)
                    {
                        descuento = (promo.GiftPromotion.ListPrice * promo.QtyGiftPromotion);
                        //si cumplo con la cantidad de productos y la cantidad en promocion entonces regalo los productos que quiero segun base de datos
                        return descuento;
                    }
                    if (productPromotion.CodigoBarras == promo.PromotionProduct.CodigoBarras && promo.QtyPromotionProduct >= cantProductPromotion && promo.QtyGiftPromotion==0)
                    {
                        descuento = (promo.PromotionProduct.ListPrice * promo.Discount) * cantProductPromotion;
                        //si cumplo con la cantidad de productos y la cantidad en promocion entonces regalo los productos que quiero segun base de datos
                        return descuento;
                    }
                    
                 }
                else
                {
                    MessageBox.Show("Algun dato es invalido", "Error");
                }

            return 0;
        }
    }
}
