using System;

public class Date
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Date(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day}.{Month}.{Year}";
    }
}

public class Medicine : Date
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    public Medicine(string name, int day, int month, int year, string manufacturer) : base(day, month, year)
    {
        Name = name;
        Manufacturer = manufacturer;
    }

    public int DaysSinceManufacture()
    {
        DateTime now = DateTime.Now;
        DateTime manufactureDate = new DateTime(Year, Month, Day);
        TimeSpan timeSpan = now - manufactureDate;
        return timeSpan.Days;
    }

    public override string ToString()
    {
        return $"Medicine: {Name}\nManufacture Date: {base.ToString()}\nManufacturer: {Manufacturer}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Medicine medicine = new Medicine("Aspirin", 1, 1, 2020, "Bayer");
        Console.WriteLine(medicine.ToString());
        Console.WriteLine($"Days since manufacture: {medicine.DaysSinceManufacture()}");
    }
}