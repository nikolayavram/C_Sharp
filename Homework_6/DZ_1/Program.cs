// Задание. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int arraySize)
{
    int[] array = new int[arraySize];
    Console.WriteLine();
    return array;
}

int[] ArrayFilling(int[] emptyArray)
{
    Console.WriteLine("Поочерёдно вводите любые положительные или отрицательные числа: ");
    for(int i = 0; i < emptyArray.Length; i++) emptyArray[i] = int.Parse(Console.ReadLine()!);
    return emptyArray;
}

void ResultOutput(int[] filledArray)
{
    int count = 0;
    for(int i = 0; i < filledArray.Length; i++) if(filledArray[i] > 0) count += 1;
    Console.WriteLine($"Чисел больше 0 было введено: {count}.");
}

Console.Clear();

Console.Write("Ввведите количество чисел (M), которые вы будете затем вводить: ");
int M = int.Parse(Console.ReadLine()!);

ResultOutput(ArrayFilling(CreateArray(M)));