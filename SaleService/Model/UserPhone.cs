using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Model
{
    public class UserPhone : UserInfo
    {
        [Required]
        public long Phone { get; set; }

    }
}
