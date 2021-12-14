using gilded_roseTP.models;
using System;
using System.Collections.Generic;

namespace gilded_roseTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(new InMemoryRepository());
            shop.UpdateQuality();
            foreach(Item i in shop.GetInventory())
            {
                Console.WriteLine("{0} Quality {1}", i.name, i.quality);
            }
        }
    }
}
