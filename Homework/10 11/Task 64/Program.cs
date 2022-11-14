// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"


Console.Clear();
int newnumber = 2;
Console.WriteLine("Задайте значение N: ");
int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    WriteNums(num, newnumber);
    else
        WriteNums(num - 1, newnumber);



void WriteNums(int num, int newnumber)
{
    Console.Write(num + " ");
    if (newnumber < num) 
    WriteNums(num - 2, newnumber);
}