using System;
using System.Collections.Generic;

namespace thomerson.permission.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string EnglishName { get; set; }

        public string Phone { get; set; }

        public string Emali { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public UserType Type { get; set; }
    }
}
