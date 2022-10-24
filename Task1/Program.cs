Console.Clear();
Console.Write("Введите первое число A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число B: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2*number2)
{
    Console.Write("А является квадратом В");
}
else 
{
    Console.Write("А не является квадратом В");
}