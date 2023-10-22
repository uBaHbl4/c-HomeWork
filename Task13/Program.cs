using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100 && number <= 999)
        {
            int thirdDigit = (number) % 10;
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }
}
