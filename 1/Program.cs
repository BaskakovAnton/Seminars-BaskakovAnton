﻿using System.Diagnostics;
/* --------------------------------------------------------------
using System.Xml.Linq;
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine(a);
int sum = a * a;
System.Console.WriteLine($"Квадрат числа {a} равен = {sum}");
System.Console.WriteLine("Квадрат числа {0} равен = {1}", a, sum); */

/* ---------------------------------------------------------------
System.Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
if(num_1 == num_2 * num_2)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
} */


/* -----------------------------------------------------
System.Console.Write("Введите число дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.Write("Понедельник");
}
else if (num == 2)
{
    Console.Write("Вторник");
}
else if (num == 3)
{
    Console.Write("Среда");
}
else if (num == 4)
{
    Console.Write("Четверг");
}
else if (num == 5)
{
    Console.Write("Пятница");
}
else if (num == 6)
{
    Console.Write("Суббота");
}
else if (num == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("!Неверное число, введите число в диапозоне 1-7!");
} */



/* -----------------------------------------------------------------------
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i;

if (N > 0)
{
    i = -N;
    while (i <= N)
    {
        Console.Write("{0} ", i);
        i++;
    }
}
else if (N < 0)
{
    i = N;
    while (i <= -N)
    {
        Console.Write("{0} ", i);
        i++;
    }
}
else
{
    Console.Write("0"); // Выводим только 0, если N равно нулю.
}

Console.WriteLine(); // Переход на новую строку для читаемости вывода. */

/* Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");
}
else
{
    Console.WriteLine("Вы ввели число, которое не является трехзначным.");
} */
