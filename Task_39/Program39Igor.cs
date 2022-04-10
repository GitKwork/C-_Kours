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
Console.WriteLine("Ведите длину первой стороны");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите длину второй стороны");
int length2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите длину третеьей стороны");
int length3 = Convert.ToInt32(Console.ReadLine());


bool isTriangle(int side1, int side2, int side3)
{
  return ((side1 < side2 + side3) && (side2 < side1 + side3) && (side3 < side1 + side2));
}

if (isTriangle(length1, length2, length3))
{
  Console.WriteLine("Это треугольник");
}
else
{
  Console.WriteLine("Это не треугольник");
}

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

