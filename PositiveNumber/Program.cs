 //positive number and continues asking until the user enters a number greater than 100.


 using System;

 namespace PositiveNumber {
    class Program {
        static void Main(string[] args) {
            int num;

            do{
                Console.WriteLine("Enter a number greater than 100");
                string enterNum = Console.ReadLine();
                num = Int32.Parse(enterNum);

                if (num > 100)
                {
                    Console.WriteLine("The number you entered is greater than 100");
                }
            } while (num <= 100);
            Console.WriteLine("Number entered is not greater than 100");

        }

    }
 }
    
 