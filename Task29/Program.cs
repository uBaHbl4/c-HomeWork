using System;

public class Answer
{
    static public void Main(string[] args)
    {
        int[] array = new int[8]; // Создаем массив из 8 элементов

        if (args.Length >= 8)
        {
            for (int i = 0; i < 8; i++)
            {
                array[i] = int.Parse(args[i]); // Заполняем массив значениями из аргументов командной строки
            }
        }
        else
        {
            // Измените значения по мере необходимости
            array = new int[] { 1, 2, 5, 7, 19, 6, 1, 33 };
        }

        // Выводим массив на экран
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
