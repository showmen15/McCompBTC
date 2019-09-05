using System;
using System.Collections.Generic;

namespace SaleService.DbModel
{
    public partial class Transactions
    {
        public long Id { get; set; }
        public decimal Btc { get; set; }
        public long IdUser { get; set; }
        public long IdWallet { get; set; }
    }
}
