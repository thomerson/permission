using System;
using System.Text.RegularExpressions;

namespace thomerson.Gatlin
{
    public class Validate
    {




        /// <summary>
        /// 前端进行判断
        /// </summary>
        public static bool Password(string val)
        {
            var regex = new Regex(@"
(?=.*[0-9])                     #必须包含数字
(?=.*[a-z])                     #必须包含小写、大写字母
(?=.*[A-Z])
(?=([\x21-\x7e]+)[^a-zA-Z0-9])  #必须包含特殊符号
.{8,30}                         #至少8个字符，最多30个字符
", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);

            return regex.IsMatch(val);
        }
    }

}
