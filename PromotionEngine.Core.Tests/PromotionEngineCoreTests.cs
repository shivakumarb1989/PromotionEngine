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
    }
}
