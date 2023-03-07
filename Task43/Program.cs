// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double k1 = Prompt("Введите значение k1: ");
double b1 = Prompt("Введите значение b1: ");
double k2 = Prompt("Введите значение k2: ");
double b2 = Prompt("Введите значение b2: ");
double x = GetPointIntersectionX(k1, b1, k2, b2);
double y = GetPointIntersectionY(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");


double Prompt(string text)
{
    Console.Write(text);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double GetPointIntersectionX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double GetPointIntersectionY(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return y;
}