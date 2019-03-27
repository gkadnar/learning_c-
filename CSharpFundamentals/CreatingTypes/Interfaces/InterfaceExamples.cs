using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CreatingTypes.Interfaces
{
    class InterfaceExamples
    {
        public static void Example01()
        {
            Console.WriteLine("InterfaceExamples");
            IEnumerator e = new Countdown();
            while (e.MoveNext())
                Console.Write(e.Current);      // 109876543210
            Console.WriteLine();

        }

        internal class Countdown : IEnumerator
        {
            int count = 11;
            public bool MoveNext() => count-- > 0;
            public object Current => count;
            public void Reset() { throw new NotSupportedException(); }
        }

        public interface IUndoable { void Undo(); }
        public interface IRedoable : IUndoable { void Redo(); }
    }
}
