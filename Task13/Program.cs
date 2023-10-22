using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        string numberStr = number.ToString();

        if (numberStr.Length >= 3)
        {
            char thirdDigit = numberStr[2];
            Console.WriteLine("Третья цифра: " + thirdDigit);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
    }
}
