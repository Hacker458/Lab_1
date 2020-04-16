using System;
using System.Collections.Generic;
using System.Text;

namespace MyDllLib
{
    public class Task_3
    {
        public static void StartTask3()
        {
            Console.Write("EPS: ");
            double eps = double.Parse(Console.ReadLine());
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());
            double correct = getCorrectFunc(x);
            Console.WriteLine($"Точное значение = {correct}");
            double sum = getSum(eps, x);
            Console.WriteLine($"Результат значение = {sum}");
            Console.WriteLine($"Процент ошибки = {calculateError(correct, sum)}%");
        }
        public static double foo(int i, int x) => Math.Cos(i * x) / i;
        public static double getSum(double eps, int x)
        {
            double sum = 0;
            double u = 0;
            int i = 1;
            do
            {
                u = foo(i, x);
                sum += u;
                i++;
            } while (Math.Abs(u) > eps);
            return sum;
        }
        public static double getCorrectFunc(int x)
        {
            return -1 * Math.Log(Math.Abs(2 * Math.Sin(x / 2)));
        }
        public static double calculateError(double correct, double sum)
        {
            return Math.Round(Math.Abs((Math.Abs(sum - correct) / correct) * 100), 2);
        }
    }
}
