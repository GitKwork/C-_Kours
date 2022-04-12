// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования (программа копирования массива) 

// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
// }

// int[] mass = { 1, -3, 56, 21, 11 };

// PrintArray(mass);

// int[] massCopy = new int[mass.Length];

// for (int i = 0; i < mass.Length; i++)
// {
//     massCopy[i] = mass[i];
// }

// Console.WriteLine();
// Console.WriteLine();
// PrintArray(massCopy);

// Задача 45+: В матрице чисел найти сумму элементов главной диагонали.

// int[,] matrix = new int[5, 5];
// int summ = 0;

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);
// int j = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     {

//         summ += matrix[i, j];
//         j++;
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"Сумма элементов главной диагонали {summ}");

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Пример: m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1

// int[,] matrix = new int[3, 4];

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] >= 0)
//             {
//                 Console.Write($" {matr[i, j]} ");
//             }
//             else
//             {
//                 Console.Write($"{matr[i, j]} ");
//             }

//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(-9, 10);
//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);