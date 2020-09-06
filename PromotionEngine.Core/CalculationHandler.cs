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
        private List<SKUQuantity> Items { get; set; }

        public CalculationHandler(List<SKUQuantity> unProcessedItems, List<ICalculationReceiver> receivers)
        {
            foreach (var calculation in receivers)
            {
                calculation.Process();
            }
        }
    }
}
