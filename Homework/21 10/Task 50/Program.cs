// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Clear();

Console.Write("Введите номер индекса строки элемента массива: ");
int a = GetElement();
Console.Write("Введите номер индекса столбца элемента массива: ");
int b = GetElement();
int rows = new Random().Next(5, 11);
int columns = new Random().Next(5, 11);
int[,] array = GetArray(rows, columns, 0, 100);
Console.WriteLine();
PrintArray(array);

if (a > array.GetLength(0) || b > array.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Значение указанного элемента массива: {array[a, b]}");
}

int GetElement()
{
    int x = int.Parse(Console.ReadLine());
    return x;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
