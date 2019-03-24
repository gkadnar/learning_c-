using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageBasics.ArrayBasics
{
    class Arrays
    {
        public static void Example01()
        {
            Console.WriteLine("**********ArrayBasics.Example01 BEGIN***************");

            char[] vowels = new char[5];    // Declare an array of 5 characters
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';
            Console.WriteLine(vowels[1]);      // e
            for (int i = 0; i < vowels.Length; i++)
                Console.Write(vowels[i]);            // aeiou
            Console.WriteLine();

            // Declaration and initialization in one statement 
            char[] vowels2 = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] vowels3 = { 'a', 'e', 'i', 'o', 'u' };

            // Default element initialization
            int[] a = new int[1000];
            Console.WriteLine(a[123]);            // 0

            Console.WriteLine("**********ArrayBasics.Example01 END*****************");
        }

        public static void Example02()
        {
            Console.WriteLine("**********ArrayBasics.Example02 BEGIN***************");
            Console.WriteLine("**********Multidimensional Arrays*******************");

            //Rectangular arrays
            Console.WriteLine("Rectangular arrays");
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * 3 + j;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            // Default element initialization
            int[,] rectangularMatrix =
            {
              {0,1,2},
              {3,4,5},
              {6,7,8}
            };
            var rectMatrix = new int[,]    // rectMatrix is implicitly of type int[,]
            {
              {0,1,2},
              {3,4,5},
              {6,7,8}
            };


            //Jagged arrays
            Console.WriteLine("Jagged arrays");
            int[][] matrix2 = new int[3][];

            for (int i = 0; i < matrix2.Length; i++)
            {
                matrix2[i] = new int[3];                    // Create inner array
                for (int j = 0; j < matrix2[i].Length; j++)
                {
                    matrix2[i][j] = i * 3 + j;
                    Console.Write($"{matrix2[i][j]} ");
                }
                Console.WriteLine();
            }
            // Default element initialization
            int[][] jaggedMatrix =
            {
              new int[] {0,1,2},
              new int[] {3,4,5},
              new int[] {6,7,8}
            };
            var jaggedMat = new int[][]    // jaggedMat is implicitly of type int[][]
            {
              new int[] {0,1,2},
              new int[] {3,4,5},
              new int[] {6,7,8}
            };


            // Bounds Checking
            try
            {
                int[] arr = new int[3];
                arr[3] = 1;               // IndexOutOfRangeException thrown
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException caught.");
            }
            Console.WriteLine("**********ArrayBasics.Example02 END*****************");
        }
    }
}
