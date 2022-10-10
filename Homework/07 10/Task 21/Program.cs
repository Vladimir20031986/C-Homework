Console.Clear();

Console.Write("Введите координату х точки А: ");
double x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату у точки А: ");
double y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату z точки А: ");
double z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату х точки B: ");
double x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату y точки B: ");
double y2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату z точки B: ");
double z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine("Расстояние между двумя точками в трехмерном пространстве равно:" + Math.Round(result, 2));
