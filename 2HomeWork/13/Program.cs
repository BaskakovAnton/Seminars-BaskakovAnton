// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int GetThirdLeftDigit(int number)
{
    int num = Math.Abs(number); // Преобразуем в положительное значение

    if (num < 100)
    {
        return -1;
    }
    else if (num > 999)
    {
        while (num > 999)
        {
            num /= 10;
        }
        int num3 = num % 10;
        return num3;
    }
    else
    {
        int num3 = (num % 100) % 10;
        return num3;
    }
}
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int thirdLeftDigit = GetThirdLeftDigit(num);
if (thirdLeftDigit != -1)
{
    Console.WriteLine($"Третья цифра слева: {thirdLeftDigit}");
}
else
{
    Console.WriteLine("Третьей цифры слева нет.");
}




