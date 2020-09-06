using PromotionEngine.Core.Domain;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Core
{
    public class ShoppingCart
    {
        public List<SKUQuantity> Items { get; set; }

        public int Total { get; set; }
    }
}