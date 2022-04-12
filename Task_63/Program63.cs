// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());

// void Natural(int a)
// {
//     if (a > 1)
//     {
//         Natural(a - 1);

//     }
//     Console.Write($" {a}");
// }
// Natural(N);

// Задача 65.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());

// void NaturalMN(int a, int b)
// {
//     if (b > a)
//     {
//         NaturalMN(a,b-1);

//     }
//     Console.Write($" {b}");
// }
// NaturalMN(M,N);

// Задача 67.Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Console.WriteLine("Введите число M");
// int M = Convert.ToInt32(Console.ReadLine());

// int Summ(int a)
// {

//     if (a == 0)
//     {
//         return 0;
//     }
//     else
//     {
//         return a % 10 + Summ(a / 10);
//     }
// }
// Console.Write($" {Summ(M)}");

// Задача 68.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 

// f(m,n)=n+1 при m=0
//       =f(m-1,1), при m>0, n=0
//       =f(m-1,f(m,n-1)), при m>0,n>0

Console.WriteLine("Введите число M");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int b = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write($" {Akkerman(a,b),4}");













