using PromotionEngine.Core.Domain;
using PromotionEngine.Core.Interface;
using PromotionEngine.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Core
{
    public class CalculateTotal : ICalculationReceiver
    {
        public Tuple<List<SKUQuantity>, int> Process(List<SKUQuantity> unProcessedItems, int total)
        {
            foreach (var unProcessedItem in unProcessedItems)
            {
                var price = unProcessedItem.Quantity * Convert.ToInt32(unProcessedItem.SKU);
                total += price;
            }

            return new Tuple<List<SKUQuantity>, int>(unProcessedItems, total);
        }
    }
}
