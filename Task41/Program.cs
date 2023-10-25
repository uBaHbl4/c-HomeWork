using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите числа, разделенные запятыми: ");
        string input = Console.ReadLine();
        
        // Разбиваем строку на массив строк с помощью запятых
        string[] inputNumbers = input.Split(',');

        int countPositiveNumbers = 0;

        foreach (string numberString in inputNumbers)
        {
            if (int.TryParse(numberString, out int number))
            {
                if (number > 0)
                {
                    countPositiveNumbers++;
                }
            }
            else
            {
                Console.WriteLine($"Ошибка: '{numberString}' не является целым числом.");
            }
        }

        Console.WriteLine($"Количество положительных чисел: {countPositiveNumbers}");
    }
}
