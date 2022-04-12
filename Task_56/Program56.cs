// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
int a = 4;
int b = 4;
int [,] array = new int [a,b];
void PrintArray(int[,] localArray)
{
    for (int k = 0; k <a ; k++)
    {
        for (int l = 0; l < b; l++)
        {
            Console.Write($"{array[k,l],4} ");
        }
        Console.WriteLine();
    }
}
void PrintRowArray(int[,] localArray, int number)
{
    int p = number -1;
    for (int l = 0; l <array.GetLength(1) ; l++)
    {
        Console.Write($"{array[p,l],4}");
    }
    Console.WriteLine();
}
for (int i = 0; i <a ; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i,j] = new Random().Next(0,10);
    }
}
PrintArray(array);
Console.WriteLine ();
int RowMaxSum(int[,] array)
{
    int Msum = 0;
    int nmb = 1;
    for (int j = 0; j < array.GetLength(1); j++)
        {
        Msum += array[0, j];
        }
    for (int i = 1; i < array.GetLength(0); i++)
        {
            int Sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Sum += array[i, j];
            }
            if ( Sum <  Msum) 
            {
                Msum = Sum;
                nmb = i + 1;
            }    
        }
                

    return nmb;
}
int str = RowMaxSum(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {str}\n");
PrintRowArray(array, str);
Console.WriteLine();