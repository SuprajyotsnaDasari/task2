using System;

namespace GradeEvaluator{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter the marks (0-100)?");
            string marks = Console.ReadLine();
            int mark = Int32.Parse(marks);

            if (mark >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}