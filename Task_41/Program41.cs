
// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("\nВведите желаемое кол-во чисел, для завершения введите число '100':\n");
int [] mass = new int[1000];  
int ex = 100;
int tx = 0;
void printMass()
{
    Console.Write("\n[");
    for(int i=0; i < tx; i++)
    {
        Console.Write($"{mass[i]}, ");
    }
    Console.WriteLine($"{mass[tx]}]\n");
}
for (int i = 0; i < 100; i++) 
{
    mass[i] = Convert.ToInt32(Console.ReadLine());
    tx = i-1;
    if (mass[i] == ex)
    {  
    break;
    }   
}    
printMass();
int numbersPlus(int [] mass)
{
    int Np = 0;
    for(int i = 0; i<tx+1; i++)
    {
        if(mass[i] > 0)
        {
            Np++;
        }
    }
    return Np;
}
Console.WriteLine ($"Количество чисел больше '0' = {numbersPlus(mass)}.\n");