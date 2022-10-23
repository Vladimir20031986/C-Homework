// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Ведите число: ");
        res[i] = int.Parse(Console.ReadLine());
    }
    
    return res;
}

int PosNums(int[] numsarr)
{
    int count = 0;
    
    for (int i = 0; i < numsarr.Length; i++)
    {
        if (numsarr[i] > 0 )
            count +=1;
        
    }
    return count; 
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Введенные числа: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("Укажите колличество вводимых ниже чисел: ");
int m = int.Parse(Console.ReadLine());
int[] array = GetArray(m, -100000, 100000);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Колличество положительных чисел, введенных пользователем: {PosNums(array)} ");