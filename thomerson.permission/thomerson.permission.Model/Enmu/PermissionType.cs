using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Model
{
    public enum PermissionType
    {
        /// <summary>
        /// 应用
        /// </summary>
        App = 0,
        /// <summary>
        /// 页面
        /// </summary>
        Page = 1,
        /// <summary>
        /// 接口
        /// </summary>
        API = 2,
        /// <summary>
        /// 文件
        /// </summary>
        File = 3,
        /// <summary>
        /// 
        /// </summary>
        Button = 4
    }
}
