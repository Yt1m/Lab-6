using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите код города (048 - Одесса, 044 - Киев, 046 - Харьков, 045 - Винница): ");
        string cityCode = Console.ReadLine();

        Console.Write("Введите длительность переговоров (в минутах): ");
        int duration = Convert.ToInt32(Console.ReadLine());

        double costPerMinute;

        switch (cityCode)
        {
            case "048":
                costPerMinute = 15;
                break;
            case "044":
                costPerMinute = 18;
                break;
            case "046":
                costPerMinute = 13;
                break;
            case "045":
                costPerMinute = 11;
                break;
            default:
                Console.WriteLine("Неверный код города");
                return;
        }

        double totalCost = duration * costPerMinute;
        Console.WriteLine("Стоимость переговоров: " + totalCost + " грн");
    }
}
