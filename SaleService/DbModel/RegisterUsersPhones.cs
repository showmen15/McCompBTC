using System;
using System.Collections.Generic;

namespace SaleService.DbModel
{
    public partial class RegisterUsersPhones
    {
        public long IdUser { get; set; }
        public long Phone { get; set; }

        public virtual RegisterUsers IdUserNavigation { get; set; }
    }
}
