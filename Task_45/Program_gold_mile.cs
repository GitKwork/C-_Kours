// // Задача 45: Напишите программу, которая будет 
// // создавать копию заданного массива с помощью поэлементного копирования (программа копирования массива)д.) 

// using System;

// const int size_N = 10;

// void init_array(int [] local_array)
// {
//     Random rnd = new Random();
//     for (int i=0; i< size_N; i++)
//     {
//         local_array[i] = rnd.Next(-10,11);
//     }
// }

// void print_array(int [] local_array)
// {
//   Console.Write("[");
//   for(int i=0;i<size_N - 1;i++)
//   {
//       Console.Write($"{local_array[i]}, ");
//   }
//   Console.WriteLine($"{local_array[size_N - 1 ]}]");
// }

// int [] CopyArray(int [] local_array)
// {
//     int [] ret_array = new int [size_N];
//     for(int i=0; i<size_N;i++)
//     {
//         ret_array[i] = local_array[i];
//     }
//     return ret_array;
// }

// int [] array1 = new int[size_N];
// int [] array2 = new int[size_N];

// init_array(array1);
// print_array(array1);
// array2 = CopyArray(array1);
// print_array(array2);


// // Задача 45+: В матрице чисел найти сумму элементов главной диагонали.

// using System;

// const int size_w = 10;
// const int size_h = size_w;

// void init_matrix(int [,] local_matrix)
// {
//     Random rnd = new Random(5);
//     for(int i=0;i<size_h;i++)
//         for(int j=0;j<size_w;j++)
//         {
//             local_matrix[i,j] = rnd.Next(0,10);
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

// int Get_Diagonal(int [,] local_matrix)
// {
//     int ret = 0;
//     for(int i=0;i<size_w;i++)
//     {
//         ret +=local_matrix[i,i];
//     }
//     return ret;
// }

// int [,] matrix = new int [size_w,size_h];

// init_matrix(matrix);
// print_matrix(matrix);
// Console.WriteLine($"Сумма элементов диагонали равна: {Get_Diagonal(matrix)}");

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми

// using System;

// const int size_w = 20;
// const int size_h = 10;

// void init_matrix(int [,] local_matrix)
// {
//     Random rnd = new Random();
//     for(int i=0;i<size_h;i++)
//         for(int j=0;j<size_w;j++)
//         {
//             local_matrix[i,j] = rnd.Next(10,100);
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

// Задача о золотой миле

using System;

const int time_drink = 15;
const int time_walk = 25;

const double pinta = 0.58;

const int count_friends = 4;
const int count_bars = 12;

double [] friends_limit_volumes = new double [count_friends] {1.6,8.2,4.3,10.4};

double [] time_friends = new double[count_friends] {0,0,0,0};
double [] volume_friends = new double[count_friends] {0,0,0,0};
int [] friends_alive = new int [count_friends] {0,0,0,0};

void print_array(double [] local_array)
{
  Console.Write("[");
  for(int i=0;i<local_array.Length - 1;i++)
  {
      Console.Write($"{local_array[i]}, ");
  }
  Console.WriteLine($"{local_array[local_array.Length - 1 ]}]");
}

for(int i=0; i<count_friends;i++)
{
    for(int j=0;j<count_bars;j++)
    {
        if (friends_alive[i]==0) {time_friends[i] += time_drink;}
        if (friends_alive[i]==0)
        {
            if (volume_friends[i]<friends_limit_volumes[i]) {volume_friends[i] += pinta;}else {friends_alive[i]=j;} 
        }
        if (friends_alive[i]==0) {time_friends[i] += time_walk;}
    }
    
}
Console.WriteLine("Затраченное время");
print_array(time_friends);

for(int i=0;i<friends_alive.Length;i++)
{
    if (friends_alive[i]==0) {friends_alive[i]=11;} 
}

Console.WriteLine("Пройденное расстояние (в барах)");
Console.Write("[");
for(int i=0;i<friends_alive.Length - 1;i++)
{
    Console.Write($"{friends_alive[i]}, ");
}
Console.WriteLine($"{friends_alive[friends_alive.Length - 1 ]}]");

