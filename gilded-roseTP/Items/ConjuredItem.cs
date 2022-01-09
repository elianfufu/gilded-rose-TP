using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Items
{
    public class ConjuredItem : Item
    {
        public ConjuredItem(string name, int sellIn, int quality, int value) : base(name, sellIn, quality, value) { }

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
