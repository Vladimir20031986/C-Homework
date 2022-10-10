Console.Clear();
Console.Write("Введите любую цифру от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number > 7 || number <1)
{
    Console.WriteLine("Введено некорректное значение!");
}
else 
{
    if (number > 0 & number < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}