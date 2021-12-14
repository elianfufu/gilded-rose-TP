using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class GenericItem : Item
    {
        public GenericItem(string type, int sellIn, int quality) : base(type, sellIn, quality){ }

        public override void Update()
        {
            sellIn--;
            quality--;

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }

        
    }
}
