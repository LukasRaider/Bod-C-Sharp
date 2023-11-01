using System;

namespace Bod
{
    class Bod
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double VzdXY(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        public double VzdBod(Bod bod)
        {
            return Math.Sqrt(bod.X * bod.X + bod.Y * bod.Y);
        }

        public double Vzd()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    class TestBod
    {
        public static void Mainx()
        {
            Bod b1 = new Bod(3, 4);
            Bod b2 = new Bod(8,5);
            double vzd1 = b1.VzdXY(3, 4);
            double vzd2 = b1.VzdBod(b1);
            double vzd3 = b1.Vzd();
            double vzd4 = b1.VzdBod(b2);

            Console.WriteLine($"Vzdálenost od počátku (metoda VzdXY): {vzd1}");
            Console.WriteLine($"Vzdálenost od počátku (metoda VzdBod): {vzd2}");
            Console.WriteLine($"Vzdálenost od počátku (metoda Vzd): {vzd3}");
            Console.WriteLine($"Vzdálenost od počátku (metoda Vzd): {vzd4}");
        }
    }
}