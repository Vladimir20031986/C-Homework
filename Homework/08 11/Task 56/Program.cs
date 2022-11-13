// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
Console.Write("Введите размер прямоугольного массива: ");
int rows = int.Parse(Console.ReadLine());
int columns = rows;
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Суммы элементов строк: ");
Console.WriteLine();
Summs(array);
Console.WriteLine();
int res = MinSummRowsEl(array);
Console.WriteLine();
Console.WriteLine($"Номер индекса строки с наименьшей суммой элементов:  {res}");


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Summs(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.Write(summ + "  ");
        summ = 0;
    }
}

int MinSummRowsEl(int[,] array)
{
    int res = 0;
    int minsumm = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minsumm += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summrows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summrows += array[i, j];
        }
        if (summrows < minsumm)
        {
            minsumm = summrows;
            res = i;
        }

    }
    return res;
}