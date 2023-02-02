// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите x-координат первой точки: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите y-координат первой точки: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Введите x-координат второй точки: ");
int X2 = int.Parse(Console.ReadLine());
Console.Write("Введите y-координат второй точки: ");
int Y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

Console.WriteLine(result);