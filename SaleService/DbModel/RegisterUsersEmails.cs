using System;
using System.Collections.Generic;

namespace SaleService.DbModel
{
    public partial class RegisterUsersEmails
    {
        public long IdUser { get; set; }
        public string Email { get; set; }

        public virtual RegisterUsers IdUserNavigation { get; set; }
    }
}
