using System.Xml.Linq;
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine(a);
int sum = a * a;
System.Console.WriteLine($"Квадрат числа {a} равен = {sum}");
System.Console.WriteLine("Квадрат числа {0} равен = {1}", a, sum);

