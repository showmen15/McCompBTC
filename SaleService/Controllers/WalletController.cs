using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.DbModel;
using SaleService.Model;

namespace SaleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        [HttpPost]
        public WalletInfo Get([FromBody] long IdCode)
        {
            WalletInfo walletInfo = null;

            DatabaseBTCContext databaseBTCContext = new DatabaseBTCContext();
            Wallet wallet = databaseBTCContext.Wallet.FirstOrDefault(ww => ww.IdCode == IdCode);

            if(wallet != null)
            {
                walletInfo = new WalletInfo();
                walletInfo.WalletAdressName = wallet.AdressName;
            }

            return walletInfo;            
        }
    }
}
