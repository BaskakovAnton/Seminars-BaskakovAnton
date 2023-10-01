// Напишите прогу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// System.Console.WriteLine($"Вводим число: ");
// int a = int.Parse(System.Console.ReadLine());

// int Sum(int limit)
// {
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");


// ________________________________________________________________________

// Создание массива заданной длины и заполнение его рандомными числами

// void Mass(int col)
// {
//     int[] arry = new int[col];
//     for (int i = 0; i < arry.Length; i++)
//     {
//         arry[i] = new Random().Next(0, 10);
//         System.Console.Write($"{arry[i]} ");
//     }
// }
// System.Console.WriteLine("Введите лину массива: ");
// int n = int.Parse(System.Console.ReadLine());
// Mass(n);

// ___________________________________________________________________________

// Прога, которая принимает на вход число и выдает кол-во цифр в чисел
// 456 -> 3
// 78 ->2
// 89126 -> 5
// int SumD(int arg)
// {
//     int digitCount = 0;

//     while (arg != 0)
//     {
//         arg /= 10; // Делаем число на одну цифру короче
//         digitCount++;
//     }
//     return digitCount;
// }

// System.Console.WriteLine("Введите число: ");
// int n = int.Parse(System.Console.ReadLine());
// int result = SumD(n);
// System.Console.WriteLine($"Кол-во цифр в числе {n} равно {result}");

// _____________________________________________________________________

// Напишите прогу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Mdig (int arg)
// {
//     int sum = 1;
//     for (int i = 1; i <= arg; i++)
//     {
//         sum *= i;
//     }
//     return sum;

// }

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int result = Mdig(N);
// System.Console.WriteLine(result);

// ___________________________________________________________________________


// Напиши прогу, которая выводит массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,0,1,0,0]


void Mass(int col)
{
    int[] arry = new int[col];
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(0, 2);
        System.Console.Write($"{arry[i]} ");
    }
}
System.Console.WriteLine("Введите лину массива: ");
int n = int.Parse(System.Console.ReadLine());
Mass(n);