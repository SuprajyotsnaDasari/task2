using System;

namespace LeapYear{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a year:");
            string yearEntered = Console.ReadLine();

            int year = Int32.Parse(yearEntered);

            if (year%4 == 0 && (year%100 != 0 || year%400 != 0))
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not Leap Year");
        }
    }
}