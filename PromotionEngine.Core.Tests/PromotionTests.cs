using PromotionEngine.Core.Interface;
using PromotionEngine.Core.ObjectMothers;
using PromotionEngine.Core.Promotions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PromotionEngine.Core
{
    public class PromotionTests
    {
        ICalculationReceiver calculationReceiver;
        IList<ICalculationReceiver> calculationReceivers;

        CalculationHandler calculationHandler;
        public PromotionTests()
        {
        }
        [Fact]
        public void Promotion_3A_Returns_Total()
        {
            calculationReceiver = new PromotionA();
            var items = ShoppingCartOM.GetPromotion3AItems();
            var total = calculationReceiver.Process(items, 0);
            Assert.Equal(130, total.Item2);
            Assert.Equal(2, items.FirstOrDefault(item => item.SKU == Domain.SKUEnum.A).Quantity);
        }

        [Fact]
        public void Promotion_2B_Returns_Total()
        {
            calculationReceiver = new PromotionB();
            var items = ShoppingCartOM.GetPromotion2BItems();
            var total = calculationReceiver.Process(items, 0);
            Assert.Equal(45, total.Item2);
            Assert.Null(items.FirstOrDefault(item => item.SKU == Domain.SKUEnum.B));

        }

        [Fact]
        public void Promotion_3A_2B_Returns_Total()
        {
            calculationHandler = new CalculationHandler();
            calculationReceivers = new List<ICalculationReceiver> { new PromotionA(), new PromotionB() };
            var items = ShoppingCartOM.GetPromotion2BItems();
            var total = calculationHandler.Handle(items, calculationReceivers.ToList());
            Assert.Equal(175, total);
        }

        [Fact]
        public void Promotion_3A_2B_Others_Returns_Total()
        {
            calculationHandler = new CalculationHandler();
            calculationReceivers = new List<ICalculationReceiver> { new PromotionA(), new PromotionB(), new CalculateTotal() };
            var items = ShoppingCartOM.GetPromotion2BItems();
            var total = calculationHandler.Handle(items, calculationReceivers.ToList());
            Assert.Equal(175, total);
        }


        [Fact]
        public void Promotion_ALL_Returns_Total()
        {
            calculationHandler = new CalculationHandler();
            calculationReceivers = new List<ICalculationReceiver> { new PromotionA(), new PromotionB(), new PromotionCD(), new CalculateTotal() };
            var items = ShoppingCartOM.GetPromotionAllItems();
            var total = calculationHandler.Handle(items, calculationReceivers.ToList());
            Assert.Equal(370, total);
        }

        [Fact]
        public void Promotion_ALL2_Returns_Total()
        {
            calculationHandler = new CalculationHandler();
            calculationReceivers = new List<ICalculationReceiver> { new PromotionA(), new PromotionB(), new PromotionCD(), new CalculateTotal() };
            var items = ShoppingCartOM.GetPromotionAll2Items();
            var total = calculationHandler.Handle(items, calculationReceivers.ToList());
            Assert.Equal(280, total);
        }

        [Fact]
        public void Promotion_ALL1_Returns_Total()
        {
            calculationHandler = new CalculationHandler();
            calculationReceivers = new List<ICalculationReceiver> { new PromotionA(), new PromotionB(), new PromotionCD(), new CalculateTotal() };
            var items = ShoppingCartOM.GetPromotionAll1Items();
            var total = calculationHandler.Handle(items, calculationReceivers.ToList());
            Assert.Equal(100, total);
        }
    }
}
