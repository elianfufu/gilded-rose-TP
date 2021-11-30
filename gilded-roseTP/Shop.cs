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
<<<<<<< HEAD
                i.sellIn--;
                i.quality--;
=======
                i.SellIn--;
                i.Quality--;

                if (i.SellIn < 0)
                    i.Quality--;

                FloorQualityToZero(i.Quality);

>>>>>>> 5518fd5f89c619239c2074b4cdf116e6b097acef
            }
        }

        private void FloorQualityToZero (Item item)
        {
            if (item.Quality < 0)
                item.Quality = 0;
        }

    }
}
