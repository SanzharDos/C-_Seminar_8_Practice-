// Задача 60. Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array, int n) // Не получилось придумать алгоритм для уникальности чисел
{
    // int count = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                // for (int m = 1; m < n; m++)
                // {
                //     for (int l = 0; l < count; l++)
                //     {
                //         while (array[i, j, l] == array[i, j, m])
                //         {
                //             array[i, j, l] = new Random().Next(10, 100);
                //             l = 0;
                //         }
                //     }
                // }
                // count++;
            }
        }
    }
}

void PrintArray(int[,,] array, int n)
{
    Console.WriteLine($"Массив размером {n} x {n} x {n}:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк, столбцов и порядковых номеров трехмерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[n, n, n];
FillArray(array, n);
PrintArray(array, n);
