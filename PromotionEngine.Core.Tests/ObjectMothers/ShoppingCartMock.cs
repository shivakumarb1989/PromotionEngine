using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Core.ObjectMothers
{
    public static class ShoppingCartMock
    {
        public static ShoppingCart GetItems()
        {

            var shoppingCart = new ShoppingCart
            {
                Items = new List<Tuple<Domain.ProductEnum, int>> { 
                    new Tuple<Domain.ProductEnum, int> (Domain.ProductEnum.A, 5),
                    new Tuple<Domain.ProductEnum, int> (Domain.ProductEnum.B, 2),
                    new Tuple<Domain.ProductEnum, int> (Domain.ProductEnum.C, 6),
                    new Tuple<Domain.ProductEnum, int> (Domain.ProductEnum.D, 8),
                }                
            };
            return shoppingCart;
        }
    }
}
