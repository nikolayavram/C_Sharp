//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out int number);
string str = number.ToString();
int lenght = str.Length;
if (lenght > 2)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}







