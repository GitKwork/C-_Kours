// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int Result = 1;
for (int i = 1; i <=B; i++)
{
    Result = Result * A;
}
Console.WriteLine(Result);