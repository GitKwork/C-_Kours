// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8]; 
int len = array.Length;
int index = 0;
while(index < len)
{
    Console.WriteLine($"Введите {index} номер массива: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}

Console.Write("[ ");
for (int i=0; i<len; i++)
{
Console.Write($"{array[i]} ");
}
Console.Write("]");