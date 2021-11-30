using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gilded_roseTpTest
{
    [TestClass]
    public class UnitTest1
    {
        private List<Item> items = new List<Item>()
        {
            new Item("Generic Item", 3, 3),
            new Item("Generic Item", -1, 4)
            new Item("Generic Item", 3 , 0)
        }


        private Shop shop;

        [TestInitialize]
        public void Setup()
        {
            this.shop = new Shop(Item)
        }

        [TestMethod]
        public void Should_HaveSellOnItem()
        {
            Assert.AreEqual(3, shop, items[0].SellIn);
        }
        [TestMethod]
        public void Should_HaveQualityOnItem()
        {
            Assert.AreEqual(3, shop, items[0].Quality);
        }

        [TestMethod]
        public void Should_DecreaseQualityAndSellInEveryDay()
        {
            shop.UpdateQuality();
            Assert.AreEqual(2, shop, items[0].Quality);
            Assert.AreEqual(2, shop, items[0].SellIn);
        }

        [TestMethod]
        public void Should_DecreaseTwiceAsFast()
        {
            shop.UpdateQuality();
             Assert.AreEqual(2, shop, items[1].SellIn);
        }

        [TestMethod]
        public void Should_NeverHaveNegativeQuality()
        {
            shop.UpdateQuality();
            Assert.AreEqual(0, shop, items[2].SellIn);
        }
    }
}
