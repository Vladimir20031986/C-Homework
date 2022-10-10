Console.Clear();
Console.Write("Введите любое пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99999 || num <10000)
{
    Console.WriteLine("Введено некорректное значение!");
}
else
{
    if (num/10000 == num%10 && num/1000 - ((num/10000)*10) == (num%100)/10)
    {
        Console.WriteLine("Введенное число является полиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является полиндромом");
    }
}