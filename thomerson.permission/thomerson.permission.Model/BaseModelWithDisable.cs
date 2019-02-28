using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public class BaseModelWithDisable : BaseModel
    {
        public bool Disabled { get; set; }
    }
}
