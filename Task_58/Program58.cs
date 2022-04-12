// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
int[,] arrey1 = new int[3,3] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
int[,] arrey2 = new int[3,3] {{9, 8, 7}, {6, 5, 4}, {3, 2, 1}};
int[,] arrey3 = new int[arrey1.GetLength(0), arrey2.GetLength(1)];
void PrintArray(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {   
        for (int j = 0 ; j < arrey.GetLength(1)  ; j++)
        {
            Console.Write($"{arrey[i,j],4}");
        }
        Console.WriteLine();
    }
}
int[,] MultiplyArray(int[,] arrey1, int[,] arrey2)
{
    int[,] arrey3 = new int[arrey1.GetLength(0), arrey2.GetLength(1)];
    for (int i = 0; i < arrey1.GetLength(0); i++)
    {
        for (int j = 0; j < arrey2.GetLength(1); j++)
        {
            for (int k = 0; k < arrey1.GetLength(1); k++)
            {
            arrey3[i, j] = arrey3[i, j] + arrey1[i, k] * arrey2[k, j];
            }
        }
    }
    return arrey3;
}
PrintArray(arrey1);
Console.WriteLine();
PrintArray(arrey2);
Console.WriteLine();
arrey3 = MultiplyArray (arrey1, arrey2);
Console.WriteLine("Произведение 2-х матриц:");
PrintArray(arrey3);
Console.WriteLine();