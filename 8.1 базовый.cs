class Program
{
    static void Main()
    {
        Console.WriteLine("Введите время в формате HH:mm:ss:");
        DateTime time = DateTime.Parse(Console.ReadLine());
        string formattedTime = time.ToString("hh:mm:ss tt");
        Console.WriteLine("Время в 12-часовом формате: " + formattedTime);
    }
}
class Programs
{
    static void Main()
    {
        DateTime launchDateTime = new DateTime(2023, 5, 15, 12, 0, 0);
        DateTime currentDateTime = DateTime.Now;
        TimeSpan timeUntilLaunch = launchDateTime - currentDateTime;
        Console.WriteLine("Время до старта:");
        Console.WriteLine("Полных месяцев: " + timeUntilLaunch.Days / 30);
        Console.WriteLine("Дней: " + timeUntilLaunch.Days % 30);
        Console.WriteLine("Часов: " + timeUntilLaunch.Hours);
        Console.WriteLine("Минут: " + timeUntilLaunch.Minutes);
        Console.WriteLine("Секунд: " + timeUntilLaunch.Seconds);
    }
}