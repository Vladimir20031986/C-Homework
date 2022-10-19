// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Console.WriteLine("Массив:");
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int DiffMaxMin(int[] numsarr)
{
    int max = numsarr[0];
    int min = numsarr[0];
    int dif = 0;
    
    for (int i = 0; i < numsarr.Length; i = i + 1)
    {
        if (numsarr[i] < min)
            min = numsarr[i];
        else 
        if (numsarr[i] > max)
            max = numsarr[i];
    }
    dif = max - min;
    return dif; 
}

Console.WriteLine("Введите размер массива: ");
int sizearr = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(sizearr, 0, 100);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DiffMaxMin(array)}");