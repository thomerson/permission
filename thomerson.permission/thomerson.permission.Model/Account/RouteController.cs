using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Account
{
    public class RouteController : BaseModel
    {
        public string Name { get; set; }

        public string Identifier { get; set; }

        public string Description { get; set; }
    }
}
