﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace MyFirstProgram
{
   class MyFristTask28
   {
      static void Main(string[] args)
      {
         for (int year = 2000; year <= 2020; year++)
         {
            if (DateTime.IsLeapYear(year))
            {
               Console.WriteLine("{0} is a leap year.", year);
               DateTime leapDay = new DateTime(year, 2, 29);
               DateTime nextYear = leapDay.AddYears(1);
               Console.WriteLine("   One year from {0} is {1}.", leapDay.ToString("d"), nextYear.ToString("d"));
               Console.WriteLine();
            }   
         }
      }
   }
}


