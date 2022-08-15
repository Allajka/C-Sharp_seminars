// сумма членов арифметической прогресии
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] numbers = {2,6,8,9,5,4,1};
SelectionSort(numbers);
printArray(numbers);
