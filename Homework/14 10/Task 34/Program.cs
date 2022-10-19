// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

int GetEvenNums(int[] numsarr)
{
    int num = 0;
    foreach (int el in numsarr)
    {
        if (el % 2 == 0)
            num += 1;
    }
    return num;
}
Console.WriteLine("Введите размер массива: ");
int sizearr = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(sizearr, 100, 1000);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {GetEvenNums(array)}");