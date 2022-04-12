// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.
// Пример: 1 4 7 2 5 9 2 3 8 4 2 4 Вывод -> 1 4 7 2 5 81 2 9 8 4 2 4
int[,] matrix = new int[4, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] >= 0)
            {
                Console.Write($" {matr[i, j]} \t");
            }
            else
            {
                Console.Write($"{matr[i, j]} \t");
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
for (int i = 1; i <= matrix.GetLength(0); i += 2)
{
    for (int j = 1; j <= matrix.GetLength(1); j += 2)
    {
        matrix[i, j] *= matrix[i, j];
    }
}
PrintArray(matrix);