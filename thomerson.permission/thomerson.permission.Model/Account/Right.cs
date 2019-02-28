using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Account
{
    public class Right : BaseModel
    {
        public string Name { get; set; }

        public string Identifier { get; set; }

        public PermissionType Type { get; set; }

        public Guid? ParentId { get; set; }

        public string Remark { get; set; }
    }
}
