using System;

namespace MulCal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter a number for multipling");
            string enterNum = Console.ReadLine();
            int num = Int32.Parse(enterNum);

            for (int i = 1; i < 11; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} * {i} = {result}");
            }
        }
    }
}