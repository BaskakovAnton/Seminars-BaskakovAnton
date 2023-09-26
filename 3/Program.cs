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
System.Console.WriteLine("Введите координату XA: ");
int XA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату YA: ");
int YA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату XB: ");
int XB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату YB: ");
int YB = int.Parse(Console.ReadLine());

double ras = Math.Sqrt(Math.Pow(XA - XB, 2) + Math.Pow(YA - YB, 2));
System.Console.WriteLine($"A({XA},{YA}); B({XB},{YB}) -> {ras}");

// double a1 = Math.Pow(XA - XB, 2);
// System.Console.WriteLine(a1);
// double a1 = Math.Pow(XA - XB, 2);
// System.Console.WriteLine(a1);