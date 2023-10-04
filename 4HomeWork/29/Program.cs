// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void Mass(int col)
{
    int[] arry = new int[col];
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(0, 2);
        System.Console.Write($"{arry[i]} ");
    }
}
System.Console.WriteLine("Введите длину массива: ");
int n = int.Parse(System.Console.ReadLine());
Mass(n);