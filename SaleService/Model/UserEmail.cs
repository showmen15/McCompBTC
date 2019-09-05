using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaleService.Model
{
    public class UserEmail : UserInfo
    {
        [Required]
        public string Email { get; set; }

    }
}
