// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if ((b*b) == a || (a*a) == b)
{
    Console.WriteLine ("да, одно число является квадратом другого");
} 
else
{
    Console.WriteLine ("нет, одно число не является квадратом другого");
}
 // задача 1

 int n = new Random().Next(100, 1000);
System.Console.WriteLine(n);

int a = n / 100; 

int b = n % 10;

System.Console.WriteLine(a*10+b);

// задача 2

int n1 = 50, m1 = 5;
int n2 = 19, m2 = 4;

int a = n1 % m1;

if (a == 0) System.Console.Write("Кратно"); 
else System.Console.WriteLine("Не кратно, остаток: " + a);

System.Console.WriteLine();

int b = n2 % m2;

if (b == 0) System.Console.Write("Кратно"); 
else System.Console.WriteLine("Не кратно, остаток: " + b);

// задача 3

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int ost_1 = a % 7;
int ost_2 = a % 23;

if (ost_1 == 0 && ost_2 == 0) {
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");
