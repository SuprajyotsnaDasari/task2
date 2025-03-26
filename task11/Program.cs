using System;

namespace SpellWord {
    class Program {
        static void Main(string[] args) {
            string word = "Fibonacci";
            int wordLength = word.Length;
            int i =0;
            
            while (i < wordLength)
            {
                Console.WriteLine(word[i]);
                i++;
            }
        }
    }
}