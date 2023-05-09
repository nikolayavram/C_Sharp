//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;

if(a>b & a>c)
{
    max = a;
    Console.WriteLine(max);
}
else if(b>a & b>c)
{
    max = b;
    Console.WriteLine(max);
}
else
{
    if(c>a & c>b)
    max = c;
    Console.WriteLine(max);
}
