using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundayOfEachMonth
{
    public class LastSunday
    {
        public List<string> GetLastSundayInMonth(int year)
        {
            DateTime date;
            List<string> listOfSundays = new List<string>();

            for (int month = 1; month <= 12; month++)
            {
                date = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                while (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    date = date.AddDays(-1);

                }
                listOfSundays.Add(date.ToString("yyyy-MM-dd"));
                
            }
            return listOfSundays;
        }
    }
}


