using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Items
{
    public class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality, int value) : base(name, sellIn, quality, value){ }

        public override void Update()
        {
            sellIn--;
            quality--;

            this.CellQualityToFifty();
            this.FloorQualityToZero();
        }
    }
}
