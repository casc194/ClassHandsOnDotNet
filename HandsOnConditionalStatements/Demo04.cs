﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.HandsOnConditionalStatements
{
    class Demo04
    {
        static void Main()
        {
            int k = 100;
            string s = Convert.ToString(k);
            s = k.ToString();
            Console.WriteLine("Enter Week of the Day");
            int no = Convert.ToInt32(Console.ReadLine());
            switch(no)
            {
                case 1:
                    Console.WriteLine("This is WeekDay and it is Monday");
                    break;
                case 2:
                    Console.WriteLine("This is WeekDay and it is Tuesdat");
                    break;
                case 3:
                    Console.WriteLine("This is WeekDay and it is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("This is WeekDay and it is Thusday");
                    break;
                case 5:
                    Console.WriteLine("This is WeekDay and it is Fridat");
                    break;
                case 6:
                    Console.WriteLine("This is WeekEnd and it is Satday");
                    break;
                case 7:
                    Console.WriteLine("This is WeekEnd and it is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Weekday");
                    break;

            }
            Console.ReadKey();
        }
    }
}
