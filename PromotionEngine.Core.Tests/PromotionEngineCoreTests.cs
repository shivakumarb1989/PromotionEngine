using Xunit;

namespace PromotionEngine.Core
{
    public class PromotionEngineCoreTests
    {
        [Fact]
        public void ContainsPropertyTest()
        {
            var cart = new ShoppingCart();
            var doesItemsExist = cart.GetType().GetProperty("Items") != null;
            Assert.True(doesItemsExist);
        }
    }
}
