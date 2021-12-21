using System;
using System.Collections.Generic;
namespace MKR_1
{
    class Program
    {
        public static void Main()
        {
            Random rnd = new Random();

            Console.Write("Введiть n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Чи є серед a(2n+1),..., a(3n) є рівні a1,..,a(2n)?");
            int[] a = new a[3 * n];
            for (int i = 1; i <= 3 * n; i++)
            {
                a[i] = rnd.Next(1, 100);


            }
            for (int j = 0; j < 3 * n; j++)
            {
                if (a[2 * i + 1] == a[i])
                {
                    Console.Write("Члени рівні ");
                }
            }

        }
    }
}