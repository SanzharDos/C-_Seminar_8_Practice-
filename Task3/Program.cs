// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.Write("}");
        Console.WriteLine();
    }
}

int[,] NewArray(int[,] array1, int[,] array2)
{
    int[,] new_array = new int[array1.GetLength(1), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        int sum = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                int count = 0;
                count = array1[i, j] * array2[j, k];
                sum = sum + count;
            }
            new_array[i, k] = sum;
            sum = 0;
        }
    }
    return new_array;
}


Console.WriteLine("Введите количество столбцов первого массива и количество строк второго массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк первого массива:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива:");
int l = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[n, m];
FillArray(array1);
Console.WriteLine($"Сгенерирован первый массив из {n} строк и {m} столбцов:");
PrintArray(array1);
int[,] array2 = new int[m, l];
FillArray(array2);
Console.WriteLine($"И сгенерирован второй массив из {m} строк и {l} столбцов:");
PrintArray(array2);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(NewArray(array1, array2));

// Задача решена, но не полностью. Решение выдается, только в случае если количество строк и столбцов одинаково, что в первой матрице, что и во второй. 
// Не могу никак придумать алгоритм для решения произведения матриц с разными длинами.