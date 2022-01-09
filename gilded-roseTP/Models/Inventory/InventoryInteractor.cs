using gilded_roseTP.Interfaces.Inventory;
using gilded_roseTP.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Models.Inventory
{
    public class InventoryInteractor : IGetInventory, IUpdateQuality
    {
        private IInventoryRepo repository;
        public InventoryInteractor(IInventoryRepo repository)
        {
            this.repository = repository;
        }

        public void UpdateQuality()
        {
            IList<Item> items = (IList<Item>)this.repository.GetInventory();

            foreach (Item item in items)
                item.Update();

            this.repository.SaveInventory(items);
        }

        public IList<Item> GetInventory()
        {
            return (IList<Item>)this.repository.GetInventory();
        }
    }
}
