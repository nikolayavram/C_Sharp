// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки: ");
System.Console.Write("X = ");
int.TryParse(Console.ReadLine(), out int x1);
System.Console.Write("Y = ");
int.TryParse(Console.ReadLine(), out int y1);
System.Console.Write("Z = ");
int.TryParse(Console.ReadLine(), out int z1);
Console.WriteLine("введите координаты второй точки: ");
System.Console.Write("X = ");
int.TryParse(Console.ReadLine(), out int x2);
System.Console.Write("Y = ");
int.TryParse(Console.ReadLine(), out int y2);
System.Console.Write("Z = ");
int.TryParse(Console.ReadLine(), out int z2);

int distance = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
Console.Write($"Дистанция = {distance}");
