using System.Collections.Generic;

class HeatingSystem
{
    public string Settlement { get; set; }
    public int BoilerRoomNumber { get; set; }
    public int NumberOfHeatedObjects { get; set; }
    public DateTime StartDate { get; set; }
    public int InitialTemperature { get; set; }
    public DateTime EndDate { get; set; }
}

class Program
{
    static void Main()
    {
        List systems = new List
{
new HeatingSystem { Settlement = "Населенный пункт1", BoilerRoomNumber = 1, NumberOfHeatedObjects = 10, StartDate = new DateTime(2023, 09, 01), InitialTemperature = 15, EndDate = new DateTime(2024, 04, 30) },
new HeatingSystem { Settlement = "Населенный пункт2", BoilerRoomNumber = 2, NumberOfHeatedObjects = 8, StartDate = new DateTime(2023, 10, 01), InitialTemperature = 12, EndDate = new DateTime(2024, 05, 10) },
new HeatingSystem { Settlement = "Населенный пункт3", BoilerRoomNumber = 3, NumberOfHeatedObjects = 15, StartDate = new DateTime(2023, 10, 20), InitialTemperature = 10, EndDate = new DateTime(2024, 05, 15) }
};

        // Вывести сведения по всем котельным с указанием длительности отопительного сезона в днях
        Console.WriteLine("Сведения по всем котельным с указанием длительности отопительного сезона в днях:");
        foreach (HeatingSystem system in systems)
        {
            int heatingDays = (system.EndDate - system.StartDate).Days;
            Console.WriteLine($"Котельня {system.BoilerRoomNumber}: длительность сезона - {heatingDays} дней");
        }

        // Вывести сведения по всем котельным, начавшим отопительный сезон после 15 октября
        Console.WriteLine("\nСведения по всем котельным, начавшим отопительный сезон после 15 октября:");
        foreach (HeatingSystem system in systems)
        {
            if (system.StartDate.Month > 10 || (system.StartDate.Month == 10 && system.StartDate.Day > 15))
            {
                Console.WriteLine($"Котельня {system.BoilerRoomNumber}: начало сезона - {system.StartDate}");
            }
        }
    }
}