// // int[] macos = new int[12];
// // int len = macos.Length;
// // int index = 0;
// // int resnegative = 0;
// // int respositive = 0;
// // void MassiveStart(int[] array){
  
// //   while(index<len){
// //     array[index] = new Random() .Next(-9, 10);
// //     index++;
// //   }
// // for(int i = 0; i < len; i++){
// //   if(array[i] > 0){
// //       respositive += array[i]; 
// //   }else{
// //     resnegative += array[i];
// //   }
// // Console.WriteLine($"{macos[i]}"); 
// // } 

// // }

// // MassiveStart(macos);
// // Console.WriteLine("");
// // Console.WriteLine($"Сумма негативных {resnegative}, сумма позитивных {respositive} ");
// // Сортировка одномерного массива по возрастанию
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


// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);


// //35. В массиве из 123 чисел найти количество элементов из отрезка [10,99]


// int[] array = new int[123];
// int len = array.Length;
// int count = 0;
// for(int i = 0 ; i < len; i++)
// {
//     array[i] = new Random().Next(0,99);
//     Console.Write($"{array[i]} ");
// }
// for(int i = 0 ; i < len; i++)
// {
//     if(array[i] >=10 & array[i] <=99 )
//     {
//         count++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"чисел входящих в отрезок (10,99) {count}");
int[] startAr = {1, 2, 3, 4, 5, 6};
int[] resAr = new int[3] ;

void MultArray(int[] array, int[] res)
{

int first = 0;
int last = array.Length - 1;
int index = 0;

while (last > first)
{
    
    res[index++] = array[first++] * array[last--];
    // first++;
    // last--;
    // index++;
}
}

void Print(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}
MultArray(startAr, resAr);
Print(startAr);
Console.WriteLine();
Print(resAr);