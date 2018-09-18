using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class BaseModel
    {
        public Guid? Key { get; set; }
        public DateTime? CreateStamp { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime? LastUpdateStamp { get; set; }
        public Guid LastUpdateBy { get; set; }
    }
}
