using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    class FileRepository : IInventoryRepo
    {
        public IList<Item> GetInventory()
        {
            throw new NotImplementedException();
        }

        public void SaveInventory(IList<Item> items)
        {
            throw new NotImplementedException();
        }
    }
}
