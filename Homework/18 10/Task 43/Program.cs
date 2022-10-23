// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Введите параметр k1 прямой y = k1*x + b1: ");
double c1 = GetLine();
Console.WriteLine("Введите параметр b1 прямой y = k1*x + b1: ");
double d1 = GetLine();
Console.WriteLine("Введите параметр k2 прямой y = k2*x + b2: ");
double c2 = GetLine();
Console.WriteLine("Введите параметр b2 прямой y = k2*x + b2: ");
double d2 = GetLine();
if (c1 == c2)
        Console.WriteLine("Прямые не пересекаются ");
else
    PrintPoint();


double GetLine()
{
    double k1 = Convert.ToDouble(Console.ReadLine());
    return k1;
}

(double,double) GetPoint(double m3, double n3, double m4, double n4)
{
    double y = 0;
    double x1 = 0;
    x1 += (n4 - n3) / (m3 - m4);
    y += (m3 * x1) + n3;
    var result= (x1,y);
    return result;
}

void PrintPoint()
{
    Console.Write($"Координаты точки пересечения заданных прямых {GetPoint(c1, d1, c2, d2)}  ");
}