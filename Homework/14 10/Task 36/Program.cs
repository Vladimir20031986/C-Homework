// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int OddSumNums(int[] numsarr)
{
    int sum = 0;
    for (int count = 1; count < numsarr.Length; count=count+2)
    {
        if (count % 2 > 0)
            sum += numsarr[count];
    }
    return sum;
}
Console.WriteLine("Введите размер массива: ");
int sizearr = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(sizearr, 0, 100);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {OddSumNums(array)}");