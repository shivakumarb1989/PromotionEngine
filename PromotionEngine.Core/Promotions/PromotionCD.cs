using PromotionEngine.Core.Domain;
using PromotionEngine.Core.Interface;
using PromotionEngine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Core.Promotions
{
    public class PromotionCD : ICalculationReceiver
    {
        public Tuple<List<SKUQuantity>, int> Process(List<SKUQuantity> unProcessedItems, int total)
        {
            var productC = unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.C);
            var productD = unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.D);
            if (productC != null && productD != null)
            {
                if (productC.Quantity == productD.Quantity)
                {
                    total += productD.Quantity * CoreConstants.PROMOTION_CD_PRICE;
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.C).Quantity =
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.D).Quantity = 0;
                }

                if (productC.Quantity > productD.Quantity)
                {
                    total += productD.Quantity * CoreConstants.PROMOTION_CD_PRICE;
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.C).Quantity = 
                        productC.Quantity - productD.Quantity;
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.D).Quantity = 0;
                }
                else
                {
                    total += productC.Quantity * CoreConstants.PROMOTION_CD_PRICE;
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.D).Quantity =
                        productD.Quantity - productC.Quantity;
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.C).Quantity = 0;
                }
            }
            return new Tuple<List<SKUQuantity>, int>(unProcessedItems, total);
        }
    }
}
