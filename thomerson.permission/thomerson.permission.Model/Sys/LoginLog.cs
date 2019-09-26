using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model.Sys
{
    class LoginLog
    {
        public string Id { get; set; }
        public string LoginId { get; set; }
        public DateTime? LoginStamp { get; set; }
        public bool LoginState { get; set; }
        public string ExMessage { get; set; }
    }
}
