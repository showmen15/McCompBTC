using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Model
{
    public class WalletInfo
    {
        [Required]
        public string WalletAdressName { get; set; }
    }
}
