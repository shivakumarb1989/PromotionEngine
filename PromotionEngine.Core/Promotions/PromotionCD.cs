using PromotionEngine.Core.Domain;
using PromotionEngine.Core.Interface;
using PromotionEngine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Core.Promotions
{
    public class PromotionCD //: ICalculationReceiver
    {
        public Tuple<List<SKUQuantity>, int> Process(List<SKUQuantity> unProcessedItems, int total)
        {
            var item = unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.A);
            if (item != null && item.Quantity > CoreConstants.PROMOTION_3A_UNITS)
            {
                var promotionApplicable = item.Quantity / CoreConstants.PROMOTION_3A_UNITS;
                var promotionDenied = item.Quantity % CoreConstants.PROMOTION_3A_UNITS;

                total += Convert.ToInt32(promotionApplicable * CoreConstants.PROMOTION_3A_PRICE);
                if (promotionDenied == 0)
                {
                    unProcessedItems.Remove(item);
                }
                else
                {
                    unProcessedItems.FirstOrDefault(a => a.SKU == SKUEnum.A).Quantity = promotionDenied;
                }
            }
            return new Tuple<List<SKUQuantity>, int>(unProcessedItems, total);
        }
    }
}
