// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

double[]FillPrintArray(double[] arr, double start)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()* 6+start;
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

double MaxMinElemDiff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff = 0;
    foreach(double item in arr)
    {
        if(item>max) max=item;
        if(item<min) min=item;
    }
    diff = max-min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
    return diff;
}    



Console.Clear();
double [] array = new double[6];
FillPrintArray(array,0);
Console.WriteLine();
MaxMinElemDiff(array);