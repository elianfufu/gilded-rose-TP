using System;
using System.Collections.Generic;

namespace gilded_roseTP
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryInteractor shop = new InventoryInteractor(new InMemoryRepository());
            IUpdateQuality inventoryUpdater = shop;
            IGetInventory inventoryViewer = shop;

            inventoryUpdater.UpdateQuality();

            foreach(Item i in inventoryViewer.GetInventory())
            {
                Console.WriteLine("{0} Quality {1}", i.name, i.quality);
            }
        }
    }
}
