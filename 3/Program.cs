using System.IO;
using System;
using System.Text.RegularExpressions;
// // Напишите прогу, которая принимает на вход координаты точки (X и Y), 
// //причем X != 0 Y!= 0 и 
// //выдает номер четверти плоскости, в которой находится эта точка.

// System.Console.WriteLine("Введите число X: ");
// int x = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число Y: ");
// int y = int.Parse(Console.ReadLine());

// if(x>0 && y>0)
// {
//     System.Console.WriteLine("1");
// }
// else if(x<0 && y>0)
// {
//     System.Console.WriteLine("2");
// }
// else if(x<0 && y<0)
// {
//     System.Console.WriteLine("3");
// }
// else if(x>0 && y<0)
// {
//     System.Console.WriteLine("3");
// }
// else
// {
//     System.Console.WriteLine("Вы ввели ноль");
// }


// Прога, которая по номеру четверти, показывает диапазон возможных координат.

// System.Console.WriteLine("Введите номер четверти: ");
// int num = int.Parse(Console.ReadLine());

// if(num == 1)
// {
//     System.Console.WriteLine("x>0 && y>0");
// }
// else if(num == 2)
// {
//     System.Console.WriteLine("x<0 && y>0");
// }
// else if(num == 3)
// {
//     System.Console.WriteLine("x<0 && y<0");
// }
// else if(num == 4)
// {
//     System.Console.WriteLine("x>0 && y<0");
// }
// else
// {
//     System.Console.WriteLine("Неверный номер четверти, введите в диапазоне от 1 до 4");
// }


// Прога, которая принимает на вход координаты 2 точек и находит расстояние между ними в 2Д пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



System.Console.WriteLine("Введите координату XA: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату YA: ");
int x2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату ZA: ");
int x3 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату XB: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату YB: ");
int y2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату ZB: ");
int y3 = int.Parse(Console.ReadLine());

double ras = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2));
string rasf = ras.ToString("N2");
System.Console.WriteLine($"A({x1},{x2},{x3}); B({y1},{y2},{y3}) -> {rasf}");

// // Прога, которая принимает на вход число (N) и 
// // выдает таблицу квадратов чисел от 1 до N
// // 5 -> 1, 4, 9, 16, 25
// // 2 -> 1, 4

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)}, ");
// }

