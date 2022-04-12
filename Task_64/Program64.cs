
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N в обратном порядке. M = 1; N = 5. -> «5, 4, 3, 2, 1»

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void NaturalMN(int a, int b)
{
    if (b > a)
    {
        NaturalMN(a+1,b);

    }
    Console.Write($" {a}");
}
NaturalMN(M,N);