//Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int a = 5;
// int b = 5;

// int [,] array = new int [a,b];

// void PrintArray(int[,] localArray){
//     for (int i = 0; i <a ; i++)
// {
//     for (int j = 0; j < b; j++)
//     {
//         Console.Write($"{array[i,j],4} ");
//     }
//     Console.WriteLine();
// }

// }

// for (int i = 0; i <a ; i++)
// {
//     for (int j = 0; j < b; j++)
//     {
//         array[i,j] = new Random().Next(-5,6);
//     }
// }
// PrintArray(array);
// int temp = 0;
//     for (int j = 0; j < b; j++)
//     {
//         temp = array[0,j];
//         array[0,j] = array[a-1,j];
//         array[a-1,j] = temp;
//     }
//     Console.WriteLine();
// PrintArray(array);


// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int a = 5;
// int b = 5;
// int[,] array = new int[a, b];

// void PrintArray(int[,] localArray)
// {
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             Console.Write($"{array[i, j],4} ");
//         }
//         Console.WriteLine();
//     }
// }
// for (int i = 0; i < a; i++)
// {
//     for (int j = 0; j < b; j++)
//     {
//         array[i, j] = new Random().Next(0, 51);
//     }
// }
// if (a != b)
// {
//     Console.WriteLine("Действие невозможно");
// }
// else
// {
//     PrintArray(array);
//     int temp = 0;
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = i; j < b; j++)
//         {
//             temp = array[i, j];
//             array[i, j] = array[j, i];
//             array[j, i] = temp;
//         }
//     }
//     Console.WriteLine();
//     PrintArray(array);
// }
// //Вывести числа Фибоначчи с помощью рекурсии
// //f(n) = f(n - 1) + f(n - 2) 
// int Fibonacci(int a){
//    if (a > 1) {
//     int b = Fibonacci(a - 1) + Fibonacci (a - 2);
//     return b;
//     } else{
//       return a;
//     }
//   }

// Console.WriteLine("Введите число:");
// int Fibo = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= Fibo; i++){
//   Console.WriteLine($"{Fibonacci(i)} ");
// }
// }
//Вывести числа Фибоначчи с помощью рекурсии
//f(n) = f(n - 1) + f(n - 2) 
// int Fibonacci(int a)
// {
//   if (a > 1)
//   {
//     int b = Fibonacci(a - 1) + Fibonacci(a - 2);
//     return b;
//   }
//   else
//   {
//     return a;
//   }
// }

// Console.WriteLine("Введите число:");
// int Fibo = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= Fibo; i++)
// {
//   Console.WriteLine($"{Fibonacci(i)} ");
// }
