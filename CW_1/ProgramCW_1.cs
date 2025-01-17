﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
void QuickSort(int[] source, int first, int last)
{
    int left = first,
        right = last,
        middle = source[(first + last) / 2];

    do
    {
        while (source[left] < middle) left++;
        while (source[right] > middle) right--; // ?? 

        if (left <= right)
        {
            if (source[left] > source[right])
            {
                int temp = source[left];
                source[left] = source[right];
                source[right] = temp;
            }
            left++;
            right--;
        }

    } while (left <= right);

    if (left < last) QuickSort(source, left, last);
    if (first < right) QuickSort(source, first, right);

}

int[] BubbleSort(int[] array)
{
  int length = array.Length;
  int temp = array[0];
  for (int i = 0; i < length; i++)
  {
    for (int j = i + 1; j < length; j++)
    {
      if (array[i] > array[j])
      {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }
  }
  return array;
}

bool Check(int[] arr)
{
    bool f = true;
    int size = arr.Length;
    for (int i = 1; i < size; i++)
    {
        if (arr[i - 1] > arr[i]) return false;
    }
    return f;
}

System.Console.WriteLine("QuickSort: ");
for (int i = 0; i < 10; i++)
{
    int[] arr = Enumerable.Range(1, 1_000).Select(e => new Random().Next(-30000, 30000)).ToArray();
    QuickSort(arr, 0, arr.Length - 1);
    System.Console.WriteLine(Check(arr));
}

System.Console.WriteLine("SortBubble ");
for (int i = 0; i < 10; i++)
{
    int[] arr = Enumerable.Range(1, 1_000).Select(e => new Random().Next(-30000, 30000)).ToArray();
    BubbleSort(arr);
    System.Console.WriteLine(Check(arr));
}
