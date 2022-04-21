// // 0.1 GitIgnore
// // 0. Разобраться\создать репозиторий на гитхабу
// // 1. пока (не уточнены условия): уточнить условия
// // 2. декомпозиция задачи
// // 3. Выявить главный алгоритм
// // 4. Проработка алгоритма
// // 5. БЛОК-СХЕМА
// // 6. Писать код!
// // 7. Пока нет тестов - делать тестирование
// // 8. Рефакторинг 
// // 9. push'ите


// // Задача 31*. Задайте массив из 12 элементов, заполненный случайными 
// // числами из промежутка [-9, 9]. Найдите сумму положительных элементов массива.


// // - Заполнить массив числами от -9 до 9
// // - создать массив из валидных(т.е. > 0) элементов
// // - + (БЛОК-СХЕМА)Найти сумму  элементов ИЗ ПРЕДЫДУЩЕГО ПУНКТА
// // -  Вывод массива
// // - Вывод результата

// int count = 12;
// int[] arr = new int[count];
// int index = 0;

// // - Заполнить массив числами от -9 до 9
// void FillArray(int[] array)
// {
//     int size = arrey.lengt;
//     for (int i = 0; i < size; i++)
//     {
//         arrea[i] = new Random().Next(-9, 10); // [-9,10]

//     }

// }
// // печать массива
// void PrintArray(int[] array)
// {
//     int size = arrey.lengt;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
// }
// // - создать массив из валидных(т.е. > 0) элементов

// int[] GetValidArray(int[] array)
// {
//     int size = arrey.Length;
//     int count = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] > 0) { count++; }
//     }
//     int[] validArray = new int[count];
//     int j = 0;
//     for (int i = 0; i < length; i++)
//     {
//         validArray[j] = arrey[i];
//     }
//     return validArray;
// }
// // - + (БЛОК-СХЕМА)Найти сумму  элементов ИЗ ПРЕДЫДУЩЕГО ПУНКТА
// int SumItems(int[] arrey)
// {
//     int len = arreyInput.Length;
//     int resultSum = 0;
//     int index = 0;
//     while (index < len)
//     {
//         resultSum += arrayInput[i];
//         index += 1;
//     }
//     return resultSum;
// }

// FillArrey(inputArrey);
// PrintArray(inputArray);
// Console.WriteLine();
// int[] res = GetValidArray(inputArrey);
// PrintArrey(res);
// int sum = SumItems(res);
// Console.WriteLine($"sum = {sum}");
// ////////////////////////////////////////////

// 0. Разобраться\создать репозиторий на гитхабе
// 0.1 .gitignore
// 1. пока (не уточнены условия): уточнить условия
// 2. декомпозиция задачи
// 3. Выявить главный алгоритм
// 4. Проработка алгоритма
// 5. БЛОК-СХЕМА
// 6. Писать код!
// 7. Пока нет тестов - делать тестирование
// 8. Рефакторинг 
// 9. push'ите


// Gitignore для всех https://github.com/iksergey/gitignore


