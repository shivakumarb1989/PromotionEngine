using PromotionEngine.Core.ObjectMothers;
using Xunit;

namespace PromotionEngine.Core
{
    public class PromotionEngineCoreTests
    {
        [Fact]
        public void ContainsPropertyItemsTest()
        {
            var cart = new ShoppingCart();
            var doesItemsExist = cart.GetType().GetProperty("Items") != null;
            Assert.True(doesItemsExist);
        }

        [Fact]
        public void GetItemsTest()
        {
            var cart = ShoppingCartMock.GetItems();
            Assert.NotNull(cart.Items);
        }
    }
}
