using System;
using System.Collections.Generic;
using System.Text;

namespace gilded_roseTP.BigBoss
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
