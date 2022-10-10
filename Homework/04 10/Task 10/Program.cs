Console.Clear();
Console.Write("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number <100)
{
    Console.WriteLine("Введено некорректное значение!");
}
else 
{
int a = (number%100 - number%10)/10;
Console.WriteLine();
Console.WriteLine(a);
}