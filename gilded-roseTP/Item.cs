using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }
        

        public abstract void Update();

        protected void CellQualityToFifty()
        {
            if (this.Quality > 50)
            {
                this.Quality = 50;
            }
        }

        protected void FloorQualityToZero()
        {
            if (this.Quality < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
