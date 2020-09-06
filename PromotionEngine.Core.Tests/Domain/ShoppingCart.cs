using PromotionEngine.Core.Domain;
using System.Collections.Generic;

namespace PromotionEngine.Core
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public Dictionary<ProductEnum, int> Items { get; internal set; }
    }
}