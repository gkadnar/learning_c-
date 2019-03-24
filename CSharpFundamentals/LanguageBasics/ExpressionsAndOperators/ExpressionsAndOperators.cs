using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.ExpressionsAndOperators
{
    class ExprsAndOpss
    {
        public static void Example01()
        {
            Console.WriteLine("**********ExpressionsAndOperators.Example01 BEGIN**********");

            Console.WriteLine($"Constant expression: {12}");
            Console.WriteLine($"Expression operands: {12*30}");
            Console.WriteLine($"Complex expression:  {1+(12*30)}");
            Console.WriteLine($"Primary expression:  {Math.Log(1)}");
            Console.WriteLine(1);   // void expression

            // assignment expressions evaluated from right to left
            var x = 1;
            x = x * 5;
            var y = 5 * (x = 2);

            // compound assignment operators
            x *= 2;    // equivalent to x = x * 2
            x <<= 1;   // equivalent to x = x << 1

            //left associative operators
            Console.WriteLine($"left associative operators:  {(8 / 4 / 2)}");

            //rigth associative operators
            x = y = 3;
            Console.WriteLine($"right associative operators:  {x},{y}");

            //Null Coalescing Operator
            string s1 = null;
            string s2 = s1 ?? "nothing";   // s2 evaluates to "nothing"
            Console.WriteLine($"Null Coalescing Operator:  {s1},{s2}");

            //Null-conditional Operator
            System.Text.StringBuilder sb = null;
            Console.WriteLine($"Null Conditional Operator1:  {sb?.ToString()}");            // No error; s instead evaluates to null
            Console.WriteLine($"Null Conditional Operator2:  {sb?.ToString().ToUpper()}"); // No error; s instead evaluates to null
            Console.WriteLine($"Null Conditional Operator2:  {sb?.ToString() ?? "nothing"}"); 
            
            Console.WriteLine("**********ExpressionsAndOperators.Example01 END*************");
        }
    }
}
