// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 31*. Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// int[] macos = new int[12];
// int len = macos.Length;
// int index = 0;
// int resnegative = 0;
// int respositive = 0;
// void MassiveStart(int[] array){
//     while(index<len)
//     {
//     array[index] = new Random().Next(-9, 10);
//     index++;
//     }
//     for(int i = 0; i < len; i++)
//     {
//         if(array[i] > 0)
//         {
//         respositive += array[i]; 
//         }
//         else
//         {
//         resnegative += array[i];
//         }
//         Console.Write($"{macos[i]}; "); 
//     } 
    
//     Console.WriteLine(" ");
//     Console.WriteLine($"сумма позитивных {respositive}"); 
//     Console.WriteLine($"сумма негативных {resnegative}");
// } 

// MassiveStart(macos);




// // Из лекции -Сортировка одномерного массива по возрастанию
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1 ; i++)
//     {
//         int minPosition = i;
        
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

//31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// int[] array = new int[12]; 
// int len = array.Length;
// int index = 0;
// int res = 0;
// int resneg = 0;
// while(index < len)
// {
//     array[index] = new Random().Next(-9,10);
//     index++;
// }
// for (int i=0; i < len; i++)
// {
// if (array[i] < 0){
//   resneg += array[i];

// } else {
//   res += array[i];
// }
// Console.WriteLine($"{array[i]}");
// }
// Console.WriteLine("");
// Console.WriteLine($"сумма положительных = {res}, сумма отрицательных = {resneg}");
