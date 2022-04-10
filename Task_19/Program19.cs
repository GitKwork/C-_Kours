// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число:");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberToSrting = Convert.ToString(Math.Abs(Number));
bool Polindrom = true;
for (int i = 0; i < 3; i++)
{
    if (NumberToSrting[i] != NumberToSrting[4 - i])
    {
        Polindrom = false;
        break;

    }
}
if (Polindrom)
{
    Console.WriteLine($"Число {Number} является полиндромом");
}
else
{
    Console.WriteLine($"Число {Number} не является полиндромом");
}