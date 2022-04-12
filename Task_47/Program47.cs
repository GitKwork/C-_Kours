// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4. 0,5 7 -2 -0,2 1 -3,3 8 -9,9 8 7,8 -7,1 9

double [,] matrix = new double [3, 4];

void PrintArray (double [,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] >= 0)
            {
                Console.Write($" {matr[i, j]:f2} \t");
            }
            else
            {
                Console.Write($"{matr[i, j]:f2} \t");
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1 , 100) * new Random().NextDouble();
        }
    }
}

FillArray(matrix);
PrintArray(matrix);