Console.Clear();
Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;
while (count <= num)
{
    Console.Write(Math.Pow((count),3) + " ");
    count++;
}
