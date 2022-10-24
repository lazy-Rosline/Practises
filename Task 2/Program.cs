Console.Clear();
Console.WriteLine("Введите номер дня недели ");
int DayNumber = int.Parse(Console.ReadLine());

if (DayNumber == 1)
{
    Console.Write("Понедельник");
}
if (DayNumber == 2)
{
    Console.Write("Вторник");
}
if (DayNumber == 3)
{
    Console.Write("Среда");
}
if (DayNumber == 4)
{
    Console.Write("Четверг");
}
if (DayNumber == 5)
{
    Console.Write("Пятница");
}
if (DayNumber == 6)
{
    Console.Write("Суббота");
}
if (DayNumber == 7)
{
    Console.Write("Воскресенье");
}
if (DayNumber>7||DayNumber==0)
{
    Console.Write("Введен неверный номер");
}