using System.Collections.Generic;

namespace PromotionEngine.Core.Interface
{
    public interface ICalculationReceiver
    {
        void Process(List<Domain.SKUQuantity> unProcessedItems);
    }
}
