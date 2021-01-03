using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem
{

    public static class MyExtension
    {

        public static AgeSpan CalcAge(this DateTime Am, DateTime argToDate)
        {
            DateTime FromDate = Am;
            DateTime ToDate = argToDate;
            DateTime tempDate = DateTime.Now;

            AgeSpan retAge = new AgeSpan();

            int CarryFlag = 0;

            if (Am > argToDate)
            {
                ToDate = Am;
                FromDate = argToDate;
            }
            else
            {
                ToDate = argToDate;
                FromDate = Am;
            }

            // Day calc
            if (FromDate.Day > ToDate.Day)
            {
                // Get last day of month from previous month
                // even if leapyear system will automate return correctly
                tempDate = new DateTime(FromDate.Year, FromDate.Month, 1);
                tempDate = (tempDate.AddMonths(1)).AddDays(-1);

                CarryFlag = tempDate.Day;
                retAge.Day = (ToDate.Day + CarryFlag) - FromDate.Day;
                CarryFlag = 1;
            }
            else
                retAge.Day = ToDate.Day - FromDate.Day;

            //month calc
            if ((FromDate.Month + CarryFlag) > ToDate.Month)
            {
                retAge.Month = (ToDate.Month + 12) - (FromDate.Month + CarryFlag);
                CarryFlag = 1;
            }
            else
            {
                retAge.Month = ToDate.Month - (FromDate.Month + CarryFlag);
                CarryFlag = 0;
            }

            retAge.Year = ToDate.Year - (FromDate.Year + CarryFlag);

            return retAge;

        }

        public static AgeSpan CalcAge(this DateTime Am)
        {
            return Am.CalcAge(DateTime.Now);
        }

        public static DateTime LastDateOfMonth(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
        }
        //public static class MyDate
        //{
            
        //}
    }
    public class AgeSpan
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public AgeSpan() { this.Year = 0; this.Month = 0; this.Day = 0; }

        public override string ToString()
        {
            return this.ToString("ปี", "เดือน", "วัน", " ,"); //("Year(s)", "Month(s)", "Day(s)", " ,");
        }
        
        public string ToString(string argYearCaption, string argMonthCaption, string argDayCaption, string argSeparator)
        {
            string strRet = string.Empty;

            if (Year > 0)
                strRet = string.Format("{0} {1}", this.Year, argYearCaption, argSeparator);
            if (Month > 0)
            {
                if (strRet.Length > 0) strRet = strRet + argSeparator;
                strRet = strRet + string.Format("{0} {1}", this.Month, argMonthCaption, argSeparator);
            }
            if (Day > 0)
            {
                if (strRet.Length > 0) strRet = strRet + argSeparator;
                strRet = strRet + string.Format("{0} {1}", this.Day, argDayCaption);
            }
            return strRet;
        }
    }
}


