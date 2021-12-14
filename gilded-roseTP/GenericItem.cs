using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality) : base(name, sellIn, quality){ }

        public override void Update()
        {
            sellIn--;
            quality--;

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
