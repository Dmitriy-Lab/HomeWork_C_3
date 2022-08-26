// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите х1:");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1:");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2:");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2:");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2:");
int zb = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(xb - xa, 2)  + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine(S);