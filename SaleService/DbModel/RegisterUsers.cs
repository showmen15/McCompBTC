using System;
using System.Collections.Generic;

namespace SaleService.DbModel
{
    public partial class RegisterUsers
    {
        public long IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual RegisterUsersEmails RegisterUsersEmails { get; set; }
        public virtual RegisterUsersPhones RegisterUsersPhones { get; set; }
    }
}
