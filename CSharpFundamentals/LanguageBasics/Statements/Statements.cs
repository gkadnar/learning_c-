using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.Statements
{
    class Stejtments
    {
        public static void Example01()
        {
            Console.WriteLine("**********Statements.Example01 BEGIN**********");

            //variable declaration
            string someWord = "rosebud";
            int someNumber = 42;
            bool rich = true, famous = false;

            //constant declaration
            const double c = 2.99792458E08;
            //c += 10;                        // Compile-time Error

            // Declare variables with declaration statements:
            string s;
            int x, y;
            System.Text.StringBuilder sb;

            // Expression statements
            x = 1 + 2;                 // Assignment expression
            x++;                       // Increment expression
            y = Math.Max(x, 5);       // Assignment expression
            Console.WriteLine(y);     // Method call expression
            sb = new StringBuilder();  // Assignment expression
            new StringBuilder();       // Object instantiation expression

            new StringBuilder();     // Legal, but useless
            new string('c', 3);     // Legal, but useless
            x.Equals(y);            // Legal, but useless

            Console.WriteLine("**********Statements.Example01 END*************");
        }

        public static void Example02()
        {
            Console.WriteLine("**********Statements.Example02 BEGIN**********");
            Console.WriteLine("**********Selection Statements****************");

            //if statements
            Console.WriteLine("IF statements");
            ifStatements();

            //switch statements
            Console.WriteLine("SWITCH statements");
            switchStatements();

            Console.WriteLine("**********Statements.Example02 END*************");
        }

        public static void Example03()
        {
            Console.WriteLine("**********Statements.Example03 BEGIN**********");
            Console.WriteLine("**********Iteration Statements****************");

            //while example
            int i = 0;
            while (i < 3)
            {
                Console.Write(i+", ");
                i++;
            }
            Console.WriteLine();

            //do-while example
            i = 0;
            do
            {
                Console.Write(i+", ");
                i++;
            }
            while (i < 3);
            Console.WriteLine();

            //for loop examples
            for (int j = 0; j < 3; j++)
                Console.Write(j+", ");
            Console.WriteLine();

            for (int j = 0, prevFib = 1, curFib = 1; j < 10; j++)
            {
                Console.Write(prevFib+", ");
                int newFib = prevFib + curFib;
                prevFib = curFib; curFib = newFib;
            }
            Console.WriteLine();

            //for-each example
            foreach (char c in "beer")   // c is the iteration variable
                Console.Write(c+", ");
            Console.WriteLine();

            Console.WriteLine("**********Statements.Example03 END*************");
        }

        public static void Example04()
        {
            Console.WriteLine("**********Statements.Example04 BEGIN**********");
            Console.WriteLine("**********Jump Statements*********************");

            //break statement example
            int x = 0;
            while (true)
            {
                if (x++ > 5)
                    break;      // break from the loop
                Console.Write(x + ", ");
            }
            Console.WriteLine();
            // execution continues here after break

            //continue statement example
            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) == 0)       // If i is even,
                    continue;             // continue with next iteration

                Console.Write(i + " ");
            }
            Console.WriteLine();

            //goto statement example with label statements
            int j = 1;
            startLoop:
            if (j <= 5)
            {
                Console.Write(j + " ");
                j++;
                goto startLoop;
            }
            Console.WriteLine();

            Console.WriteLine("**********Statements.Example04 END*************");
        }

        private static void ifStatements()
        {
            if (5 < 2 * 3)
                Console.WriteLine("true");       // true

            if (5 < 2 * 3)
            {
                Console.WriteLine("true");
                Console.WriteLine("Let's move on!");
            }

            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else
                Console.WriteLine("False");        // False

            if (2 + 2 == 5)
                Console.WriteLine("Does not compute");
            else if (2 + 2 == 4)
                Console.WriteLine("Computes");    // Computes

            if (true)
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");

            if (true)
            {
                if (false)
                    Console.WriteLine();
                else
                    Console.WriteLine("executes");
            }

            if (true)
            {
                if (false)
                    Console.WriteLine();
            }
            else
                Console.WriteLine("does not execute");

            int age = 35;
            if (age >= 35)
                Console.WriteLine("You can be president!");
            else if (age >= 21)
                Console.WriteLine("You can drink!");
            else if (age >= 18)
                Console.WriteLine("You can vote!");
            else
                Console.WriteLine("You can wait!");
        }
        private static void switchStatements()
        {
            //basic switch example
            int cardNumber = -1;
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1:                         // Joker is -1
                    goto case 12;                  // In this game joker counts as queen
                default:                         // Executes for any other cardNumber
                    Console.WriteLine(cardNumber);
                    break;
            }

            //switch on type examples
            switchOnTypes(12);
            switchOnTypes("hello");
            switchOnTypes(true);

            //switch with when keyword examples
            bool x = true;
            switch (x)
            {
                case bool b when b == true:     // Fires only when b is true
                    Console.WriteLine("True!");
                    break;
                case bool b:
                    Console.WriteLine("False!");
                    break;
            }


        }
        private static void switchOnTypes(object x)   // object allows any type.
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("It's an int!");
                    Console.WriteLine($"The square of {i} is {i * i}");
                    break;
                case string s:
                    Console.WriteLine("It's a string");
                    Console.WriteLine($"The length of {s} is {s.Length}");
                    break;
                default:
                    Console.WriteLine("I don't know what x is");
                    break;
            }
        }


    }
}
