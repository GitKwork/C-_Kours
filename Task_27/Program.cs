// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int SUMn = 0;
int b = 0;
int count = 0;
while (a != 0)
{
   b = a % 10;
   SUMn = SUMn + b;
   a = a / 10;
       count++;
}
Console.WriteLine(SUMn);
