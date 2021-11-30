using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public abstract class Item
    {
        public string type { get; set; }
        public int sellIn { get; set; }
        public int quality { get; set; }

        public Item(string Type, int SellIn, int Quality)
        {
            type = Type;
            sellIn = SellIn;
            quality = Quality;
        }
        

        public abstract void Update();

        protected void CellQualityToFifty()
        {
            if (this.quality > 50)
            {
                this.quality = 50;
            }
        }

        protected void FloorQualityToZero()
        {
            if (this.quality < 0)
            {
                this.quality = 0;
            }
        }
    }
}
