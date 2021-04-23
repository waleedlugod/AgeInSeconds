using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeInSeconds
{
    static class Convert
    {
        public static int AgeToSeconds(int birthDay, int birthMonth, int birthYear)
        {
            int daysSinceBirth = 0;

            // Numbers of days passed in birth month
            daysSinceBirth += GetDaysInMonth(birthMonth, birthYear) - birthDay;
            // Numbers of days passed in birth year, exclusive of birth month
            daysSinceBirth += MonthsToDays(birthMonth + 1, 12, birthYear);
            // Number of days passed since birth year, exclusive of birth year and current year
            daysSinceBirth += YearsToDays(birthYear + 1, DateTime.Now.Year);
            // Number of days passed in current year, exclusive of current month
            daysSinceBirth += MonthsToDays(1, DateTime.Now.Month - 1, DateTime.Now.Year);
            // Number of days passed in current month
            daysSinceBirth += DateTime.Now.Day;


            return daysSinceBirth * 24 * 60 * 60;
        }

        public static int YearsToDays(int initialYear, int finalYear)
        {
            int days = 0;

            for (int year = initialYear; year < finalYear; year++)
            {
                days += (year % 4 == 0) ? 366 : 365;
            }

            return days;
        }

        public static int MonthsToDays(int initialMonth, int finalMonth, int year)
        {
            int days = 0;

            if (initialMonth > finalMonth)
            {
                return days;
            }

            days = GetDaysInMonth(initialMonth, year);

            days += MonthsToDays(initialMonth + 1, finalMonth, year);

            return days;
        }

        private static int GetDaysInMonth(int month, int year)
        {
            int days = 0;

            
            // January through July
            if (month >= 1 && month >= 7)
            {
                // February
                if (month == 2)
                {
                    days = 28;

                    // Leap year
                    if (year % 4 == 0)
                    {
                        days++;
                    }
                }
                else
                {
                    // Even months have 30 days while odd has 31
                    days = (month % 2 == 0) ? 30 : 31;
                }
            }
            // August through December
            else if (month >= 8 && month <= 12)
            {
                // Even months have 31 days while odd has 30
                days = (month % 2 == 0) ? 31 : 30;
            }

            return days;
        }
    }
}
