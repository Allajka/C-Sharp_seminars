/* Задача 100: 10000<N<30000. нужно получить разбиение всех чисел от 2 до N на простые множители
Другими словами, n > 1 – простое, если при его делении на любое число кроме 1 и n есть остаток.

*/
bool IsSimple(int number)
{
    if (number <= 1) return false;
    for (int j = 2; j <= Math.Sqrt(number); j++)
    {
        if (number % j == 0)
        {
            return false;
        }
    }
    return true;
}

void CreateSimple(int lastNumber, int[] arr)
{
    int count = 1;
    for (int i = 3; i < lastNumber; i += 2)
    {
        if (IsSimple(i))
        {
            arr[count] = i;
            count++;
        }
    }
}

void ReturnSimpleList(int number, int[] arraySimpleNumber)
{
    string result = $"{number} = 1 ";
    int i = 0;
    while (i < number)
    {
        if (number % arraySimpleNumber[i] == 0)  // 4% 0 ==0 || 2%
        {
            number /= arraySimpleNumber[i]; // number = 2
            result = result + $"* {arraySimpleNumber[i]} "; // result * 2
            i = 0;
        }
        else i++;
    }
    Console.WriteLine($"{result}");
}

DateTime start = DateTime.Now;
int lastNumber = 30000; // до какого числа смотрим
int[] arraySimpleNumber = new int[lastNumber / 8];
arraySimpleNumber[0] = 2;
CreateSimple(lastNumber, arraySimpleNumber);

for (int i = 2; i < lastNumber; i++)
{
    ReturnSimpleList(i, arraySimpleNumber);
}
DateTime end = DateTime.Now;
Console.WriteLine($"end - start: {end - start}");
