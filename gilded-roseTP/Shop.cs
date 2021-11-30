using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class Shop
    {
        public IList<Item> Items { get; private set; }

        public Shop(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            foreach (Item i in this.Items)
            {
                i.sellIn--;
                i.quality--;
            }
        }

    }
}
