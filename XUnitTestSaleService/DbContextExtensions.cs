using SaleService.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestSaleService
{
    public static class DbContextExtensions
    {
        public static void Seed(this DatabaseBTCContext dbContext)
        {
            dbContext.Wallet.Add(new Wallet()
            {
                IdCode = 123,
                IdWallet = 569,
                AdressName = "Krakow 123"
            });

            dbContext.SaveChanges();
        }
    }
}