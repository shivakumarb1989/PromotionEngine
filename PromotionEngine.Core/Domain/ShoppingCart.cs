using PromotionEngine.Core.Domain;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Core
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public List<Tuple<ProductEnum, int>> Items { get; internal set; }
    }
}