// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[] days = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write ("Номер дня недели: ");
int day = int.Parse (Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine ("Будний день");
}
Console.WriteLine(days[day-1]);