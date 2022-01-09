using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class InMemoryRepository : IInventoryRepo
    {
        private IList<Item> items = new List<Item>()
        {
            new GenericItem("Generic Item1", 3, 3, 5),
            new GenericItem("Generic Item2", -1, 4, 4),
            new GenericItem("Generic Item3", 3 , 0, 3),
            new ConjuredItem("Conjured Item", 15, 8, 7)
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
