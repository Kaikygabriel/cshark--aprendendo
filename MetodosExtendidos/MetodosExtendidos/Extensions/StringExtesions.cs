using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    internal static class StringExtesions
    {
        public static string Cut(this string obj,int number)
        {
            return obj.Substring(0,number)+"...";
        }
        public static DateTime ToDateTime(this string obj)
        {
            return DateTime.Parse(obj);
        }
    }
}
