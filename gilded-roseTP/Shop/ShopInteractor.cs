using gilded_roseTP.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gilded_roseTP
{
    public class ShopInteractor: IShopManager
    {
        private InventoryInteractor interactor;
        private int balance = 0;
        private List<String> limitedItems;
        public ShopInteractor(InventoryInteractor interactor, List<String> limitedItems)
        {
            this.interactor = interactor;
            this.limitedItems = limitedItems;
        }

        public string SellItem(Item item)
        {
            if (item.GetType().ToString() == limitedItems.FirstOrDefault(i => i == item.GetType().ToString()))
            {
                IList<Item> items = this.interactor.GetInventory();
                var i = items.FirstOrDefault(i => i.name == item.name);
                items.Remove(i);
                balance -= item.value;
                return balance.ToString();
            }
            return "This item is not available";
            // this.interactor.SaveInventory(items);
        }

        public string BuyItem(Item item)
        {
            if (item.GetType().ToString() == limitedItems.FirstOrDefault(i => i == item.GetType().ToString()))
            {

                IList<Item> items = this.interactor.GetInventory();
                items.Add(item);
                balance += item.value;
                return balance.ToString();
            }
            return "This item is not available";
            // this.interactor.SaveInventory(items);
        }

        public IList<Item> GetShopInventory()
        {
            return this.interactor.GetInventory();
        }
        public int ReturnBalance()
        {
            return balance;
        }
    }
}
