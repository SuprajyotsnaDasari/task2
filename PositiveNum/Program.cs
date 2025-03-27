using System;

namespace PositiveNum {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a positive value");
            

            while (true)
            {
                string numEnter = Console.ReadLine();
                int num = Int32.Parse(numEnter);

                if (num >= 0)
                {
                    Console.WriteLine($"Entered value: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Entered value is negative, please enter positive value.");
                }

            }
        }
    }
}