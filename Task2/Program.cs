// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
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

int[] Count(int[,] array)
{
    int[] num = new int[array.GetLength(1)];
    int[] count = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            num[j] = array[i, j];
            sum = sum + num[j];
        }
        count[i] = sum;
    }
    return count;
}

int Check(int[] count)
{
    int min = count[0];
    int check = 0;
    for (int i = 0; i < count.Length; i++)
    {
        if (min > count[i])
        {
            min = count[i];
            check = i + 1;
        }
    }
    return check;
}

Console.WriteLine("Введите количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
Console.WriteLine($"Сгенерирован массив из {array.GetLength(0)} строк и {array.GetLength(1)} столбцов:");
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов {Check(Count(array))} строка");
