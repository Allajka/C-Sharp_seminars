// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int val = new Random().Next(10, 99);
int diw = val / 10;
int mod = val % 10;

Console.WriteLine($"Рандомное число {val}");
Console.WriteLine($"val / 10 = {diw}");
Console.WriteLine($"val % 10 = {mod}");

if (diw > mod)
{
    Console.WriteLine($"Наибольшее число {diw}");
}
else
{
    Console.WriteLine($"Наибольшее число {mod}");
}