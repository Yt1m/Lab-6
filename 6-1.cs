    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите систему счисления (от 2 до 9)");
        int radix = int.Parse(Console.ReadLine());
        string convertedNumber = ConvertToRadix(number, radix);
        Console.WriteLine("Число 0 в 1 системе счисления 2", number, radix, convertedNumber);
        Console.ReadLine();
    }
    static string ConvertToRadix(int number, int radix)
    {
        if (number == 0)
        {
            return "0";
        }
        string result = string.Empty;
        while (number > 0)
        {
            int remainder = number % radix;
            result = remainder.ToString() + result;
            number /= radix;
        }
        return result;
    }