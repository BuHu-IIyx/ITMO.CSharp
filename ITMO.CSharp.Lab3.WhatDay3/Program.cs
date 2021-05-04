﻿using System;

namespace ITMO.CSharp.Lab3.WhatDay3
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());

                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0)||(yearNum % 400 == 0);
                int maxDayNum;
                
                if (isLeapYear)
                {
                    maxDayNum = 366;
                    Console.WriteLine("IS a leap year");
                }
                else
                {
                    maxDayNum = 365;
                    Console.WriteLine("is NOT a leap year");
                }

                Console.Write("Please input a day number between 1 and {0}: ", maxDayNum);
                int dayNum = int.Parse(Console.ReadLine());
                
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of Range");
                }
                int monthNum = 0;

                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }


                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
        // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static System.Collections.ICollection DaysInLeapMonths
            = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
}