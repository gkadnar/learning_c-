using System;                                               // Importing namespace

namespace LanguageBasics                                    // Namespace declaration
{
    class Program                                           // Class declaration
    {
        static void Main(string[] args)                     // Method declaration
        {
            Console.WriteLine(MultiplyBy23(10));            // Statement 1
            Console.WriteLine(MultiplyBy23(23));            // Statement 2
        }                                                   // End of method

        static int MultiplyBy23(int number)
        {
            return number * 23;
        }

    }                                                       // End of class
}                       
