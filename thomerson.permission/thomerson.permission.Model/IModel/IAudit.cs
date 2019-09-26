using System;

namespace thomerson.permission.Model
{
    interface IAudit
    {
        DateTime? CreateAt { get; set; }
        Guid CreateBy { get; set; }
        DateTime? LastUpdateAt { get; set; }
        Guid LastUpdateBy { get; set; }
    }
}
