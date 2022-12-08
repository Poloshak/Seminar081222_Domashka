// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[]FillPrintArray(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
    Console.Write($"[{string.Join(", ",arr)}]");
    return arr;
}

int FindNechetnPositionElementSum (int[] arr)
{
    int sum = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(i%2!=0)
        {
            sum=sum+arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
    return sum;
}


Console.Clear();
int[] array = new int [6];
FillPrintArray(array);
Console.WriteLine();
FindNechetnPositionElementSum(array);