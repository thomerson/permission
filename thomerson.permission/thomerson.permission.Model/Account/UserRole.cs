using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Account
{
    public class UserRole : BaseCommonModel
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

    }
}
