// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования (программа копирования массива) Задача 45+:
// В матрице чисел найти сумму элементов главной диагонали.
// https://github.com/ElSobitol/StartTasks/blob/main/task7.md

// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// int[,] Mass = new int[StrokaMass, StolbMass];

// for (int k = 0; k < StrokaMass; k++)
// {
//     for (int i = 0; i < StolbMass; i++)
//     {
//         Mass[k, i] = k+i;
//         Console.Write($" {Mass[k, i]}\t");
//     }
//     Console.WriteLine(" ");
// }


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

// using System;

// const int time_drink = 15;
// const int time_walk = 25;

// const double pinta = 0.58;

// const int count_friends = 4;
// const int count_bars = 12;

// double [] friends_limit_volumes = new double [count_friends] {1.6,8.2,4.3,10.4};

// double [] time_friends = new double[count_friends] {0,0,0,0};
// double [] volume_friends = new double[count_friends] {0,0,0,0};
// int [] friends_alive = new int [count_friends] {0,0,0,0};

// void print_array(double [] local_array)
// {
//   Console.Write("[");
//   for(int i=0;i<local_array.Length - 1;i++)
//   {
//       Console.Write($"{local_array[i]}, ");
//   }
//   Console.WriteLine($"{local_array[local_array.Length - 1 ]}]");
// }

// for(int i=0; i<count_friends;i++)
// {
//     for(int j=0;j<count_bars;j++)
//     {
//         if (friends_alive[i]==0) {time_friends[i] += time_drink;}
//         if (friends_alive[i]==0)
//         {
//             if (volume_friends[i]<friends_limit_volumes[i]) {volume_friends[i] += pinta;}else {friends_alive[i]=j;} 
//         }
//         if (friends_alive[i]==0) {time_friends[i] += time_walk;}
//     }
    
// }
// Console.WriteLine("Затраченное время");
// print_array(time_friends);

// for(int i=0;i<friends_alive.Length;i++)
// {
//     if (friends_alive[i]==0) {friends_alive[i]=11;} 
// }

// Console.WriteLine("Пройденное расстояние (в барах)");
// Console.Write("[");
// for(int i=0;i<friends_alive.Length - 1;i++)
// {
//     Console.Write($"{friends_alive[i]}, ");
// }
// Console.WriteLine($"{friends_alive[friends_alive.Length - 1 ]}]");


// using System.Linq;
// using System.Collections.Generic;
// using UnityEngine;

// public class PathFinder : MonoBehaviour
// {
//     public List<Vector2> PathToTarget;
//     public List<Node> CheckedNodes = new List<Node>();
//     public List<Node> FreeNodes = new List<Node>();
//     List<Node> WaitingNodes = new List<Node>();
//     public GameObject Target;
//     public LayerMask SolidLayer;

    
//     // Update is called once per frame
//     void Update()
//     {
//         //PathToTarget = GetPath(Target.transform.position);
//     }

//     public List<Vector2> GetPath(Vector2 target)
//     {
//         PathToTarget = new List<Vector2>();
//         CheckedNodes = new List<Node>();
//         WaitingNodes = new List<Node>();

//         Vector2 StartPosition = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
//         Vector2 TargetPosition = new Vector2(Mathf.Round(target.x), Mathf.Round(target.y));
        
//         if(StartPosition == TargetPosition) return PathToTarget;

//         Node startNode = new Node(0, StartPosition, TargetPosition, null);
//         CheckedNodes.Add(startNode);
//         WaitingNodes.AddRange(GetNeighbourNodes(startNode));
//         while(WaitingNodes.Count > 0)
//         {
//             Node nodeToCheck = WaitingNodes.Where(x => x.F == WaitingNodes.Min(y => y.F)).FirstOrDefault();

//             if (nodeToCheck.Position == TargetPosition)
//             {
//                 return CalculatePathFromNode(nodeToCheck);
//             }

//             var walkable = !Physics2D.OverlapCircle(nodeToCheck.Position, 0.1f, SolidLayer);
//             if(!walkable)
//             {
//                 WaitingNodes.Remove(nodeToCheck);
//                 CheckedNodes.Add(nodeToCheck);
//             }
//             else if(walkable)
//             {
//                 WaitingNodes.Remove(nodeToCheck);
//                 if(!CheckedNodes.Where(x => x.Position == nodeToCheck.Position).Any()) {
//                     CheckedNodes.Add(nodeToCheck);
//                     WaitingNodes.AddRange(GetNeighbourNodes(nodeToCheck));
//                 } 
//             }
//         }
//         FreeNodes = CheckedNodes;

//         return PathToTarget;
//     }

//     public List<Vector2> CalculatePathFromNode(Node node)
//     {
//         var path = new List<Vector2>();
//         Node currentNode = node;

//         while(currentNode.PreviousNode != null)
//         {
//             path.Add(new Vector2(currentNode.Position.x, currentNode.Position.y));
//             currentNode = currentNode.PreviousNode;
//         }

//         return path;
//     }

//     List<Node> GetNeighbourNodes (Node node)
//     {
//         var Neighbours = new List<Node>();

//         Neighbours.Add(new Node(node.G + 1, new Vector2(
//             node.Position.x-1, node.Position.y), 
//             node.TargetPosition, 
//             node));
//         Neighbours.Add(new Node(node.G + 1, new Vector2(
//             node.Position.x+1, node.Position.y),
//             node.TargetPosition,
//             node));
//         Neighbours.Add(new Node(node.G + 1, new Vector2(
//             node.Position.x, node.Position.y-1),
//             node.TargetPosition,
//             node));
//         Neighbours.Add(new Node(node.G + 1, new Vector2(
//             node.Position.x, node.Position.y+1),
//             node.TargetPosition,
//             node));
//         return Neighbours;
//     }

//     void OnDrawGizmos()
//     {
//         foreach (var item in CheckedNodes)
//         {
//             Gizmos.color = Color.yellow;
//             Gizmos.DrawSphere(new Vector2(item.Position.x, item.Position.y), 0.1f);
//         }
//         if (PathToTarget != null)
//         foreach (var item in PathToTarget)
//         {
//             Gizmos.color = Color.red;
//             Gizmos.DrawSphere(new Vector2(item.x, item.y), 0.2f);
//         }
//     }

// }

// public class Node 
// {
//     public Vector2 Position;
//     public Vector2 TargetPosition;
//     public Node PreviousNode;
//     public int F; // F=G+H
//     public int G; // расстояние от старта до ноды
//     public int H; // расстояние от ноды до цели

//     public Node(int g, Vector2 nodePosition, Vector2 targetPosition, Node previousNode)
//     {
//         Position = nodePosition;
//         TargetPosition = targetPosition;
//         PreviousNode = previousNode;
//         G = g;
//         H = (int)Mathf.Abs(targetPosition.x - Position.x) + (int)Mathf.Abs(targetPosition.y - Position.y);
//         F = G + H;
//     }
// }



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

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// Пример: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] matrix = new int[7, 13];

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i, j] < 10)
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
//             matr[i, j] = i + j;
//         }
//     }
// }

// FillArray(matrix);
// PrintArray(matrix);

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


// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования (программа копирования массива)

// Console.WriteLine("Введите длинну массива");
// int LenghtMass = Convert.ToInt32(Console.ReadLine());
// int[] Mass = new int[LenghtMass];
// int[] MassCopy; // = new int[LenghtMass];

// for (int k = 0; k < Mass.Length; k++)
// {
//     Mass[k] = new Random().Next(-100, 101);
//     Console.Write($" {Mass[k]}");
// }

// Console.WriteLine(" ");

// int[] Copy(int[] arr)
// {
//     int[] result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[i];
//     }
//     return result;
// }

// MassCopy = Copy(Mass);

// for (int j = 0; j < MassCopy.Length; j++)
// {
//     Console.Write($" {MassCopy[j]}");
// }

// Задача 45+: В матрице чисел найти сумму элементов главной диагонали.

// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// int[,] Mass = new int[StrokaMass, StolbMass];

// for (int k = 0; k < StrokaMass; k++)
// {
//     for (int i = 0; i < StolbMass; i++)
//     {
//         Mass[k, i] = new Random().Next(-10, 11);
//         Console.Write($" {Mass[k, i]}\t");
//     }
//     Console.WriteLine(" ");
// }
// int Sum = 0;
// for (int k = 0; k < StrokaMass; k++)
// {
//     for (int i = 0; i < StolbMass; i++)
//     {
//         if (i == k)
//             Sum += Mass[k, i];
//     }

// }
// Console.WriteLine($"Сумма чисел диагонали массива = {Sum}");

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами

// Console.WriteLine("Введите количество строк массива");
// int StrokaMass = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива");
// int StolbMass = Convert.ToInt32(Console.ReadLine());
// int[,] Mass = new int[StrokaMass, StolbMass];

// for (int k = 0; k < StrokaMass; k++)
// {
//     for (int i = 0; i < StolbMass; i++)
//     {
//         Mass[k, i] = new Random().Next(-10, 11);
//         Console.Write($" {Mass[k, i]}\t");
//     }
//     Console.WriteLine(" ");
// }
