//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double Input(string msg)
{
    System.Console.Write(msg);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double k1 = Input("k1 = ");
double k2 = Input("k2 = ");
double b1 = Input("b1 = ");
double b2 = Input("b2 = ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
System.Console.WriteLine($"x = {x:F2}, y = {y:F2}");