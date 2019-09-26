using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class BaseCommonModel : BaseModel, IDisable, IAudit, IDelete
    {
        public bool Disabled { get; set; }
        public DateTime? CreateAt { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? LastUpdateAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
