using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.NumericTypes
{
    class Numerics
    {
        public static void Example01()
        {
            Console.WriteLine("**********NumericTypes.Example01 BEGIN**********");
            Console.WriteLine("**********Numeric types*************************");

            sbyte maliBajt = 1;                     // 8 bits signed integral value type
            short kratkiBajt = 1;                   // 16 bits signed integral value type
            int intValue = 1;                       // 32 bits signed integral value type
            long longValue = 1L;                    // 64 bits signed integral value type
            Console.WriteLine($"maliBajt={maliBajt}, kratkiBajt={kratkiBajt}, intValue={intValue}, longValue={longValue}");
            byte maliUBajt = 1;                      // 8 bits unsigned integral value type
            ushort kratkiUBajt = 1;                  // 16 bits unsigned integral value type
            uint intUValue = 1U;                     // 32 bits unsigned integral value type
            ulong longUValue = 1UL;                  // 64 bits unsigned integral value type
            Console.WriteLine($"maliUBajt={maliUBajt}, kratkiUBajt={kratkiUBajt}, intUValue={intUValue}, longUValue={longUValue}");
            float floatValue = 1.1F;                 // 32 bits floating-point value type
            double doubleValue = 1.1D;               // 64 bits floating-point value type
            decimal decimalValue = 1.1M;             // 128 bits real value type
            Console.WriteLine($"floatValue={floatValue}, doubleValue={doubleValue}, decimalValue={decimalValue}");

            Console.WriteLine("**********NumericTypes.Example01 END************\n");
        }

        public static void Example02()
        {
            Console.WriteLine("**********NumericTypes.Example02 BEGIN**********");
            Console.WriteLine("**********Numeric literals********************");

            int x = 127;
            long y = 0x7F;
            int intMillion = 1_000_000;
            var b = 0b1010_1011_1100_1101_1110_1111;
            double d = 1.5;
            double doubleMillion = 1E06;

            Console.WriteLine(1.0.GetType());  // Double  (double)
            Console.WriteLine(1E06.GetType());  // Double  (double)
            Console.WriteLine(1.GetType());  // Int32   (int)
            Console.WriteLine(0xF0000000.GetType());  // UInt32  (uint)
            Console.WriteLine(0x100000000.GetType());  // Int64   (long)
            Console.WriteLine(b.GetType());  // Int32   (int)

            long i = 5;              // Implicit lossless conversion from int literal to long

            double dx = 4.0;         // The D suffix is technically redundant

            float f = 4.5F;          // Without the F suffix it would not compile cause literal will by default infer double value
            decimal dd = -1.23M;     // Will not compile without the M suffix.

            Console.WriteLine("**********NumericTypes.Example02 END************\n");
        }

        public static void Example03()
        {
            Console.WriteLine("**********NumericTypes.Example03 BEGIN**********");
            Console.WriteLine("**********Numeric conversion********************");

            int x = 12345;       // int is a 32-bit integer
            long y = x;          // Implicit conversion to 64-bit integral type
            short z = (short)x;  // Explicit conversion to 16-bit integral type
            Console.WriteLine($"x={x}, y={y}, z={z}");

            float ff = 12.345F;     // float is a 32-bit real
            double dd = ff;         // Implicit conversion to 64-bit real
            //float ff2 = dd;         // not possible to do implicitly

            int i = 1;
            float f = i;
            int i2 = (int)f;
            Console.WriteLine($"Explicit conversion of float to int {i2}");

            int i3 = 100000001;
            float f2 = i3;          // Magnitude preserved, precision lost
            int i4 = (int)f2;       // 100000000
            Console.WriteLine($"Implicit conversion large integeral {i3} to float and back {i4}");

            Console.WriteLine("**********NumericTypes.Example03 END************\n");
        }

        public static void Example04()
        {
            Console.WriteLine("**********NumericTypes.Example04 BEGIN**********");
            Console.WriteLine("**********Arithmetic/Increment/Decrement *******");

            int plus = 1 + 1;
            int minus = 1 - 1;
            int puta = 1 * 1;
            int podijeljeno = 1 / 1;

            int x = 0, y = 0;
            Console.WriteLine(x++);   // Outputs 0; x is now 1
            Console.WriteLine(++y);   // Outputs 1; y is now 1

            Console.WriteLine("**********NumericTypes.Example04 END************\n");
        }

        public static void Example05()
        {
            Console.WriteLine("**********NumericTypes.Example05 BEGIN**********");
            Console.WriteLine("**********Special operations on integral types***");

            int a = 2 / 3;      // 0
             
            int b = 0;
            //int c = 5 / b;      // throws DivideByZeroException
            //int c = 5 / 0;        // generates compile-time error

            // overflow example
            int min = int.MinValue;
            min--;
            Console.WriteLine(min == int.MaxValue); // True

            // use checked to throw OverflowException when overflow occurs
            int a2 = 1000000;
            int b2 = 1000000;
            int c2;
            try
            {
                c2 = checked(a2 * b2);      // Checks just the expression.
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine("overflow occurs");
            }
            checked                       // Checks all expressions in statement block.
            { 
                try
                {
                    c2 = a2 * b2;
                }
                catch (OverflowException ofe)
                {
                    Console.WriteLine("overflow occurs");
                }
                
            }

            // Expressions evaluated at compile time are always overflow-checked
            // int x = int.MaxValue + 1;               // Compile-time error overflow 
            int y = unchecked(int.MaxValue + 1);   // No errors
            Console.WriteLine(y);

            // Bitwise operators
            Console.WriteLine($"Complement operator ~0xfU = {~0xfU}");
            Console.WriteLine($"And operator 0xf0 & 0x33 = {~0xf0 & 0x33}");
            Console.WriteLine($"Or  operator 0xf0 | 0x33 = {0xf0 | 0x33}");
            Console.WriteLine($"Exclusive Or operator 0xff00 ^ 0x0ff0  = {0xff00 ^ 0x0ff0 }");
            Console.WriteLine($"Shift left operator 0x20 << 2 = {0x20 << 2}");
            Console.WriteLine($"Shift right operator 0x20 >> 1 = {0x20 >> 1}");

            // 8- and 16-bit integral value types lacks arithmetics operators so they are implicitly promoted.
            short xx = 1, yy = 1;
            //short zz = xx + yy;          // Compile-time error since result is int, and conversion could cause loss of data
            short zz = (short)(xx + yy);   // OK

            Console.WriteLine("**********NumericTypes.Example05 END************\n");
        }

        public static void Example06()
        {
            Console.WriteLine("**********NumericTypes.Example06 BEGIN**********");
            Console.WriteLine("**********Special Float and Double Values*******");

            Console.WriteLine(double.NegativeInfinity);   // -Infinity
            Console.WriteLine(double.PositiveInfinity);   // +Infinity
            Console.WriteLine(double.NaN);   // NaN

            // dividing real value type by zero
            Console.WriteLine(1.0 / 0.0);                  //  Infinity
            Console.WriteLine(-1.0 / 0.0);                  // -Infinity
            Console.WriteLine(1.0 / -0.0);                  // -Infinity
            Console.WriteLine(-1.0 / -0.0);                  //  Infinity

            // dividint zero by zero, and infinity by infinity
            Console.WriteLine(0.0 / 0.0);                  //  NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0));   //  NaN

            //NaN is not equal to anything
            Console.WriteLine(0.0 / 0.0 == double.NaN);    // False
            Console.WriteLine(double.NaN == double.NaN);    // False

            //check if some value is NaN
            Console.WriteLine(double.IsNaN(0.0 / 0.0));   // True

            //
            Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));   // True

            //real numbers rounding errors
            decimal m = 1M / 6M;               // 0.1666666666666666666666666667M
            double d = 1.0 / 6.0;             // 0.16666666666666666
            decimal notQuiteWholeM = m + m + m + m + m + m;  // 1.0000000000000000000000000002M
            double notQuiteWholeD = d + d + d + d + d + d;  // 0.99999999999999989
            Console.WriteLine(notQuiteWholeM);
            Console.WriteLine(notQuiteWholeD);
            Console.WriteLine(notQuiteWholeM == 1M);   // False
            Console.WriteLine(notQuiteWholeD < 1.0);   // True

            Console.WriteLine("**********NumericTypes.Example06 END************\n");
        }
    }
}
