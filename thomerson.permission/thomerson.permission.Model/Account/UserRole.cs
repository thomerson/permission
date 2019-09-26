using System;

namespace thomerson.permission.Model
{
    public class UserRole : BaseCommonModel
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

    }
}
