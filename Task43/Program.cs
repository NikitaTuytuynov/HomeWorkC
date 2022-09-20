// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.Write("Ведите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double FindX(double b10, double k10, double b20, double k20)
{
    double x1 = Math.Round((-b20 + b10) / (-k10 + k20), 2);
    return x1;
}
double FindY(double k10, double b10, double x1)
{
    double y1 = Math.Round(((k10 * x1) + b10), 2);
    return y1;
}

double x = FindX(b1, k1, b2, k2);
double y = FindY(k1,b1,x);
Console.Write($"Точка перечечения Х:{x}, Точка перечечения Y:{y} ");