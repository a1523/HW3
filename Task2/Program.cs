// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance3D = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    return distance3D;
}

Console.Write("Введите координаты X для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты X для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: {result}");
