// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array() {
    int[,] array = new int[3, 4];

    return array;
}

int[,] FillArray(int[,] emptyArray) {
    for(int i = 0; i < emptyArray.GetLength(0); i++) {
        for(int j = 0; j < emptyArray.GetLength(1); j++) {
            emptyArray[i, j] = new Random().Next(1, 10);
            Console.Write(emptyArray[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return emptyArray;
}

int[,] Sorting(int[,] filledArray)
{
    for(int i = 0; i < filledArray.GetLength(0); i++)
    {
        for(int j = 0; j < filledArray.GetLength(1); j++)
        {
            for(int k = 0; k < filledArray.GetLength(1) - 1; k++)
            {
                if(filledArray[i, k] < filledArray[i, k + 1])
                {
                    int buff = filledArray[i, k + 1];
                    filledArray[i, k + 1] = filledArray[i, k];
                    filledArray[i, k] = buff;
                }
            }
        }
    }

    return filledArray;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(Sorting(FillArray(array())));