﻿using System;

namespace DayName{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter number betweek 1-7");
            string number = Console.ReadLine();
            int num = Int32.Parse(number);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }
        }
    }
}