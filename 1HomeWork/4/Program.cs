/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

System.Console.WriteLine("Введите 1 число: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 2 число: ");
int num_2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите 3 число: ");
int num_3 = int.Parse(Console.ReadLine());
if (num_1 > num_2 && num_1 > num_3)
{
    System.Console.WriteLine($"Число {num_1} максимальное число");
}
else if (num_2 > num_1 && num_2 > num_3)
{
    System.Console.WriteLine($"Число {num_2} максимальное число");
}
else
{
    System.Console.WriteLine($"Число {num_3} максимальное число");
}