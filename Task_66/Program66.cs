// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. M = 1; N = 15 -> 120 M = 4; N = 8. -> 30
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int NaturalMN(int a, int b)
{
    if (b >= a)
    {
        sum =a + NaturalMN(a+1,b);
    }
    return sum;
}
Console.Write($" {NaturalMN(M,N)}");