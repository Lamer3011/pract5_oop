using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort: ");

            int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};           
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] > arrayInt[j])
                    {
                        int tmp = arrayInt[i];
                        arrayInt[i] = arrayInt[j];
                        arrayInt[j] = tmp;
                    }
                }
            }
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }

            
            Console.WriteLine("\n Insert sort: ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};
            int min;
            int minI;            
            for (int i = 0; i < arrayInt.Length-1; i++)
            {
                min = arrayInt[i];
                minI = i;
                for (int j = i+1; j < arrayInt.Length; j++)
                {
                    if (min > arrayInt[j])
                    {
                        minI = j;
                        min = arrayInt[j];
                    }
                }
                arrayInt[minI] = arrayInt[i];
                arrayInt[i] = min;
            }

            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine("\n Sort by Array.Sort (): ");
            // int[] arrayInt = { 13, 41, 94, 5, 12, 54, 66, 41, 95};

            Array.Sort(arrayInt);
            foreach (int a in arrayInt)
            {
                Console.Write($"{a} ");
            }
            
            string[] arrayStr = { "apple", "welcome", "gnome", "member", "spring", "book" };
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("\n Array to sort: ");
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Index of the 'gnome' element in the array: ");
            Console.WriteLine(Array.IndexOf(arrayStr, "welcome"));
            Console.WriteLine(Array.BinarySearch(arrayStr, "welcome"));

            Console.Write("\n Sort string by Array.Sort () method: ");
            Array.Sort(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Index of the 'gnome' element in the array after sorting: ");
            Console.WriteLine(Array.IndexOf(arrayStr, "welcome"));
            Console.WriteLine(Array.BinarySearch(arrayStr, "welcome"));

            Console.Write("\n Inverting a string using the Array.Reverse () method: ");
            Array.Reverse(arrayStr);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("\n");
            Console.Write("Clear the value of the Array.Clear () element: ");
            Array.Clear(arrayStr, 2, arrayStr.Length-2);
            foreach (string a in arrayStr)
            {
                Console.Write($"{a} ");
            }

            string[] arrayStr1 = new String[arrayStr.Length - 2];
            string[] arrayStr2 = new String[arrayStr.Length - 2];
            Array.Copy(arrayStr, arrayStr1, arrayStr.Length-2);
            Array.Copy(arrayStr, 2,  arrayStr2, 0, arrayStr.Length - 2);
            Console.WriteLine("\n");
            Console.Write("arrayStr1: ");
            foreach (string a in arrayStr1)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine("\n");
            Console.Write("arrayStr2: ");
            foreach (string a in arrayStr2)
            {
                Console.Write($"{a} ");
            }

            Console.ReadKey();
        }        
    }
}
