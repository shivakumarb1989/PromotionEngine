using PromotionEngine.Core.Domain;
using System.Collections.Generic;

namespace PromotionEngine.Core.ObjectMothers
{
    public static class ShoppingCartMock
    {
        public static ShoppingCart GetItems()
        {

            var shoppingCart = new ShoppingCart
            {
                Items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 2 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 6 },
                    new SKUQuantity { SKU = SKUEnum.D, Quantity = 8 }
                }
            };
            return shoppingCart;
        }
    }
}
