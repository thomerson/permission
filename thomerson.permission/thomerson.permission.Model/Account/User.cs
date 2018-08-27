using System;
using System.Collections.Generic;

namespace thomerson.permission.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public UserType Type { get; set; }

        public List<Guid?> RoleKeys { get; set; }
    }
}
