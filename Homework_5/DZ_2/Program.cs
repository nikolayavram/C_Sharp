// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] NewArray = GetArray(15, -100, 100);

int Result = SumResult(NewArray);

Console.WriteLine();
Console.Write("[");
Console.Write(string.Join(", ", NewArray));
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"В заданном массиве сумма элементов, стоящих на нечетных позициях равна {Result}");


int[] GetArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random rnd = new Random();
    
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    
    return array;

}

int SumResult(int[] array)
{
    int sum = 0;

    for (int x = 0; x < array.Length; x++)
    {
        if(x % 2 != 0)
        {
            sum = sum + array[x];
        }
    }
    
    return sum;
}

