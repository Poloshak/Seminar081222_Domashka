// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[]FillPrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

int FindChetnoeChisloCount(int[] arr)
{
    int count = 0;
    foreach(int i in arr)
    {
        if(i%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"количество чётных чисел в массиве: {count}");
    return count;
}

Console.Clear();
int[] array = new int[8];
FillPrintArray(array);
Console.WriteLine();
FindChetnoeChisloCount(array);
