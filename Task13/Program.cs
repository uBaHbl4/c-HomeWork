using System;

public class Answer
{
    private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            throw new ArgumentException("Каждая точка должна иметь три координаты.");
        }

        double deltaX = pointA[0] - pointB[0];
        double deltaY = pointA[1] - pointB[1];
        double deltaZ = pointA[2] - pointB[2];

        double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

        return distance;
    }

    public static void Main(string[] args)
    {
        int x1, x2, y1, y2, z1, z2;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            y1 = int.Parse(args[2]);
            y2 = int.Parse(args[3]);
            z1 = int.Parse(args[4]);
            z2 = int.Parse(args[5]);
        }
        else
        {
            // Устанавливаем правильные координаты точек
            x1 = 7;
            x2 = 1;
            y1 = -5;
            y2 = -1;
            z1 = 0;
            z2 = 9;
        }

        // Вычислите расстояние между двумя точками в трехмерном пространстве и округлите результат до двух десятичных знаков
        double result = DistanceBetweenPoints(new int[] { x1, y1, z1 }, new int[] { x2, y2, z2 });
        Console.WriteLine($"{result:F2}");
    }
}
