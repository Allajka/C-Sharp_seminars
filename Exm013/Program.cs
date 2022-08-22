/* 1.Показать двумерный массив размером m×n заполненный целыми числами
2. Показать двумерный массив размером m×n заполненный вещественными числами
3. В двумерном массиве n×k заменить четные элементы на противоположные ( 4 , -4)
4. Задать двумерный массив следующим правилом: Aₘₙ = m+n
5. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
6. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
7. В матрице чисел найти сумму элементов главной диагонали*/

// В двумерном массиве n×k заменить четные элементы на противоположные

int[,] array = new int[3, 3];
void FillArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            array[row, col] = new Random().Next(-10, 10);
        }
    }
}

void change (int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (array[row, col] % 2 == 0)
            {
                array[row, col] = array[row, col];
                if (array[row, col] > 0)
                {
                    array[row, col] = -array[row, col];
                }
                if (array[row, col] < 0)
                {
                    array[row, col] = array[row, col];
                }
            }
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0), cols = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{array[row, col],3}");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
change(array);
Console.WriteLine();

PrintArray(array);