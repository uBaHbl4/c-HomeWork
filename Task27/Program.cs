using System;

public class Answer
{
    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        return sum;
    }

    static public void Main(string[] args)
    {
        int number;

        if (args.Length >= 1)
        {
            number = int.Parse(args[0]);
        }
        else
        {
            // Измените значение number по мере необходимости
            number = 111;
        }

        int result = SumOfDigits(number);
        Console.WriteLine(result);
    }
}
