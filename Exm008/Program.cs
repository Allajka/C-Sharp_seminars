// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число, делитель");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, делимое");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number % number2 == 0)
{
    Console.WriteLine($"Число {number2} кратно {number}");
}
else 
{
    Console.WriteLine($"Числа не кратны, остаток {number % number2}");
}
