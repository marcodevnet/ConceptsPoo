using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;   
            _month = CheckMonth(month); 
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int day, int month, int year)
        {
            if(month == 2 && day == 29 && IsSleepYear(year))
            {
                return day;
            }

            throw new NotImplementedException();
        }

        private bool IsSleepYear(int year)
        {
            return year % 400 == 0 
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month < 12)
            {
                return month;
            }

            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }

}
