Console.Clear();
Console.Write("Введите любое целое число: ");
int number = int.Parse(Console.ReadLine());
int a = 0;
if (number < 100)
{
    Console.WriteLine("Третьей цифры в числе нет");
    return;
}
else if (number > 100)
{
    while(number > 1000)
    {
        number = number/10;
    }
    a = number % 10;
}
Console.WriteLine("Третья цифра заданного числа - " + " " + a);