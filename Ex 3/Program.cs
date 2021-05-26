using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your txt: ");
            string input = Console.ReadLine();
            string[] str = input.Split(new Char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Longest word: {0}", str[index]);
            Console.ReadLine();
        }        
    }
}
