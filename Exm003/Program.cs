// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

int Monday = 1;
int Tuesday = 2;  
int Wednesday = 3; 
int Thursday = 4; 
int Friday = 5; 
int Saturday = 6;
int Sunday = 7; 

Console.WriteLine("Введите порядковый номер для недели от 1 до 7");
int myDay = Convert.ToInt32(Console.ReadLine()); 

if (myDay == Monday) Console.WriteLine("Monday");
if (myDay == Tuesday) Console.WriteLine("Tuesday");
if (myDay == Wednesday) Console.WriteLine("Wednesday");
if (myDay == Thursday) Console.WriteLine("Thursday");
if (myDay == Friday) Console.WriteLine("Friday");
if (myDay == Saturday) Console.WriteLine("Saturday");
if (myDay == Sunday) Console.WriteLine("Sunday");