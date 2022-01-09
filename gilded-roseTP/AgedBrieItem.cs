using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class AgedBrieItem : Item
    {
        public AgedBrieItem(string name, int sellIn, int quality, int value) : base(name, sellIn, quality, value) { }

        public override void Update()
        {
            sellIn--;
            quality++;

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
