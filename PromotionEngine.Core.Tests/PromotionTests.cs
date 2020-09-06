using PromotionEngine.Core.ObjectMothers;
using PromotionEngine.Core.Promotions;
using System.Linq;
using Xunit;

namespace PromotionEngine.Core
{
    public class PromotionTests
    {
        PromotionA promotionA;
        PromotionB promotionB;
        public PromotionTests()
        {
            promotionA = new PromotionA();
            promotionB = new PromotionB();
        }
        [Fact]
        public void Promotion3ATest()
        {
            var items = ShoppingCartOM.GetPromotion3AItems();
            var total = promotionA.Process(items, 0);
            Assert.Equal(130, total.Item2);
            Assert.Equal(2, items.FirstOrDefault(item => item.SKU == Domain.SKUEnum.A).Quantity);
        }

        [Fact]
        public void Promotion2BTest()
        {
            var items = ShoppingCartOM.GetPromotion2BItems();
            var total = promotionB.Process(items, 0);
            Assert.Equal(45, total.Item2);
            Assert.Null(items.FirstOrDefault(item => item.SKU == Domain.SKUEnum.B));

        }
    }
}
