using System;

class Program
{
    static void Main()
    {
        double x, r;

        while (true)
        {
            Console.Write("Введите значение x: ");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка");
                continue;
            }

            if (0 < x && x < 3.14)
            {
                r = Math.Sin(x);
            }
            else if (-3.14 <= x && x < 0)
            {
                r = 3 * x;
            }
            else if (x < -2 * 3.14 || x > 2 * 3.14)
            {
                r = 2 * x;
            }
            else
            {
                r = 0;
            }

            Console.WriteLine($"При x = {x}, r = {r}");
        }
    }
}