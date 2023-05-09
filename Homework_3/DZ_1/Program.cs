// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
int min = 10000;
int max = 100000;
if (number > min && number < max)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Введеное число - палиндром");
    }
else
{
    Console.WriteLine("Число не является палиндромом");
}
}
else
{
    Console.WriteLine("Не пятизначное число");
}
