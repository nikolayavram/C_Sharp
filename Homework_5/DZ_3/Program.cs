// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] NewArray = GetArray(20, 50, 150);

double MinNum = MinElement(NewArray);
double MaxNum = MaxElement(NewArray);


Console.Write("[");
Console.Write(string.Join(", ", NewArray));
Console.Write("]");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Разница между максимальным:{MaxNum} и минимальным:{MinNum} значениями равна {MaxNum - MinNum}");
Console.WriteLine();


double[] GetArray(int length, int min, int max)
{
    double[] array = new double[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    
    return array;
}

double MinElement(double[] array)
{
    double min = array[0];

    for (int x = 0; x < array.Length; x++)
    {
        if(array[x] <= min)
        {
            min = array[x];
        }
    }

    return min;
}

double MaxElement(double[] array)
{
    double max = array[0];

    for (int z = 0; z < array.Length; z++)
    {
        if(array[z] >= max)
        {
            max = array[z];
        }
    }
    
    return max;
}


