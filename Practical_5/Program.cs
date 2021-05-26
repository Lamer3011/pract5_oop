using System;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; ++i)

                if (a[i] > max) { max = a[i]; }
            return max;
        }
        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,5} ", a[i]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines");
            int N = int.Parse(Console.ReadLine());
            int[][] array = new int[N][];
            array[0] = new int[1];


            for (int i = 1; i < N; i++)
            {
                array[i] = new int[i * 2 + 1];

            }

            for (int i = 0; i < N; i++)
            {
                int len = array[i].Length;
                string s = "";

                for (int j = 0; j < len; j++)
                {

                    array[i][j] = j + 1;
                    s += array[i][j].ToString() + " ";

                }
                Console.WriteLine($"Array: {i}: ");
                Console.WriteLine(s);
                Console.WriteLine("Maximum element for an array: " + Max(array[i]));

            }

            int[] rez = new int[array.Length]; 
            for (int i = 0; i < array.Length; i++)
                rez[i] = Max(array[i]);
            int sum = rez.Sum();
            Console.WriteLine("The sum of the maximum elements of the array: " + sum);

            Console.ReadKey();
        }
    }
}
  