// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


Console.WriteLine("Введите длину массива: ");
int Mlen = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] mass = new int[Mlen];
int index = 0;
int N = 0;
void MassiveEnenNumb(int[] array)
{
Console.Write("\n[");
    while(index < Mlen)
    {
        array[index] = new Random().Next(100, 1000);
        Console.Write($" {mass[index]}, ");
        index++;
    }
Console.WriteLine("]\n");
    for (int i = 0; i < Mlen; i++)
    {
        if(mass[i] % 2 == 0 )
        {
            N += 1;
        }
    }
    if(N > 0)
    {
        Console.WriteLine($"{N} четных чисел присутствует в массиве.\n");
    }
    else
    {
        Console.WriteLine($"Четные числа не присутствуют в массиве.\n");
    }
}
MassiveEnenNumb(mass);