using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    class Shop
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
                i.SellIn--;
                i.Quality--;

                if (i.SellIn < 0)
                    i.Quality--;

                FloorQualityToZero(i.Quality);

            }
        }

        private void FloorQualityToZero (Item item)
        {
            if (item.Quality < 0)
                item.Quality = 0;
        }

    }
}
