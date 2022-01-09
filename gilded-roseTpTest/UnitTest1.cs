using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using gilded_roseTP;
using System;
using gilded_roseTP.Models.Inventory;
using gilded_roseTP.Models.Shop;
using gilded_roseTP.Items;

namespace gilded_roseTpTest
{
    [TestClass]
    public class UnitTest1
    {
        private List<Item> items = new List<Item>()
        {
            new GenericItem("Generic Item", 3, 3, 4),
            new GenericItem("Generic Item", 3, -10, 4),
            new GenericItem("Generic Item", 3 , -1, 4),
            new GenericItem("Generic Item", 3 , 6, 4),

        };
        private InMemoryRepository repository;
        private InventoryInteractor inventory;
        private ShopInteractor shop;
        List<String> limitedItems = new List<String>() { "gilded_roseTP.Items.GenericItem" };

        [TestInitialize]
        public void Setup()
        {
            this.repository = new InMemoryRepository();
            this.inventory = new InventoryInteractor(this.repository);
            this.shop = new ShopInteractor(this.inventory, limitedItems);
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
             Assert.AreEqual(8, this.repository.Items[3].quality);
        }

        [TestMethod]
        public void Should_NeverHaveNegativeQuality()
        {
            inventory.UpdateQuality();
            Assert.AreEqual(0, this.repository.Items[2].quality);
        }

        [TestMethod]
        public void Should_SellItems()
        {
            shop.SellItem(new GenericItem("Generic Item3", 3, 0, 3));
            Assert.AreEqual(3, this.repository.GetInventory().Count);
        }

        [TestMethod]
        public void Should_BuyItems()
        {
            shop.BuyItem(new GenericItem("Generic Item3", 3, 0, 3));
            Assert.AreEqual(5, this.repository.GetInventory().Count);
        }
    }
}
