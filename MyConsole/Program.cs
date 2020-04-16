using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMySin
{
    class Program
    {
        static void Main(string[] args)
        {
            int task;
            bool flag = true;
            while (flag)
            {
                Console.Write("Номер (1-3) задания: ");
                if (!int.TryParse(Console.ReadLine(), out task) && task > 0 && task < 4)
                {
                    Console.Write("Номер (1-3) задания: ");
                }
                switch (task)
                {
                    case 1:
                        MyDllLib.Task_1.StartTask1();
                        break;
                    case 2:
                        MyDllLib.Task_2.StartTask2();
                        break;
                    case 3:
                        MyDllLib.Task_3.StartTask3();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
                Console.WriteLine("Чтобы продолжить нажмите F1");
                if (Console.ReadKey(true).Key != ConsoleKey.F1)
                {
                    flag = false;
                }
                Console.Clear();
            }
        }
    }
}
