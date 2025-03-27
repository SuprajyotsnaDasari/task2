using System;

namespace SeasonName{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number between 1-4");
            string enteredNum = Console.ReadLine();

            int num = Int32.Parse(enteredNum);

            switch (num)
            {
                case 1:
                    Console.WriteLine("Spring");
                    break;
                case 2:
                    Console.WriteLine("Summer");
                    break;
                case 3:
                    Console.WriteLine("Autumn");
                    break;
                case 4:
                    Console.WriteLine("Winter");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}