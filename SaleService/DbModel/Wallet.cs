using System;
using System.Collections.Generic;

namespace SaleService.DbModel
{
    public partial class Wallet
    {
        public long IdWallet { get; set; }
        public long IdCode { get; set; }
        public string AdressName { get; set; }
    }
}
