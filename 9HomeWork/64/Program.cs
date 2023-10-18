// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void PrintNaturalNumbers(int n)
    {
        if (n > 0)
        {
            Console.Write(n);
            if (n > 1)
            {
                Console.Write(", ");
            }
            PrintNaturalNumbers(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите натуральное число N: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.Write("Натуральные числа от N до 1: ");
            PrintNaturalNumbers(n);
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное натуральное число.");
        }
    }
}