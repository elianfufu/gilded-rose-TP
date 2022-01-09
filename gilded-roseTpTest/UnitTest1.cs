using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using gilded_roseTP;

namespace gilded_roseTpTest
{
    [TestClass]
    public class UnitTest1
    {
        private List<Item> items = new List<Item>()
        {
            new GenericItem("Generic Item", 3, 3, 4),
            new GenericItem("Generic Item", 3, -10, 4),
            new GenericItem("Generic Item", 3 , 0, 4)
        };
        private InMemoryRepository repository;
        private InventoryInteractor inventory;

        [TestInitialize]
        public void Setup()
        {
            this.repository = new InMemoryRepository();
            this.inventory = new InventoryInteractor(this.repository);
        }

        [TestMethod]
        public void Should_HaveSellOnItem()
        {
            Assert.AreEqual(3, this.repository.Items[0].sellIn);
        }
        [TestMethod]
        public void Should_HaveQualityOnItem()
        {
            Assert.AreEqual(3, this.repository.Items[0].quality);
        }

        [TestMethod]
        public void Should_DecreaseQualityAndSellInEveryDay()
        {
            inventory.UpdateQuality();
            Assert.AreEqual(2, this.repository.Items[0].quality);
            Assert.AreEqual(2, this.repository.Items[0].sellIn);
        }

        [TestMethod]
        public void Should_DecreaseTwiceAsFast()
        {
            inventory.UpdateQuality();
             Assert.AreEqual(-1, this.repository.Items[1].sellIn);
        }

        [TestMethod]
        public void Should_NeverHaveNegativeQuality()
        {
            inventory.UpdateQuality();
            Assert.AreEqual(0, this.repository.Items[2].quality);
        }
    }
}
