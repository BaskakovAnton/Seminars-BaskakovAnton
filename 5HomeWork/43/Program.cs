// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите значения k1, b1, k2, b2 (через пробел):");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 4)
        {
            Console.WriteLine("Неверное количество аргументов. Введите k1, b1, k2, b2.");
            return;
        }

        if (double.TryParse(input[0], out double k1) && double.TryParse(input[1], out double b1) &&
            double.TryParse(input[2], out double k2) && double.TryParse(input[3], out double b2))
        {
            if (k1 == k2)
            {
                Console.WriteLine("Прямые параллельны и не пересекаются.");
            }
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                double y = k1 * x + b1;
                Console.WriteLine($"Точка пересечения: ({x:f1}; {y:f1})");
            }
        }
        else
        {
            Console.WriteLine("Некорректные значения. Введите числа.");
        }
    }
}
