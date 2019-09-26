using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class RoleRight : BaseCommonModel
    {
        public Guid RoleId { get; set; }
        public Guid RightId { get; set; }
    }
}
