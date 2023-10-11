using System;


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел M:");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            if (m <= 0)
            {
                Console.WriteLine("Количество чисел должно быть положительным.");
                return;
            }

            int[] numbers = new int[m];
            int count = 0;

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    numbers[i] = number;
                    if (number > 0)
                    {
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                    i--; // Повторить ввод для того же числа
                }
            }

            Console.WriteLine($"Количество чисел больше 0: {count}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите положительное целое число M.");
        }
    }
}

