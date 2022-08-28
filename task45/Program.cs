// Задача 45: Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.

int[] array = { 5, 3, 6, 14, 2, 5, 8 };
for (int i = 0; i < array.Length; i++)
{
    int [] arr = new int [array.Length];
    int j = 0;// j <= array.Length -1; j++)
    {
        arr[j]=array [i];
        Console.Write(arr[j]);
        Console.Write(",");
    }
    
}
Console.WriteLine();