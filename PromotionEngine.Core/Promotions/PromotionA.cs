using PromotionEngine.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Core.Promotions
{
    public class PromotionA : ICalculationReceiver
    {
        public void Process(List<Domain.SKUQuantity> unProcessedItems)
        {
            throw new NotImplementedException();
        }
    }
}
