using System;

namespace DateClassExample
{
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 2000;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        ~Date()
        {
            Console.WriteLine($"Объект с датой {day}.{month}.{year} уничтожен");
        }

        public void ProcessData1()
        {
            if (day == month)
            {
                Console.WriteLine("Номер месяца и число дня совпадают");
            }
            else
            {
                Console.WriteLine("Номер месяца и число дня не совпадают");
            }
        }

        public void ProcessData2()
        {
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
            Console.WriteLine($"Дата увеличена на один месяц: {day}.{month}.{year}");
        }

        public string GetInfo()
        {
            return $"Дата: {day}.{month}.{year}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            Console.WriteLine(date1.GetInfo());
            date1.ProcessData1();
            date1.ProcessData2();

            Console.WriteLine();

            Console.WriteLine("Введите день:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            Date date2 = new Date(day, month, year);
            Console.WriteLine(date2.GetInfo());
            date2.ProcessData1();
            date2.ProcessData2();

            Console.ReadLine();
        }
    }
}
