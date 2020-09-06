using PromotionEngine.Core.Domain;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Core.Interface
{
    public interface ICalculationReceiver
    {
        Tuple<List<SKUQuantity>, int> Process(List<SKUQuantity> unProcessedItems, int total);
    }
}
