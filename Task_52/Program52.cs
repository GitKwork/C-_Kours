// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] matrix = new int[4, 5];
double[] matrix2 = new double[matrix.GetLength(1)];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] >= 0)
            {
                Console.Write($" {matr[i, j]}  \t");
            }
            else
            {
                Console.Write($"{matr[i, j]}  \t");
            }
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp = temp + matrix[i, j];
    }
    matrix2[j] = temp / matrix.GetLength(0);
}
Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:\t");
Console.WriteLine();
for (int j = 0; j < matrix2.GetLength(0); j++)
{
    Console.Write($"[№{j + 1}={matrix2[j]:f2}]\t");
}
Console.WriteLine();
Console.WriteLine();