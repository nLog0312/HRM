using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement
{
    public class FunctionSupport
    {
        //Count the number of working days in the month
        public static int CountNumber(int month, int year)
        {
            int count = 0;
            DateTime f = new DateTime(year, month, 01);
            int x = f.Month + 1;
            while (f.Month < x)
            {
                count = count + 1;
                if (f.DayOfWeek == DayOfWeek.Sunday)
                {
                    count = count - 1;
                }
                f = f.AddDays(1);
            }
            return count;
        }
        public static int GetDayOfMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
