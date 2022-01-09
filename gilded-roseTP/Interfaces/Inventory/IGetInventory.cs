using gilded_roseTP.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Interfaces.Inventory
{
    public interface IGetInventory
    {
        public IList<Item> GetInventory();
    }
}
