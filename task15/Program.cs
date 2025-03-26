//Write a program that asks the user to guess a number between 1 and 10. Keep asking until the user guesses the correct number (use the number 7 as the correct answer).
using System;

namespace GuessNum {
    class Program {
        static void Main(string[] args){
            int correctNum = 7;
            int num;

            
            do{
                Console.WriteLine("Enter a number between 1 - 10");
                string enterNum = Console.ReadLine();
                num = Int32.Parse(enterNum);

                if (correctNum != num)
                {
                    Console.WriteLine("Guessed the wrong number");
                }
            } while (num != correctNum);  
            Console.WriteLine("Congratulations! You guessed the correct number.");
        }

    }
}

