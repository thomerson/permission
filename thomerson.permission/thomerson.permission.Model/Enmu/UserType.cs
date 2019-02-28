using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public enum UserType
    {
        /// <summary>
        /// 游客模式
        /// </summary>
        Visitor = 0,
        Normal = 1,

        Admin = 2,

        /// <summary>
        /// 超级管理员
        /// </summary>
        SuperAdmin = 1024

    }
}
