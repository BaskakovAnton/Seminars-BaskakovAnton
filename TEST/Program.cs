System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int n1 = number % 10;
int n2 = number / 10 % 10;
int n3 = number / 100 % 10;
int n4 = number / 1000 % 10;
int n5 = number / 10000 % 10;
System.Console.WriteLine(n1);
System.Console.WriteLine(n2);
System.Console.WriteLine(n3);
System.Console.WriteLine(n4);
System.Console.WriteLine(n5);
if (n1 == n5 && n2 == n4)
    return true;
else if(n1 != n5 || n2 != n4)
    return false;