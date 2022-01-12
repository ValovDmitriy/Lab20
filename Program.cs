using System;

namespace Lab20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double rad = Convert.ToDouble(Console.ReadLine());
            DSV dsv = Сircumference;
            dsv += AreaCircle;
            dsv += VolumeSphere;
            dsv(rad);
        }
        static double Сircumference(double radius)
        {
            double d = 2 * Math.PI * radius;
            Console.WriteLine("Длина окружности - {0}", d);
            return d;
        }
        static double AreaCircle(double radius)
        {
            double s = Math.PI * radius * radius;
            Console.WriteLine("Площадь окружности - {0}", s);
            return s;
        }

        static double VolumeSphere(double radius)
        {
            double v = 4 / 3 * Math.PI * radius * radius * radius;
            Console.WriteLine("Объем сферы - {0}", v);
            return v;
        }
        delegate double DSV(double radius);
    }
}
