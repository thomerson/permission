using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Account
{
    public class UserRoles
    {
        public Guid? UserKey { get; set; }
        public List<Guid?> RoleKeys { get; set; }
    }
}
