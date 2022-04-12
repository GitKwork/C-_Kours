// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива(в пределах всего массива).
int a = 5;
int b = 5;
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
for (int i = 0; i <a ; i++)
{
    for (int j = 0; j < b; j++)
    {
        array[i,j] = new Random().Next(-9,10);
    }
}
PrintArray(array);
Console.WriteLine("\nЭлементы каждой строки упорядочены по убыванию\n");
int[,] RowMaxMin(int[,] array)
{
int nmb = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            nmb = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, nmb]) 
                nmb = k;
            }
            int value = array[i, j];
            array[i, j] = array[i, nmb];
            array[i, nmb] = value;
        }
    }
    return array;
}
RowMaxMin(array);
PrintArray(array);
Console.WriteLine();