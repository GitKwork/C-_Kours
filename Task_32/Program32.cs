﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 32. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.

//32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот(значения для массива задаете сами, цифры подставляете в него любые изначально).
int[] array = {1,2,3,4,5};
for(int i = 0; i < array.Length; i++){
  array[i] *= -1;
  Console.Write(array[i]);
  Console.Write(",");
}