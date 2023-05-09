// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



int[] GetResult = GetArray(15, 100, 999);

int count = GetCount(GetResult);

Console.WriteLine();
Console.Write("[");
Console.Write(string.Join(", ", GetResult));
Console.Write("]");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"В заданном массиве {count} четных чисел");
Console.WriteLine();


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

int GetCount(int[] array)
{
    int count = 0;
    for (int z = 0; z < array.Length; z++)
    {
     if(array[z] % 2 == 0)
     {
        count++;
     }

    }
    return count;
}

