// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
const int coefficient = 0;
const int constant = 1;
const int x = 0;
const int y = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLine(line1);
double[] lineData2 = InputLine(line2);


double[] coord = FindCoords(lineData1, lineData2);
Console.Write($"Точка пересечения уравнений y = {lineData1[coefficient]} * x + {lineData1[constant]} и y = {lineData2[coefficient]} * x + {lineData2[constant]}");
Console.WriteLine($" имеет координаты ({coord[x]}, {coord[y]})");



double Prompt(string text)
{
    Console.Write(text);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

double[] InputLine(int straight)
{
    double[] line = new double[2];
    line[coefficient] = Prompt($"Введите коэффициент для {straight} прямой: ");
    line[constant] = Prompt($"Введите константу для {straight} прямой: ");
    return line;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x] = (lineData2[constant] - lineData1[constant]) / (lineData1[coefficient] - lineData2[coefficient]);
    coord[y] = lineData1[coefficient] * coord[x] + lineData1[constant];
    return coord;
}
