using System;

namespace CalCulator {
    class Program {
        static void Main (string[] args) {
            for (int i = 1; i < 101; i++)
            {
                int result = (i*(i+1))/2;
                Console.WriteLine(result);
            }
        }
    }
}