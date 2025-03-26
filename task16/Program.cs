using System;

namespace UserInput {
    class Program {
        static void Main(string[] args) {
            string userInput;

            do {
                Console.WriteLine("Enter something (type 'exit' to stop):");
                userInput = Console.ReadLine();

                if (userInput.ToLower() != "exit") {
                    Console.WriteLine($"You entered: {userInput}");
                }
            } while (userInput.ToLower() != "exit");

            Console.WriteLine("Goodbye!");
        }
    }
}
