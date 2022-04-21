// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится 
// информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел
//  массива data с учётом информации из массива info.
// Пример: 
// входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } 
// info = {2, 3, 3, 1 }
// выходные данные:1, 7, 0, 1
// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)
int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

void printMass(int[] mass)
{
    Console.Write("\n[");
    for (int i = 0; i < mass.Length-1; i++)
    {
        Console.Write($"{mass[i]}, ");
    }
    Console.WriteLine($"{mass[mass.Length-1]}]\n");
}

int[] BinaryToDecimal (int[] arreyData, int[] arreyInfo)
{
    int[] newArray = new int[arreyInfo.Length];
    int k = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        int BinLenght = arreyInfo[i];
        int temp = 0;
        for (int j = k; j < (k+BinLenght); j++)
        {
            temp += arreyData[(k+BinLenght-1)-(j-k)] * Convert.ToInt32(Math.Pow(2,j-k));
        }
        k += BinLenght;
        newArray[i] = temp;
    }
return newArray;
}
printMass(info);
printMass(data);
printMass(BinaryToDecimal(data, info));