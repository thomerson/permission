using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thomerson.permission.Model;

namespace thomerson.permission.ViewModel
{
    public class VUser : User
    {
        public List<Guid?> RoleKeys { get; set; }
    }
}
