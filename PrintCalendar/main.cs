/*
               " sharing is caring "
          any suggestion or idea is welcomed
                  -  Amine Smahi  -
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            printCalendarOfSomeYear();
        }
        
        static void printCalendarOfSomeYear()
        {
            string month;
            int firstDayOfMonth;
            bool leapYear;
            int year; 
            
            try
            {
               year = Int32.Parse(Console.ReadLine()); //Get the number of the year from the user
            }
            
            catch (Exception)
            {
                Console.WriteLine("Error, you had input invalid year number.");
                year = 2017;
            }
                
            Console.WriteLine ("{0} YEAR CALENDAR", year);
            Console.WriteLine ();

            leapYear = ((year%400 == 0)||((year%4 == 0)&&(year%100 != 0))) ? true : false; //Define is year leap or not
            DateTime myDate = new DateTime(year, 01, 01); 
            DateTime operationalDate = new DateTime(); //some Date object to work with
            
            
            //Print every month calendar
            for (int i = 0; i<12; i++)
            {
                operationalDate = myDate.AddMonths(i);
                month = operationalDate.ToString("MMM", CultureInfo.InvariantCulture);
                printMonthAndWeekDayName(month);
                firstDayOfMonth = (int) operationalDate.DayOfWeek; //Define what day of a week is first day of month
                
                printDaysOfMonth (firstDayOfMonth, i, leapYear);
                Console.WriteLine();
            }
            
        }
        
        static void printMonthAndWeekDayName(string month)
        {
            Console.WriteLine("{0}   Su Mo Tu We Th Fr St", month); //Print head of every month calendar
        }
        
        static void printDaysOfMonth(int firstDayOfMonth, int monthNum, bool leapYear)
        {
            int daysQuantity = 0;
            int dayNumber = 0;
            
            //Define days quantity in month
            switch (++monthNum)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysQuantity = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysQuantity = 30;
                    break;
                case 2:
                    if (leapYear)
                    {daysQuantity = 29;}
                    else
                    {daysQuantity = 28;}
                    break;
            }
            
            int numberOfWeeks = 0;
            
            //Define how many weeks there are in month
            if ((daysQuantity + firstDayOfMonth) % 7 > 0)
            {
                numberOfWeeks = ((daysQuantity + firstDayOfMonth) / 7) + 1;
            }
            
            else
            {
                numberOfWeeks = (daysQuantity + firstDayOfMonth) / 7;
            }
            

            
            for (int k = 1; k <= numberOfWeeks; k++)
            {
                Console.Write ("{0}", createWhiteSpaces (firstDayOfMonth, k));
                
                int j = 1;
                
                if (k == 1) {j = firstDayOfMonth + 1;}
               
                while ((j <= 7) && (dayNumber<daysQuantity))
                {
                    j++;
                    dayNumber++;
                    if (dayNumber < 10) Console.Write ("0");
                    Console.Write ("{0} ", dayNumber);
                }
                
                Console.WriteLine();

            }
            
        }
        
        static string createWhiteSpaces (int firstDayOfMonth, int weekNumber)
        {
            string blankSpace = "";
            
            if (weekNumber == 1)
            {
                for (int m = 0; m < (6 + (firstDayOfMonth*3)); m++)
                {
                    blankSpace += " ";
                }
            }
            else
            {
                blankSpace = "      ";
            }
            
            return blankSpace;
        }
    }
} 
