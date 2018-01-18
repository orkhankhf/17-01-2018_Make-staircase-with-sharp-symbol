using System;

namespace Make_staircase_with_sharp_symbol
{
    class Program
    {
        //Enter a int value to see result
        static void staircase(int n)
        {
            string[] stc = new string[n];
            for (int a = 0; a < n; a++)
            {
                for (int c = 0; c < a; c++)
                {
                    stc[a] += " ";
                }
                for (int c = 0; c < (n - a); c++)
                {
                    stc[a] += "#";
                }
            }
            Array.Reverse(stc);
            foreach (var item in stc)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
        }
    }
}
