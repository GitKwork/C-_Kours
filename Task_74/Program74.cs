// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// Перевод из двоичной системы счисления в десятичную
// using System;
// using System.Text;

// class Program
// {
//     static uint BinaryToDecimal(string binaryNumber)
//     {
//         var exponent = 0;
//         var result = 0u;
//         for (var i = binaryNumber.Length - 1; i >= 0; i--)
//         {
//             if (binaryNumber[i] == '1')
//             {
//                 result += Convert.ToUInt32(Math.Pow(2, exponent));
//             }
//             exponent++;
//         }

//         return result;
//     }

//     static void Main(string[] args)
//     {
//         Console.OutputEncoding = Encoding.UTF8;
//         Console.Write("Введите число в двоичной системе: ");
//         var binNum = Console.ReadLine();
//         var decNum = BinaryToDecimal(binNum);
//         Console.WriteLine("{0} => {1}", binNum, decNum);
//         Console.ReadLine();
//     }
// }

///////////////////////////////////////
// public class Program
//     {
//         public static int ToDec(string bin)
//         {
//             var result = 0;
//             for (int i = 0; i < bin.Length; ++i)   
//             {
//                 if (bin[bin.Length - i - 1] == '1')
//                 {
//                   result += (int) Math.Pow(2, i);
//                 }
//             }
//             return result;
//         }
        
//         public static void Main(string[] args)
//         {
//             int n = 10;
//             for (int i = 0; i < n; i++)
//                 Console.WriteLine(ToDec(string.Join("", Enumerable.Range(0, 8)
//                     .Select((v, p) => p + 1 == i || p + 1 == n - i - 1 ? '1' : '0'))));
//             Console.ReadKey();
//         }
//     }

//////////////////////////////

// string  btn = "1001" ;
// int _int = Convert.ToInt32(btn, 2);
// string str = Convert.ToString(125, 2);

//ну можна в строку перевети в цикле...типа
// string s;
// for(int i = 0;i<mas.length;i++)
// {
// if (mas[i])
// s+=1;
// else s+=0;
// }

////////////////////////////////

// static void Main()
// {
//     double x = 2, y = 8;

//     double result = Math.Pow(x, y);

//     Console.WriteLine($"{x} ^ {y} = {result}");

//     x = 256;

//     result = Math.Sqrt(x);

//     Console.WriteLine($"Квадратный корень {x} равен: {result}");

//     // Delay.
//     Console.ReadKey();
// }

