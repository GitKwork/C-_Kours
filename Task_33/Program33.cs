// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 33. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Console.WriteLine("Введите длину массива: ");
// int perem = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine("Введите число для поиска: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[perem];
// int index = 0;
// int flag = 0;


// void MassiveStart(int[] array)
// {
//     while(index < perem)
//     {
//         array[index] = new Random().Next(-10, 10);
//         Console.Write($" {mass[index]}, ");
//         index++;
//     }
//     Console.WriteLine("");
//     for (int i = 0; i < perem; i++)
//     {
//         if(mass[i] == digit)
//         {
//             flag = 1;
//             break;
//         }
//     }
//     if(flag == 1)
//     {
//         Console.WriteLine($"Цифра {digit} присутствует в массиве");
//     }
//     else
//     {
//         Console.WriteLine($"Цифра {digit} отсутствует в массиве");
//     }
// }

// MassiveStart(mass);

//33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// int[] boboka = {1,2,3,4,5,6,7,8,9,10};
// int number = new Random() .Next(1,15);
// bool bfinal = false;

// for (int i = 0; i < boboka.Length; i++){
//   if(number == boboka[i]){
//     bfinal = true;
//     break;
//   }
// }
// if(bfinal) Console.WriteLine($"{number} в массиве");
// else Console.WriteLine($"{number} нет в массиве");