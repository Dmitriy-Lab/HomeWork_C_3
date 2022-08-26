// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

Console.WriteLine(" ");

while (index <= N)
{
    double sq = Math.Pow(index, 3);
    Console.WriteLine(sq);
    index++;
}