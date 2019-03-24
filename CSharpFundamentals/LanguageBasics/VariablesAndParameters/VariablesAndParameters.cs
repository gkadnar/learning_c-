using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.VariablesAndParameters
{
    class VarsAndPArams
    {

        static int staticx;
        // Recursive function, where parameter x is allocated on stack when method is entered
        // and deallocated when method exits.
        private static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        private static void HeapExample()
        {
            StringBuilder ref1 = new StringBuilder("object1");
            Console.WriteLine(ref1);
            // The StringBuilder referenced by ref1 is now eligible for GC.

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            // The StringBuilder referenced by ref2 is NOT yet eligible for GC.

            Console.WriteLine(ref3);                   // object2
        }
        public static void Example01()
        {
            Console.WriteLine("**********VariablesAndParameters.Example01 BEGIN***************");

            //Stack
            Console.WriteLine($"Example of stack: {Factorial(5)}");
            //Heap
            Console.WriteLine("Example of heap:");
            HeapExample();

            //Definite Assignment
            int x;
            //Console.WriteLine(x);        // Compile-time error cause x is not initialized
            int[] ints = new int[2];
            Console.WriteLine(ints[0]);    // 0 cause array elements are implicitly initialized
            Console.WriteLine(staticx);    // 0 cause fields are also implicitly initialized

            Console.WriteLine("**********VariablesAndParameters.Example01 END******************");
        }

        private static void passByValue1(int p)
        {
            p = p + 1;                // Increment p by 1
            Console.WriteLine(p);    // Write p to screen
        }
        private static void passByValue2(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
        private static void passByReference1(ref int p)
        {
            p = p + 1;                // Increment p by 1
            Console.WriteLine(p);    // Write p to screen
        }
        private static void passByReference2(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        private static void passByReference3(string name, out string firstNames,
                     out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
        private static void passByReference4(out int y)
        {
            Console.WriteLine(staticx);                // x is 0
            y = 1;                                      // Mutate y
            Console.WriteLine(staticx);                // x is 1
        }
        private static int sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i];                       // Increase sum by ints[i]
            return sum;
        }
        private static void optionalParameters(int x = 0, int y = 0)
        {
            Console.WriteLine(x + ", " + y);
        }
        static string X = "Old Value";
        //static ref string GetX() => ref X;    // This method returns a ref
        // This method returns a ref or as above with lambda
        static ref string GetX()
        {
            return ref X;
        }

        public static void Example02()
        {
            Console.WriteLine("**********VariablesAndParameters.Example02 BEGIN***************");
            Console.WriteLine("**********Parameters*******************************************");

            // pass by value example of value types.
            int x = 8;
            passByValue1(x);         // Make a copy of x
            Console.WriteLine(x);    // x will still be 8

            // pass by value reference types
            StringBuilder sb = new StringBuilder();
            passByValue2(sb);
            Console.WriteLine(sb.ToString());    // test

            // pass by reference example of value types.
            int xx = 8;
            passByReference1(ref xx);            // Ask passByReference1 to deal directly with xx
            Console.WriteLine(xx);               // xx is now 9

            // pass by reference reference types
            string sxx = "Penn";
            string syy = "Teller";
            passByReference2(ref sxx, ref syy);
            Console.WriteLine(sxx);   // Teller
            Console.WriteLine(syy);   // Penn

            // pass by reference using out modifier
            string a, b;
            passByReference3("Stevie Ray Vaughan", out a, out b);
            Console.WriteLine(a);                      // Stevie Ray
            Console.WriteLine(b);                      // Vaughan

            //same as above but declaring aa and bb on the fly
            passByReference3("Stevie Ray Vaughan", out string aa, out string bb);
            Console.WriteLine(aa);                      // Stevie Ray
            Console.WriteLine(bb);                      // Vaughan

            //discarding out parameters with _ as discard symbol
            passByReference3("Stevie Ray Vaughan", out string aa2, out _);   // Discard the 2nd param
            Console.WriteLine(aa2);

            //pass by reference change static varaible value
            passByReference4(out staticx);

            //using params to pass array
            int total = sum(1, 2, 3, 4);
            Console.WriteLine(total);              // 10
            int total2 = sum(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(total2);              // 10

            // optional parameters
            optionalParameters(1);    // 1, 0

            //named arguments
            optionalParameters(x: 1, y: 2);  // 1, 2
            optionalParameters(x: 1, y: 2);
            optionalParameters(y: 2, x: 1);
            int aaa = 0;
            optionalParameters(y: ++aaa, x: --aaa);  // ++a is evaluated first
            optionalParameters(1, y: 2);
            //optionalParameters(x: 1, 2);         // Compile-time error

            //ref locals
            int[] numbers = { 0, 1, 2, 3, 4 };
            ref int numRef = ref numbers[2];
            numRef *= 10;
            Console.WriteLine(numRef);        // 20
            Console.WriteLine(numbers[2]);   // 20

            //ref returns
            ref string xRef = ref GetX();       // Assign result to a ref local
            xRef = "New Value";
            Console.WriteLine(X);              // New Value

            Console.WriteLine("**********VariablesAndParameters.Example02 END******************");
        }


    }
}
