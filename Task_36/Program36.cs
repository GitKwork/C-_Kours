// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("\nВведите длину массива: ");
int Mlen = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int [] mass = new int[Mlen];
void init_array()
{
    Random rnd = new Random();
    for(int i=0; i<Mlen; i++)
    {
        mass[i]=rnd.Next(-99,100);
    }
}
void print_array()
{
    Console.Write("\n[");
    for(int i=0; i < Mlen-1; i++)
    {
        Console.Write($"{mass[i]}, ");
    }
    Console.WriteLine($"{mass[Mlen-1]}]\n");
}
int OddSum()
{
    int OddS=0;
    for(int i=1; i<Mlen; i=i+2)
    {
        OddS += mass[i];
    }
    return OddS;
}
init_array();
print_array();
Console.WriteLine($"В массиве сумма элементов, стоящих на нечётных позициях = {OddSum()}\n");

