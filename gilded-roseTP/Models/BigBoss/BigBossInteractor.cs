using gilded_roseTP.Interfaces.BigBoss;
using gilded_roseTP.Interfaces.Inventory;
using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.Models.BigBoss
{
    public class BigBossInteractor : IBigBossCount
    {
        private IInventoryRepo repository;
        public BigBossInteractor(IInventoryRepo repository)
        {
            this.repository = repository;
        }

        public void GetBalance()
        {
            
        }
    }
}
