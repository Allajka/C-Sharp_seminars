/* 1. Напишите метод, которая возвращает массив из N элементов, заполненный нулями и единицами в случайном порядке.
N = 3 => [1, 0, 0]
N = 8 => [1,0,1,1,0,1,0,0]
2. написать метод, который принимает на вход двоичное представление числа в виде массива ARR и выдаёт десятичное представление
ARR = [1, 0, 0] => 4
ARR = [1,0,1,1,0,1,0,0] => 180
3. написать метод, который принимает на вход десятичное представление числа N и показатель основания СС P, в которую нужно перевести это число
N = 31, P = 2 => 11111
N = 31, P = 8 => 37
ДОГОВОРИМСЯ, что  2<= p <= 9 */

int[] createArray(int N) 
{
    int[] Array = new int [N];
    for (int i = 0; i <= N - 1; i++)
    {
        Array[i] = new Random().Next(0,2);
    }
    return Array;
}

void printArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double transferNumbers (int[] arr)
{
    double result = 0;
    for (int i = 0; i < arr.Length; i++) // 
    {
        result += arr[i] * Math.Pow(2, (arr.Length - 1 - i));
    }
    return result;
}

int N = 3;
int[] numbers = createArray(N);
Console.Write("Массив: ");
printArray(numbers);
double newNumbers = transferNumbers(numbers);
Console.WriteLine($"Певевод в двоичную систему: {newNumbers}");

int numberN = 186;
int P = 2;

int size = 8;
int[] res = new int[size + 1];

while (numberN != 0)
{
    int o = numberN % P;
    numberN /= P;
    res[size] = o;
    size--;
}

printArray(res);