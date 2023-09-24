// using System;   Цикл FOR
// for (int i = 0; i <= 5; i++)
// {
//     System.Console.Write($"{i}, "); 
// }

// System.Console.Write("\b\b ");

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10,100);
// int a1 = num /10;
// int a2 = num % 10;

// int max = a1;

// if(max <a2)
// {
//     max = a2;
// }

// System.Console.WriteLine($"Наибольшая цифра числа {num} -> {max} ");
//________________________________________________________________________
// Прога которая принимает на вход два числа и выводит кратно ли 2 число 1. Если не кратно выводит остаток от деления.

// System.Console.WriteLine("Введите первое число: ");
// int num_1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int num_2 = int.Parse(Console.ReadLine());
// if (num_2 % num_1 == 0)
// {
//     System.Console.WriteLine($"{num_2}, {num_1} - > кратно");
// }
// else if (num_2 % num_1 != 0)
// {
//     int ost = num_2 % num_1;
//     System.Console.WriteLine($"{num_2}, {num_1} - > не кратно, остаток {ost}");    
// }
//_____________________________________________________________
// Прога выводит случайное 3-х значное число и удаляет вторую цифру этого числа
// 456->46
// 782->72
// 918->98
// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(num);
// int num1 = num /100;
// int num3 = (num % 100) %10;
// System.Console.WriteLine(num3);
// System.Console.WriteLine(num1);
// System.Console.WriteLine($"{num}->{num1}{num3}");
//________________________________________________________________________
//Прога принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14->нет
// 46->нет
// 161->да
// System.Console.WriteLine("Введите первое число: ");
// int num = int.Parse(Console.ReadLine());
// if(num%7 == 0 && num%23 == 0)
// {
//     System.Console.WriteLine($"{num} -> да");
// }
// else
// {
//     System.Console.WriteLine($"{num} -> нет");
// }
//___________________________________________________________________________

// Прога принимает на вход 2 числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

System.Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
if (num_2 * num_2 == num_1 || num_1 * num_1 == num_2)
{
    System.Console.WriteLine($"{num_1}, {num_2} -> да");
}
else
{
    System.Console.WriteLine($"{num_1}, {num_2} -> нет");
}
