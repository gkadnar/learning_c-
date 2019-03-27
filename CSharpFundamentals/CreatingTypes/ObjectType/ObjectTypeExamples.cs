using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingTypes.ObjectType
{
    class ObjectTypeExamples
    {
        public static void Example01()
        {
            Console.WriteLine("ObjectTypeExamples");

            // basic Stack example demonstrate how object can be anything even a value type like int
            Stack stack = new Stack();
            stack.Push("sausage");
            string s = (string)stack.Pop();   // Downcast, so explicit cast is needed
            Console.WriteLine(s);             // sausage
            stack.Push(3);
            int three = (int)stack.Pop();
            Console.WriteLine(three);             // 3

            basicBoxingNUnboxingExamples();
            staticAndRuntimeTypeChecking();
            getTypeAndTypeOfExamples();
        }

        public class Stack
        {
            int position;
            object[] data = new object[10];
            public void Push(object obj) { data[position++] = obj; }
            public object Pop() { return data[--position]; }
        }

        private class Point { public int X, Y; }
        private static void basicBoxingNUnboxingExamples()
        {
            Console.WriteLine("basicBoxingNUnboxingExamples");

            int x = 9;
            object obj = x;           // Box the int
            int y = (int)obj;         // Unbox the int
            Console.WriteLine(obj);


            object obj2 = 9;           // 9 is inferred to be of type int
            //long x2 = (long)obj2;      // InvalidCastException
            Console.WriteLine(obj2);

            object obj3 = 9;
            long x3 = (int)obj3;
            Console.WriteLine(obj3);

            object obj4 = 3.5;              // 3.5 is inferred to be of type double
            int x4 = (int)(double)obj4;    // x is now 3
            Console.WriteLine(obj4);

            object[] a1 = new string[3];   // Legal
            //object[] a2 = new int[3];      // Error

            int i = 3;
            object boxed = i;
            i = 5;
            Console.WriteLine(boxed);    // 3
        }

        private static void staticAndRuntimeTypeChecking()
        {
            Console.WriteLine("staticAndRuntimeTypeChecking");

            //int x = "5";                    // Checked at compile time

            //object y = "5";
            //int z = (int)y;                 // Runtime error, downcast failed
        }

        private static void getTypeAndTypeOfExamples()
        {
            Point p = new Point();
            Console.WriteLine(p.GetType().Name);             // Point
            Console.WriteLine(typeof(Point).Name);          // Point
            Console.WriteLine(p.GetType() == typeof(Point)); // True
            Console.WriteLine(p.X.GetType().Name);           // Int32
            Console.WriteLine(p.Y.GetType().FullName);       // System.Int32
        }
    }
}
