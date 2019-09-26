using System;
using System.Collections.Generic;
using System.Text;

namespace thomerson.permission.Core
{
    interface IBatchDALcs<T> where T : class
    {
        void Update();
    }
}
