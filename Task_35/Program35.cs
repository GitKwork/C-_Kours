// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 35.Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// // Задача 35.Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// using System;

// const int size_N=123;

// int [] array = new int[size_N];

// void print_array()
// {
//     Console.Write("[");
//     for(int i=0; i < size_N-1; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine($"{array[size_N-1]}]");
// }

// void init_array()
// {
//     Random rnd = new Random();
//     for(int i=0; i<size_N; i++)
//     {
//         array[i]=rnd.Next(-1000,1000);
//     }
// }

// int my_count()
// {
//     int ret=0;
//     for(int i=0; i<size_N;i++)
//     {
//         if ((array[i]>=10)&&(array[i]<=99))
//             ret++;
//     }
//     return ret;
// }

// init_array();
// print_array();
// Console.WriteLine($"В массиве {my_count()} элементов, лежащих между 10 и 99");

// rray(array);
// int [] array1 = process_array2(array);
// print_array(array1);


//35. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] array = new int[123];
// int len = array.Length;
// int count = 0;
// for(int i = 0 ; i < len; i++)
// {
//     array[i] = new Random().Next(0,99);
//     Console.Write($"{array[i]} ");
// }
// for(int i = 0 ; i < len; i++)
// {
//     if(array[i] >=10 & array[i] <=99 )
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"чисел входящих в отрезок (10,99) {count}");

