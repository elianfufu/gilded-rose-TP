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
            SellIn--;
            Quality -= 2;

            if (this.SellIn < 0)
            {
                this.Quality -= 2;
            }

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
