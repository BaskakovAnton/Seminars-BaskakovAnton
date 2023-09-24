// using System;   Цикл FOR
// for (int i = 0; i <= 5; i++)
// {
//     System.Console.Write($"{i}, "); 
// }

// System.Console.Write("\b\b ");

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10,100);
int a1 = num /10;
int a2 = num % 10;

int max = a1;

if(max <a2)
{
    max = a2;
}

System.Console.WriteLine($"Наибольшая цифра числа {num} -> {max} ");
