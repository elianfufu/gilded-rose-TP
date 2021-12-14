using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP
{
    public class Shop
    {
        private IInventoryRepo repository;
        public Shop(IInventoryRepo repository)
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

        public IList<Item> GetInventory()
        {
            return this.repository.GetInventory();
        }
    }
}
