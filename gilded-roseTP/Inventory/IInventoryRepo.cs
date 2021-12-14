using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public interface IInventoryRepo
    {
        IList<Item> GetInventory();
        void SaveInventory(IList<Item> items);
    }
}
