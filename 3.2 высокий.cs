using System;

class Program
{
    static void Main(string[] args)
    {
        int minNumber = 100;
        int maxNumber = 9999;

        Console.WriteLine("Числа Армстронга из трех цифр:");
        for (int number = minNumber; number <= maxNumber; number++)
        {
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine(number);
            }
        }

        Console.WriteLine("Числа Армстронга из четырех цифр:");
        for (int number = minNumber; number <= maxNumber; number++)
        {
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsArmstrongNumber(int number)
    {
        int originalNumber = number;
        int digitsSum = 0;
        int totalDigits = GetTotalDigits(number);

        while (number != 0)
        {
            int digit = number % 10;
            digitsSum += (int)Math.Pow(digit, totalDigits);
            number /= 10;
        }

        return digitsSum == originalNumber;
    }

    static int GetTotalDigits(int number)
    {
        int totalDigits = 0;
        while (number != 0)
        {
            totalDigits++;
            number /= 10;
        }
        return totalDigits;
    }
}
