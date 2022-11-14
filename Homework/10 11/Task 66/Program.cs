// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine("Задайте значение M: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте значение N: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N:   {Summnums(num1, num2)}");


int Summnums(int num1, int num2)
{
    if (num1 >= num2) return num1;  
    return num1 += Summnums(num1 + 1, num2);
}
    