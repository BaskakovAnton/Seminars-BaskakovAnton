// using System;

// class Program
// {
//     static void PrintNaturalNumbers(int n)
//     {
//         if (n > 0)
//         {
//             Console.Write(n);
//             if (n > 1)
//             {
//                 Console.Write(", ");
//             }
//             PrintNaturalNumbers(n - 1);
//         }
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите натуральное число N: ");
//         if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
//         {
//             Console.Write("Натуральные числа от N до 1: ");
//             PrintNaturalNumbers(n);
//         }
//         else
//         {
//             Console.WriteLine("Пожалуйста, введите корректное натуральное число.");
//         }
//     }
// // }

// ____________________________________________________________________2



// using System;

// class Program
// {
//     static int SumNaturalNumbersInRange(int m, int n)
//     {
//         int sum = 0;
//         for (int i = m; i <= n; i++)
//         {
//             sum += i;
//         }
//         return sum;
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение M: ");
//         if (int.TryParse(Console.ReadLine(), out int m))
//         {
//             Console.Write("Введите значение N: ");
//             if (int.TryParse(Console.ReadLine(), out int n))
//             {
//                 if (m <= n && m > 0 && n > 0)
//                 {
//                     int result = SumNaturalNumbersInRange(m, n);
//                     Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {result}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Пожалуйста, введите корректные значения M и N (M <= N и оба числа должны быть натуральными).");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Пожалуйста, введите корректное значение N.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Пожалуйста, введите корректное значение M.");
//         }
//     }
// }



//____________________________________________________________________________3

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = Ackermann(m, n);
                Console.WriteLine($"A({m}, {n}) = {result}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное значение n.");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное значение m.");
        }
    }
}
