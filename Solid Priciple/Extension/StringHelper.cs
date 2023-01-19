using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Priciple.Extension
{
    public static class StringHelper
    {
        public static string RemoveFirstChar(this string str)
        {
            if(str.Length == 0)
            {
                return str;
            }
            else return str.Substring(1, str.Length - 1);
        }

    }
}
