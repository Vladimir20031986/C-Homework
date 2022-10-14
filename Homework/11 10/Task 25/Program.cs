Console.Clear();
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Результат возведения числа А в степень В равен: " + ExponNums(a,b));

int ExponNums(int num1, int num2)
{
    int res = 1;
    for(int count = 0; count < num2; count++)
    {
        res *= num1;
    }
    return res;
}