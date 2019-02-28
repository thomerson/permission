using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class BaseModelWithAudit : BaseModel
    {
        public DateTime? CreateAt { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public Guid LastUpdateBy { get; set; }
    }
}
