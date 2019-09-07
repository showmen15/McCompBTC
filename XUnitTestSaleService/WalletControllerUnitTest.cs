using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleService.Controllers;
using Xunit;

namespace XUnitTestSaleService
{
    public class WalletControllerUnitTest
    {
        [Theory]
        [InlineData(123,true)]
        [InlineData(77777, false)]
        public void TestGetWalletInfo(long IdCode,bool expected)
        {
            var dbContext = DbContextMocker.GetDatabaseBTCContext(string.Format("WalletInfoDatabaseBTC{0}", IdCode.ToString()));
            var controller = new WalletController(dbContext);

            var response = controller.Get(IdCode) as SaleService.Model.WalletInfo;

            dbContext.Dispose();

            Assert.Equal(expected, response != null);
        }
    }
}