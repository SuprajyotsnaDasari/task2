using System;

namespace TempCal{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the temperature:");
            string temperature = Console.ReadLine();
            int temp = Int32.Parse(temperature);

            if (temp >= 30)
                Console.WriteLine("Hot");
            else if (temp > 15 && temp<=29)
                Console.WriteLine("Warm");
            else
                Console.WriteLine("Cold");
        }
    }
}