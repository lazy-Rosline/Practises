using System;

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());  
int number2=N%100/10;
Console.Write($"{number2}");
