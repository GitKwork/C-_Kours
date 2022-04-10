// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=N; i++)
{
    Console.WriteLine($"куб числа {i} = {i*i*i}");
}