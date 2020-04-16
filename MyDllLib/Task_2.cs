using System;
using System.Collections.Generic;
using System.Text;

namespace MyDllLib
{
    public class Task_2
    {
        public static void StartTask2()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма ряда = {getSum(n, x)}");
        }

        public static double getSum(int n, int x)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += Math.Cos(2 * i * x) / i;
            }
            return Math.Round(s, 3);
        }
    }
}
