using System;

namespace orderedItem{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter a number between 1-5");
            string enteredNum = Console.ReadLine();

            int num =Int32.Parse(enteredNum);
            switch (num)
            {
                case 1:
                    Console.WriteLine("Coffee");
                    break;
                case 2:
                    Console.WriteLine("Tea");
                    break;
                case 3:
                    Console.WriteLine("Juice");
                    break;
                case 4:
                    Console.WriteLine("Water");
                    break;
                case 5:
                    Console.WriteLine("Soda");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}