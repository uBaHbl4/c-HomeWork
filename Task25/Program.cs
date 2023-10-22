using System;

public class Answer
{
    static long Power(int A, int B)
    {
        if (B == 0)
        {
            return 1;
        }

        long result = A;

        for (int i = 1; i < B; i++)
        {
            result *= A;
        }

        return result;
    }

    static public void Main(string[] args)
    {
        int A, B;

        if (args.Length >= 2)
        {
            A = int.Parse(args[0]);
            B = int.Parse(args[1]);
        }
        else
        {
            // Измените значения A и B по мере необходимости
            A = 3;
            B = 5;
        }

        long result = Power(A, B);
        Console.WriteLine(result);
    }
}
