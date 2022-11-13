// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Clear();
int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] array1 = new int[rows1, columns1];
FillArray(array1);
Console.WriteLine();
PrintArray(array1);

Console.WriteLine();

int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] array2 = new int[rows2, columns2];
FillArray(array2);
Console.WriteLine();
PrintArray(array2);

if (columns1 != rows2)
{
    Console.WriteLine();
    Console.WriteLine("Вычисление невозможно!.");
}
else
{
    int[,] resarray = new int[rows1, columns2];
    resarray = MultMatrix(array1, array2, resarray);

    Console.WriteLine();
    Console.WriteLine("Результирующая матрица: ");
    Console.WriteLine();
    PrintArray(resarray);
}


int ReadInt(string mess)
{
    Console.Write(mess);
    return int.Parse(Console.ReadLine());
}

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultMatrix(int[,] array1, int[,] array2, int[,] resarray)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resarray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resarray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resarray;
}