using System;

Console.Clear();
Console.Write("Введите целое трехзначное число ");
int N = int.Parse(Console.ReadLine());
if (N>99&&N<1000)
{
int result = N%10;
Console.Write($"Последняя цифра {result}");
}
else 
{
    Console.Write("Вы ввели не трехзначное число");
}