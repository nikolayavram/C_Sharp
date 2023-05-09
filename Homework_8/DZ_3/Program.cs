// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateArray(int rows, int columns) {
    int[,] array = new int[rows, columns];

    return (array);
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

int[,] Method(int[,] filledArray1, int[,] filledArray2) {
    int[,] resultArray = new int[filledArray1.GetLength(0),filledArray2.GetLength(1)];

    if(filledArray1.GetLength(0) == filledArray2.GetLength(1) && filledArray1.GetLength(1) == filledArray2.GetLength(0)) {
        for(int i = 0; i < resultArray.GetLength(0); i++) {
            for(int j = 0; j < resultArray.GetLength(1); j++) {
                int sum = 0;
                for(int k = 0; k < filledArray1.GetLength(1); k++) {
                    sum += filledArray1[i, k] * filledArray2[k, j];
                }
                resultArray[i, j] = sum;
            }
        }
    }
    else {
        Console.WriteLine("Матрицы нельзя перемножить!");
    }

    return resultArray;
}

void PrintArray(int[,] resultMatrix) {
    for(int i = 0; i < resultMatrix.GetLength(0); i++) {
        for(int j = 0; j < resultMatrix.GetLength(1); j++) {
            Console.Write(resultMatrix[i,j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Привет! Эта программа находит произведение двух матриц.");
Console.WriteLine();

Console.Write("Введите количество строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();

PrintArray(Method(FillArray(CreateArray(rows1, columns1)), FillArray(CreateArray(rows2, columns2))));