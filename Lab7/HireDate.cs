using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class HireDate
    {
        public HireDate() {
            Day = 1;
            Month = 1;
            Year = 2024;
        }

        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;

        }
        public override string ToString()
        {
            string Hiring = $"{Day}/{Month}/{Year}";
            return Hiring ;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

        public int Compare(HireDate date1, HireDate date2)
        {
            if (date1.Year != date2.Year)
                return date1.Year.CompareTo(date2.Year);
            if (date1.Month != date2.Month)
                return date1.Month.CompareTo(date2.Month);
            return date1.Day.CompareTo(date2.Day);
        }
    }
}
