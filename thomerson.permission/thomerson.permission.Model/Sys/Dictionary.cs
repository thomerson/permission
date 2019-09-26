using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Sys
{
    public class Dictionary : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ParentCode { get; set; }
    }
}
