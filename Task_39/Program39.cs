// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины (каждая сторона треугольника
//  меньше суммы двух других сторон).
// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины (каждая сторона треугольника меньше суммы двух других сторон).
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// *Задача про Золотую Милю (условие задает преподаватель).

// double number = 9;
// double firstElem = 0;
// double secondElem = 1;

// Console.WriteLine($"1. {firstElem}");
// Console.WriteLine($"2. {secondElem}");

// for (int i = 2; i <= number; i++)
// {
//   double nextElem = firstElem + secondElem;
//   Console.WriteLine($"{i}. {nextElem}");
//   firstElem = secondElem;
//   secondElem = nextElem;
// }

// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void fillarray (int [] arr)

//  {
//    for(int i = 0; i < arr.Length; i++)
//   { arr[i] = new Random ().Next(-100,101);
//     Console.Write ($" {arr[i]}");
//   }
//  }
//  void revers (int [] arr)
// {
//     int [] res = new int [10];
//     for (int i=0; i<10; i++)
//    {
//     res[i] = arr[9-i];
//     res[9-i] = arr[i];
//     Console.Write ($" {res[i]}");
//     }
// };

// int [] massiveone = new int [10];
// fillarray (massiveone);
// Console.WriteLine (" ");
// revers (massiveone);


// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины 
//(каждая сторона треугольника меньше суммы двух других сторон).

// Console.WriteLine ("Введите 3и стороны треугольника");
// int A=Convert.ToInt16(Console.ReadLine());
// int B=Convert.ToInt16(Console.ReadLine());
// int C=Convert.ToInt16(Console.ReadLine());

// if ((A<(B+C))&&(B<(A+C))&&(C<(A+B)))
//  {
//      Console.WriteLine("Треугольник существует");
//  }
// else
//  {
//      Console.WriteLine("Треугольник не существует");
//  }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное

// Console.WriteLine ("Введите десятичное число");
// int A=Convert.ToInt16(Console.ReadLine());
// int B= 0;
// int length (int L)
// {
// int i =0;
// while (L>0)
// {
//     L=L/2;
//     i++;
// }
// return i;
// }
// int [] doble = new int [length (A)];
// int j=0;
//  while (A>0)
// {
//  B=A%2;
//  A=A/2;
//  doble[doble.Length-1-j]=B;
//  j++;
// }
// for (int k=0; k<doble.Length;k++)
// {
//     Console.Write ($" {doble[k]}");
// }

// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void fillarray (int [] arr)

//  {
//    for(int i = 0; i < arr.Length; i++)
//   { arr[i] = new Random ().Next(-100,101);
//     Console.Write ($" {arr[i]}");
//   }
//  }
//  void revers (int [] arr)
// {
//     int [] res = new int [10];
//     for (int i=0; i<10; i++)
//    {
//     res[i] = arr[9-i];
//     res[9-i] = arr[i];
//     Console.Write ($" {res[i]}");
//     }
// };

// int [] massiveone = new int [10];
// fillarray (massiveone);
// Console.WriteLine (" ");
// revers (massiveone);


// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины 
//(каждая сторона треугольника меньше суммы двух других сторон).

// Console.WriteLine ("Введите 3и стороны треугольника");
// int A=Convert.ToInt16(Console.ReadLine());
// int B=Convert.ToInt16(Console.ReadLine());
// int C=Convert.ToInt16(Console.ReadLine());

// if ((A<(B+C))&&(B<(A+C))&&(C<(A+B)))
//  {
//      Console.WriteLine("Треугольник существует");
//  }
// else
//  {
//      Console.WriteLine("Треугольник не существует");
//  }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное

// Console.WriteLine ("Введите десятичное число");
// int A=Convert.ToInt16(Console.ReadLine());
// int B= 0;
// int length (int L)
// {
// int i =0;
// while (L>0)
// {
//     L=L/2;
//     i++;
// }
// return i;
// }
// int [] doble = new int [length (A)];
// int j=0;
//  while (A>0)
// {
//  B=A%2;
//  A=A/2;
//  doble[doble.Length-1-j]=B;
//  j++;
// }
// for (int k=0; k<doble.Length;k++)
// {
//     Console.Write ($" {doble[k]}");
// }

// Задача 39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// void FillArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1, 1000);
//     }
// }

// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         Console.Write($"{col[i]} ");
//     }
// }

// Console.WriteLine("Введите количество элементов ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int [N];
// int[] mass2 = new int [N];
// int j = mass.Length -1;

// FillArray(mass);
// PrintArray(mass);
// Console.WriteLine();

// for (int i = 0; i < mass.Length; i++)
// {
//     mass2[j] = mass[i];
//     j--;
// }

// PrintArray(mass2);


// // Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

// Console.WriteLine("Введите первое число ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число ");
// int B = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите третье число ");
// int C = Convert.ToInt32(Console.ReadLine());

// if (A+B > C & A+C > B & B+C > A) Console.WriteLine($"может существовать треугольник со сторонами {A} {B} {C}");
// else Console.WriteLine($"не может существовать треугольник со сторонами {A} {B} {C}");



// string dirName = "C:\\ProgramFiles";
// // если папка существует
// if (Directory.Exists(dirName))
// {
//     Console.WriteLine("Подкаталоги:");
//     string[] dirs = Directory.GetDirectories(dirName);
//     foreach (string s in dirs)
//     {
//         Console.WriteLine(s);
//     }
//     Console.WriteLine();
//     Console.WriteLine("Файлы:");
//     string[] files = Directory.GetFiles(dirName);
//     foreach (string s in files)
//     {
//         Console.WriteLine(s);
//     }
// }


//Задача 39.Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// void FillArray(int[] array, int minValue, int maxValue)
// {
//   Random intGen = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = intGen.Next(minValue, maxValue + 1);
//   }
// }

// void ReverseArray(int[] array)
// {

//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     int tmp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = tmp;
//   }
// }

// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine("]");
// }

// Console.WriteLine("Ведите размер массива!");
// int Size = Convert.ToInt32(Console.ReadLine());

// int[] Array = new int[Size];
// FillArray(Array, -10, 10);
// PrintArray(Array);
// ReverseArray(Array);
// PrintArray(Array);

//Задача 40.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.WriteLine("Ведите длину первой стороны");
// int length1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ведите длину второй стороны");
// int length2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ведите длину третеьей стороны");
// int length3 = Convert.ToInt32(Console.ReadLine());


// bool isTriangle(int side1, int side2, int side3)
// {
//   return ((side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2));
// }

// if (isTriangle(length1, length2, length3))
// {
//   Console.WriteLine("Это треугольник");
// }
// else
// {
//   Console.WriteLine("Это не треугольник");
// }

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.



// string ReverseString(string array)
// {
//   string result = String.Empty;
//   for (int i = 0; i < array.Length; i++)
//   {
//     result += array[array.Length - 1 - i];
//   }

//   return result;
// }

// string DecimalToBinary(int Number)
// {
//   string result = String.Empty;
//   while (Number > 0)
//   {
//     int bit = Number % 2;
//     result += Convert.ToString(bit);
//     Number /= 2;
//   }
//   return ReverseString(result);
// }

// Console.WriteLine("Ведите число");
// int Number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DecimalToBinary(Number));

// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Фибоначчи – ряд чисел, в котором каждое последующее число является суммой двух предыдущих: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 и так далее
// System.Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// int b = 1;
// int result = 0;

// for (int i = 0; i < number - 2 ; i++)
// {
//     if(i==0){
//         System.Console.WriteLine(a);
//         System.Console.WriteLine(b);
//     }
//     result = a+b;
//     a=b;
//     b = result;
//     System.Console.WriteLine(b);
// }

//Задача 39.Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// void FillArray(int[] array, int minValue, int maxValue)
// {
//   Random intGen = new Random();
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = intGen.Next(minValue, maxValue + 1);
//   }
// }

// void ReverseArray(int[] array)
// {

//   for (int i = 0; i < array.Length / 2; i++)
//   {
//     int tmp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = tmp;
//   }
// }

// void PrintArray(int[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine("]");
// }

// Console.WriteLine("Ведите размер массива!");
// int Size = Convert.ToInt32(Console.ReadLine());

// int[] Array = new int[Size];
// FillArray(Array, -10, 10);
// PrintArray(Array);
// ReverseArray(Array);
// PrintArray(Array);

//Задача 40.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Console.WriteLine("Ведите длину первой стороны");
// int length1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ведите длину второй стороны");
// int length2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ведите длину третеьей стороны");
// int length3 = Convert.ToInt32(Console.ReadLine());


// bool isTriangle(int side1, int side2, int side3)
// {
//   return ((side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2));
// }

// if (isTriangle(length1, length2, length3))
// {
//   Console.WriteLine("Это треугольник");
// }
// else
// {
//   Console.WriteLine("Это не треугольник");
// }

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.



// string ReverseString(string array)
// {
//   string result = String.Empty;
//   for (int i = 0; i < array.Length; i++)
//   {
//     result += array[array.Length - 1 - i];
//   }

//   return result;
// }

// string DecimalToBinary(int Number)
// {
//   string result = String.Empty;
//   while (Number > 0)
//   {
//     int bit = Number % 2;
//     result += Convert.ToString(bit);
//     Number /= 2;
//   }
//   return ReverseString(result);
// }

// Console.WriteLine("Ведите число");
// int Number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DecimalToBinary(Number));
//Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

// int[] Fibbonachi(int Number)
// {
//   int[] array = new int[Number];
//   array[0] = 0;
//   array[1] = 1;
//   for (int i = 2; i < Number; i++)
//   {
//     array[i] = array[i - 2] + array[i - 1];
//   }

//   return array;
// }

// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// PrintArray(Fibbonachi(Number));


