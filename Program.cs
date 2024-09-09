using System;
using System.Globalization;

class Program
{
    static void CartesianToPolar(double x, double y, int precision)
    {
        double r = Math.Sqrt(x * x + y * y);
        double theta = Math.Atan2(y, x);

        Console.WriteLine($"Полярные координаты: r = {Math.Round(r, precision)}, θ = {Math.Round(theta, precision)} радиан");
    }

    static void PolarToCartesian(double r, double theta, int precision)
    {
        double x = r * Math.Cos(theta);
        double y = r * Math.Sin(theta);

        Console.WriteLine($"Декартовы координаты: x = {Math.Round(x, precision)}, y = {Math.Round(y, precision)}");
    }

    static void Main()
    {
        int choice;
        double x, y, r, theta;
        int precision;

        Console.WriteLine("Выберите тип преобразования:");
        Console.WriteLine("1. Декартовы -> Полярные (2D)");
        Console.WriteLine("2. Полярные -> Декартовы (2D)");
        Console.Write("Ваш выбор: ");
        choice = int.Parse(Console.ReadLine());

        Console.Write("Введите точность (количество знаков после запятой): ");
        precision = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Введите X: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Введите Y: ");
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CartesianToPolar(x, y, precision);
        }
        else if (choice == 2)
        {
            Console.Write("Введите r (радиус): ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Введите θ (угол в радианах): ");
            theta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            PolarToCartesian(r, theta, precision);
        }
        else
        {
            Console.WriteLine("Неверный выбор. Программа завершена.");
        }
    }
}