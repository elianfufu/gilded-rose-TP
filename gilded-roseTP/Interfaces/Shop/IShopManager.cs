using gilded_roseTP.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Interfaces.Shop
{
    public interface IShopManager
    {
        public string SellItem(Item item);
        public string BuyItem(Item item);
        public IList<Item> GetShopInventory();
    }
}
