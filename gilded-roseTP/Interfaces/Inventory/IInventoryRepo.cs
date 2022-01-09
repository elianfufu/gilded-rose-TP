using gilded_roseTP.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Interfaces.Inventory
{
    public interface IInventoryRepo
    {
        IList<Item> GetInventory();
        void SaveInventory(IList<Item> items);
    }
}
