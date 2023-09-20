/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

System.Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
if (num_1 > num_2)
{
    System.Console.WriteLine($"Первое число: {num_1} больше второго: {num_2}");
}
else if (num_2 > num_1)
{
    System.Console.WriteLine($"Второе число: {num_2} больше первого: {num_1}");
}
else
{
    System.Console.WriteLine("Числа равны.");
}