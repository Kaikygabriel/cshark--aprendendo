
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    
    internal static class DateTimeExtesion
    {
        public static string ElapsedTime(this DateTime date)
        {
            if (date > DateTime.Now)
                throw new Exception("data tem que ser menor que data atual");

            TimeSpan duration = DateTime.Now.Subtract(date);
            if (duration.TotalHours < 24)
                return $"{duration.Hours}hours";
            else 
                return $"{duration.Days}days";
        }
    }
}
