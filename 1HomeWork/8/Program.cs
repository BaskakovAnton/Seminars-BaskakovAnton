﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 1;
while (i <= num)
{
    if (i % 2 == 0)
    {
        System.Console.Write($"{i}, ");
        i++;
    }
    else
    {
        i++;
    }   
}