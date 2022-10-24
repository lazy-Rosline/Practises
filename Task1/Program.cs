Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int sqr2 = number2*number2;

if (number1 == sqr2)
{
    Console.Write("Да");
}
else 
{
    Console.Write("Нет");
}