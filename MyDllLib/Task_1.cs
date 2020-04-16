using System;

namespace MyDllLib
{
    public class Task_1
    {
        public static void StartTask1()
        {
            Console.Write("Сторона первого прямоугольника А: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Сторона первого прямоугольника В: ");
            var b = int.Parse(Console.ReadLine());
            Rectangle rect_small = new Rectangle(a, b);
            rect_small.calculateRecatangleSquard();
            RectangleBig rect_big = new RectangleBig();
            var unknown = rect_big.calculateRecatangleUnknownSide();
            Console.WriteLine($"Неизвестная сторона С второго прямоугольника = {unknown}");
        }
    }

    public class Rectangle
    {
        private double A { get; set; }
        protected static double B { get; set; }
        protected static double S1 { get; set; }
        public Rectangle() { }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public void calculateRecatangleSquard() => S1 = A * B;
    }

    public sealed class RectangleBig : Rectangle
    {
        private double C { get; set; } = Rectangle.B - 6;
        private double X { get; set; }
        private double S2 { get; set; }

        public double calculateRecatangleUnknownSide()
        {
            S2 = Rectangle.S1 - 6;
            X = S2 / C;
            return X;
        }
    }
}
