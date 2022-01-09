using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class SulfurasItem : Item
    {
        public SulfurasItem(string name, int sellIn, int quality, int value) : base(name, sellIn, quality, value) { }

        public override void Update()
        {
            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
