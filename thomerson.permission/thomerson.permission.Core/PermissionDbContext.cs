using Microsoft.EntityFrameworkCore;
using System;
using thomerson.permission.Model;

namespace thomerson.permission.Core
{
    public class PermissionDBContext : DbContext
    {
        public virtual DbSet<User> DB_User { get; set; }

        public virtual DbSet<Role> DB_Role { get; set; }

        public virtual DbSet<Right> DB_Right { get; set; }
    }
}
