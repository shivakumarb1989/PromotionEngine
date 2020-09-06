using PromotionEngine.Core.Domain;
using PromotionEngine.Core.Interface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PromotionEngine.Core
{
    public class CalculationHandler
    {
        private List<SKUQuantity> UnProcessedItems { get; set; }

        public CalculationHandler(List<SKUQuantity> items, List<ICalculationReceiver> receivers)
        {
            UnProcessedItems = items;
            foreach (var calculation in receivers)
            {
                calculation.Process(UnProcessedItems);
            }
        }
    }
}
