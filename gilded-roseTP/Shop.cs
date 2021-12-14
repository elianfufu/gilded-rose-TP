using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class Shop
    {
        public IList<Item> Items { get; private set; }
        private IinventoryRepo repository;
        public Shop(IinventoryRepo repository)
        {
            this.repository = repository;
        }

        public void UpdateQuality()
        {
            IList<Item> items = this.repository.GetInventory();

            foreach (Item item in items)
                item.Update();

            this.repository.SaveInventory(items);
        }
    }
}
