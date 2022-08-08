// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numberRandom = new Random().Next(100, 1000);
int firstDigit = numberRandom / 100;
int secondDigit = (numberRandom / 10) % 10;
int thirdDigit = numberRandom % 10;
int newNumber = (firstDigit*10) + thirdDigit;

Console.WriteLine($"Случайное число: {numberRandom},\nБез цифры в середине: {newNumber}");

//int n = new Random().Next(100, 1000);
//System.Console.WriteLine(n);

//int a = n / 100; 
//int b = n % 10;

//System.Console.WriteLine(a*10+b);