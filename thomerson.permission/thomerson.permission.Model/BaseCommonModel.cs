using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class BaseCommonModel : BaseModelWithAudit
    {
        public bool Disabled { get; set; }
    }
}
