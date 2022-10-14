Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(SummNumbers(num));

int SummNumbers(int number)
{
    int res = 0;
    for(int count = 0; number > 0; count++ )
    {
        res += number%10;
        number = number/10;
    }
    return res;
}