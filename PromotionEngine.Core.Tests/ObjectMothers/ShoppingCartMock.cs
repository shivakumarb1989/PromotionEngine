using PromotionEngine.Core.Domain;
using System.Collections.Generic;

namespace PromotionEngine.Core.ObjectMothers
{
    public static class ShoppingCartOM
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

        public static List<SKUQuantity> GetPromotion3AItems()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 2 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 6 },
                    new SKUQuantity { SKU = SKUEnum.D, Quantity = 8 }
                };

            return items;
        }

        public static List<SKUQuantity> GetPromotion2BItems()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 2 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 6 },
                    new SKUQuantity { SKU = SKUEnum.D, Quantity = 8 }
                };

            return items;
        }

        public static List<SKUQuantity> GetPromotionAllItems()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 1 },
                };

            return items;
        }

        public static List<SKUQuantity> GetPromotionAll1Items()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 1 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 1 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 1 },
                };

            return items;
        }

        public static List<SKUQuantity> GetPromotionAll2Items()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 3 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 1 },
                    new SKUQuantity { SKU = SKUEnum.D, Quantity = 1 },
                };

            return items;
        }

        public static List<SKUQuantity> GetPromotion_3A_2B_Items()
        {
            var items = new List<SKUQuantity> {
                    new SKUQuantity { SKU = SKUEnum.A, Quantity = 5 },
                    new SKUQuantity { SKU = SKUEnum.B, Quantity = 2 },
                    new SKUQuantity { SKU = SKUEnum.C, Quantity = 6 },
                    new SKUQuantity { SKU = SKUEnum.D, Quantity = 8 }
                };

            return items;
        }
    }
}
