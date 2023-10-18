// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

class Program
{
    static int SumNaturalNumbersInRange(int m, int n)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (m <= n && m > 0 && n > 0)
                {
                    int result = SumNaturalNumbersInRange(m, n);
                    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {result}");
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректные значения M и N (M <= N и оба числа должны быть натуральными).");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное значение N.");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное значение M.");
        }
    }
}