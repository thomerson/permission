using System;
using System.Collections.Generic;

namespace thomerson.permission.Model
{
    public class User : BaseCommonModel
    {
        public string Name { get; set; }

        public string EnglishName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public UserType Type { get; set; }

        public string Remark { get; set; }
    }
}
