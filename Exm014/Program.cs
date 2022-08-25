// // Вывод на экран цифр введенных с клавиатуры
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write(" ");
            else Console.Write("#");
        }
        Console.WriteLine();
    }
}

int[,] numbers =
{
    {0, 0, 0, 1, 1, 0,  0, 0, 0, 0, 1, 0,  0, 0, 1, 1, 0, 0,  0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,   0, 0, 1, 1, 0, 0,   0, 1, 1, 1, 1, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 0, 0  },
    {0, 0, 1, 0, 0, 1,  0, 0, 0, 1, 1, 0,  0, 1, 0, 0, 1, 0,  0, 1, 0, 0, 1, 0,  0, 0, 0, 1, 1, 0,  0, 1, 0, 0, 0, 0,   0, 1, 0, 0, 0, 0,   0, 0, 0, 1, 0, 0,   0, 1, 0, 0, 1, 0,   0, 1, 0, 0, 1, 0  },
    {0, 0, 1, 0, 0, 1,  0, 0, 1, 0, 1, 0,  0, 0, 0, 1, 0, 0,  0, 0, 0, 1, 0, 0,  0, 0, 1, 0, 1, 0,  0, 1, 1, 1, 0, 0,   0, 1, 1, 1, 0, 0,   0, 0, 1, 0, 0, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 1, 0  },
    {0, 0, 1, 0, 0, 1,  0, 0, 0, 0, 1, 0,  0, 0, 1, 0, 0, 0,  0, 1, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,  0, 0, 0, 0, 1, 0,   0, 1, 0, 0, 1, 0,   0, 1, 0, 0, 0, 0,   0, 1, 0, 0, 1, 0,   0, 0, 0, 0, 1, 0  },
    {0, 0, 0, 1, 1, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,  0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 0, 0,   0, 1, 1, 1, 0, 0,   0, 1, 0, 0, 0, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 0, 0  },
};

PrintImage(numbers);
Console.WriteLine($"строк: {numbers.GetLength(0)}");
Console.WriteLine($"столбцов: {numbers.GetLength(1)}");


int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == 2)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = numbers.GetLength(1) - 1 - (6*8); j < numbers.GetLength(1) - 1 - (6*7); j++)
        {
            if (numbers[i, j] == 0) Console.Write(" ");
            else Console.Write("#");
        }
        Console.WriteLine();
    }
}

if (userNumber == 3)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 17; j < 23; j++)
        {
            if (numbers[i, j] == 0) Console.Write(" ");
            else Console.Write("#");
        }
        Console.WriteLine();
    }
}
