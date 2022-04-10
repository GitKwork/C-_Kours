//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования - когда каждый элемент одного объекта по отдельности копируется в такой же элемент в другом объекте.
// int[] GetRandArr(int size)
// {
//     int[] RandArr = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         RandArr[i] = new Random().Next(1,10);
//     }
//     return RandArr;
// }
// int[] GetSimArr(int[] array)
// {
//     System.Console.WriteLine();
//     int[] ResArr = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)
//     {
//         ResArr[i] =  array[i];
//     }
//     return ResArr;
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] Array1 = GetRandArr(7);
// PrintArray(Array1);
// System.Console.WriteLine();
// int[] Array2 = GetSimArr(Array1);
// PrintArray(Array2);


// Задача 46. Показать двумерный массив размером m×n заполненный целыми числами
// int[,] GetArray(int a, int b)
// {
//     int[,] array = new int[a, b];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// int[,] array1 = GetArray(5, 7);
// PrintArray(array1);

//Задача 48. Задать двумерный массив следующим правилом: A(m,n) = m+n.
// int InputExamNumber() // ввод и проверка числа
// {
//     while (true)
//     {
//         string text = Console.ReadLine();
//         if (int.TryParse(text, out int number))
//         {
//             return number;
//             break;
//         }
//         Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//     }
// }
// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($" {matr[i, j]}");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i+j;
//         }
//     }
// }
// Console.WriteLine("Введите количество строк");
// int m = InputExamNumber();
// Console.WriteLine("Введите количество столбцов");
// int n = InputExamNumber();
// int [,] array = new int[m, n];
// FillArray(array);
// PrintArray(array);



//Задача 45+. В матрице чисел найти сумму элементов главной диагонали

// void FillTwoDimentionalArray(int[,] array, int minNumber, int maxNumber)
// {
// Random rnd = new Random();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// array[i, j] = rnd.Next(minNumber, maxNumber + 1);
// }
// }
// }

// void PrintTwoDimentionalArray(int[,] array)
// {
// Console.Write("\t");
// for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{j}\t");
// Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
// Console.Write($"{i}\t");
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write($"{array[i, j]}\t");
// }
// Console.WriteLine();
// }
// }


// int[,] workArray = new int[5,5];

// FillTwoDimentionalArray(workArray, -8, 6);
// PrintTwoDimentionalArray(workArray);