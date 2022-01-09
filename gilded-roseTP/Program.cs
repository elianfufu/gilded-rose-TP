using gilded_roseTP.Interfaces.Inventory;
using gilded_roseTP.Interfaces.Shop;
using gilded_roseTP.Items;
using gilded_roseTP.Models.Inventory;
using gilded_roseTP.Models.Shop;
using System;
using System.Collections.Generic;

namespace gilded_roseTP
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryInteractor inventary = new InventoryInteractor(new FileRepository());
            IUpdateQuality inventoryUpdater = inventary;
            IGetInventory inventoryViewer = inventary;

            inventoryUpdater.UpdateQuality();

            foreach(Item i in inventoryViewer.GetInventory())
            {
                Console.WriteLine("{0} Quality {1}", i.name, i.quality);
            }
            List<String> limitedItems = new List<String>();
            limitedItems.Add("gilded_roseTP.GenericItem");
            ShopInteractor shop = new ShopInteractor(inventary, limitedItems);
            IShopManager shopKeeper = shop;

            Console.WriteLine("Now we sell and buy item");

            Console.WriteLine("Balance : " + shop.SellItem(new GenericItem("Generic Item3", 3, 0, 3)));
            Console.WriteLine("Balance : " + shop.BuyItem(new GenericItem("Generic Item4", 55,55, 5)));
            Console.WriteLine(shop.BuyItem(new ConjuredItem("Conjured Item1", 55,55, 5)));
            
            foreach (Item i in inventoryViewer.GetInventory())
            {
                Console.WriteLine("SHOP : {0} Quality {1}", i.name, i.quality);
            }
            Console.WriteLine("Final Balance" + shop.ReturnBalance());

            // BigBossInteractor bigBoss = new BigBossInteractor(new InMemoryShopRepository());
            // IBigBossCount bigBossTotal = bigBoss;

            // Console.WriteLine(bigBoss.GetShopMoney());
        }
    }
}
