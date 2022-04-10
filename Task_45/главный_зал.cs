// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Пример: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//  using System;

// const int size_w = 4;
// const int size_h = 3;

// void init_matrix(int [,] local_matrix)
// {
//      for(int i=0;i<size_h;i++)
//         for(int j=0;j<size_w;j++)
//         {
//             local_matrix[i,j] = i+j;
//         }
// }

// void print_matrix(int [,] local_matrix)
// {
//     for(int i=0;i<size_h;i++)
//     {
//         Console.Write("[");
//         for(int j=0;j<size_w-1;j++)
//         {
//             Console.Write($"{local_matrix[i,j]} ");
//         }
//         Console.WriteLine($"{local_matrix[i,size_w-1]}]");
//     }    
// }

// int [,] matrix = new int [size_h,size_w];
// init_matrix(matrix);
// print_matrix(matrix);