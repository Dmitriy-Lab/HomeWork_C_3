// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-значное число: ");
string number = Console.ReadLine();
char[] array = number.ToArray();

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Является палиндромом");
}
else
{
   Console.WriteLine("Не является палиндромом"); 
}