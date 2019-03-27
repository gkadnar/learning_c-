using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingTypes.Generics
{
    class GenericsExamples
    {
        public static void Example01()
        {
            Console.WriteLine("Generic type example");
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            int x = stack.Pop();        // x is 10
            int y = stack.Pop();        // y is 5
            Console.WriteLine($"x={x}, y={y}");

            Console.WriteLine("Generic method example");
            int x2 = 5;
            int y2 = 10;
            Swap(ref x2, ref y2);
            Console.WriteLine($"x={x}, y={y}");
        }

        public class Stack<T>
        {
            int position;
            T[] data = new T[100];
            public void Push(T obj) => data[position++] = obj;
            public T Pop() => data[--position];
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
