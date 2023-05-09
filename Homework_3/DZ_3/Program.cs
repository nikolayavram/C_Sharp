// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int index = 1;


while (index <= N)
{
    int result = (int)Math.Pow(index, 3);
    Console.Write($"{result} ");
    index++;
}

