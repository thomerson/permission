using System;
using System.Collections.Generic;
using System.Text;
using thomerson.permission.Model.Enmu;

namespace thomerson.permission.Model.Sys
{
    class OperateLog
    {
        public string Id { get; set; }
        public OperateType OperateType { get; set; }
        public string Table { get; set; }
        public string Content { get; set; }
        public string OperateId { get; set; }
        public DateTime? OperdateStamp { get; set; }
    }
}
