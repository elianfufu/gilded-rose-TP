using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class InMemoryRepository : IInventoryRepo
    {
        private IList<Item> items = new List<Item>()
        {
            new GenericItem("Generic Item", 3, 3),
            new GenericItem("Generic Item", -1, 4),
            new GenericItem("Generic Item", 3 , 0)
        };

        public IList<Item> Items => this.items;

        public IList<Item> GetInventory()
        {
            return this.items;
        }

        public void SaveInventory(IList<Item> items)
        {
            this.items = items;
        }
    }
}
