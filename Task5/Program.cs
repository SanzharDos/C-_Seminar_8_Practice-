// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Функция для заполнения двумерного массива от 1 до n по порядку
// { 1, 2, 3 }
// { 4, 5, 6 }
// { 7, 8, 9 }
// void FillArray(int[,] array)
// {
//     array[0, 0] = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j + 1 < array.GetLength(1)) array[i, j + 1] = array[i, j] + 1;
//         }
//         if (i + 1 < array.GetLength(0)) array[i + 1, 0] = array[i, array.GetLength(0) - 1] + 1;
//     }
// }

void FillArray(int[,] array, int n)
{
    int count = 1;
    int start_col = 0;
    int end_col = n - 1;
    int start_row = 0;
    int end_row = n - 1;
    while (start_col <= end_col && start_row <= end_row)
    {
        for (int i = start_col; i <= end_col; i++)
        {
            array[start_row, i] = count;
            count++;
        }
        start_row++;
        for (int i = start_row; i <= end_row; i++)
        {
            array[i, end_col] = count;
            count++;
        }
        end_col--;
        for (int i = end_col; i >= start_col; i--)
        {
            array[end_row, i] = count;
            count++;
        }
        end_row--;
        for (int i = end_row; i >= start_row; i--)
        {
            array[i, start_col] = count;
            count++;
        }
        start_col++;
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

Console.WriteLine("Введите количество строк и столбцов правильного двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
FillArray(array, n);
Console.WriteLine($"Сгенерирован массив, заполненный по порядку спиралью:");
PrintArray(array);
