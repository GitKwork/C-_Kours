// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
Console.WriteLine("\nВведите длину массива вещественных чисел: ");
int Mlen = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double [] mass = new double[Mlen];
void init_doubelarray()
{
    Random rnd = new Random();
    Random dblrnd = new Random();
    for(int i=0; i<Mlen; i++)
    {
        mass[i] = rnd.Next(0,1000) * dblrnd.NextDouble();
    }
}
void print_doubelarray()
{
    Console.Write("\n[");
    for(int i=0; i < Mlen-1; i++)
    {
        Console.Write($"{mass[i]:f4}, ");
    }
    Console.WriteLine($"{mass[Mlen-1]:f4}]\n");
}
double MinMaxSumMass()
{
    double MinS = mass[0];
    double MaxS = mass[0];
    double MinMaxS = 0;
    for(int i=1; i<Mlen; i++)
    {
        if (mass[i] < MinS)
        MinS = mass[i];
        else if (mass[i] > MaxS)
        MaxS = mass[i];
    }
        MinMaxS = MaxS - MinS;
    return MinMaxS;
}
init_doubelarray();
print_doubelarray();
Console.WriteLine($"В массиве разница между max&min элементом массива = {MinMaxSumMass():f4}\n");
