using System;
namespace hh2
{
    class Programm
    {
        static void Main()
        {

            Console.WriteLine("Памятка!\n" +
                "Площадь какой фигуры вы хотите найти?\n" +
                "Каждая Фигура соответствует своей цифре:\n" +
                "1 - круг\n" +
                "2 - квадрат/прямоугольник\n" +
                "3 - треугольник");
            int n = int.Parse(Console.ReadLine());
            double a, b, c;
            if (n == 1)
            {
                Console.Write("Введите радиус:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine($"S = {Class1.Sqvear(a)}");
            }
            else if (n == 2)
            {
                Console.Write("Введите сторону a:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine($"S = {Class1.Sqvear(a,b)}");
            }
            else if (n == 3)
            {
                Console.Write("Введите сторону a:");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону b:");
                b = double.Parse(Console.ReadLine());
                Console.Write("Введите сторону c:");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine($"S = {Class1.Sqvear(a,b,c)}");
            }
            else Console.WriteLine("Неправильное число");
        }
    }
}
