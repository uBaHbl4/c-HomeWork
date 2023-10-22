using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели (1-7): ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Да, это выходной день.");
        }
        else if (dayOfWeek >= 1 && dayOfWeek <= 5)
        {
            Console.WriteLine("Нет, это не выходной день.");
        }
        else
        {
            Console.WriteLine("Некорректный номер дня недели. Введите число от 1 до 7.");
        }
    }
}
