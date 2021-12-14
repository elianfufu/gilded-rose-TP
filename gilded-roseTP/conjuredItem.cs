using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class conjuredItem : Item
    {
        public conjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void Update()
        {
            sellIn--;
            quality -= 2;

            if (this.sellIn < 0)
            {
                this.quality -= 2;
            }

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
