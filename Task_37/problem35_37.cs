// Задача 35.Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using System;

const int size_N=123;

int [] array = new int[size_N];

void print_array()
{
    Console.Write("[");
    for(int i=0; i < size_N-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[size_N-1]}]");
}

void init_array()
{
    Random rnd = new Random();
    for(int i=0; i<size_N; i++)
    {
        array[i]=rnd.Next(-1000,1000);
    }
}

int my_count()
{
    int ret=0;
    for(int i=0; i<size_N;i++)
    {
        if ((array[i]>=10)&&(array[i]<=99))
            ret++;
    }
    return ret;
}

init_array();
print_array();
Console.WriteLine($"В массиве {my_count()} элементов, лежащих между 10 и 99");


// // Задача 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// // элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// using System;

// const int size_N=16;

// int [] array = new int[size_N];

// void print_array(int [] local_array)
// {
//     Console.Write("[");
//     for(int i=0; i < local_array.Length-1; i++)
//     {
//         Console.Write($"{local_array[i]}, ");
//     }
//     Console.WriteLine($"{local_array[local_array.Length-1]}]");
// }

// void init_array()
// {
//     Random rnd = new Random();
//     for(int i=0; i<size_N; i++)
//     {
//         array[i]=rnd.Next(-10,11);
//     }
// }

// int [] process_array2(int [] local_array)
// {
//   int [] ret_array = new int[local_array.Length/2];
//   for (int i=0; i<ret_array.Length;i++)
//   {
//       ret_array[i] = local_array[i] * local_array[local_array.Length - i -1];
//   }
//   return ret_array;
// }

// init_array();
// print_array(array);
// int [] array1 = process_array2(array);
// print_array(array1);

