using PromotionEngine.Core.Domain;
using PromotionEngine.Core.Interface;
using PromotionEngine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Core.Promotions
{
    public class PromotionB : ICalculationReceiver
    {
        public Tuple<List<SKUQuantity>, int> Process(List<SKUQuantity> unProcessedItems, int total)
        {
            var item = unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.B);
            if (item != null && item.Quantity >= CoreConstants.PROMOTION_2B_UNITS)
            {
                var promotionApplicable = item.Quantity / CoreConstants.PROMOTION_2B_UNITS;
                var promotionDenied = item.Quantity % CoreConstants.PROMOTION_2B_UNITS;

                total += Convert.ToInt32(promotionApplicable * CoreConstants.PROMOTION_2B_PRICE);
                if (promotionDenied == 0)
                {
                    unProcessedItems.Remove(item);
                }
                else
                {
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.B).Quantity = promotionDenied;
                }
            }
            return new Tuple<List<SKUQuantity>, int>(unProcessedItems, total);
        }
    }
}
