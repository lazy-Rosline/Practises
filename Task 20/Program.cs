using System;
using static System.Console;

Clear();
Write("Введите координату х точки А ");
int x1 = int.Parse(ReadLine());
Write("Введите координату y точки А ");
int y1 = int.Parse(ReadLine());
Write("Введите координату х точки B ");
int x2 = int.Parse(ReadLine());
Write("Введите координату y точки B ");
int y2 = int.Parse(ReadLine());
double result = Math.Pow(((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),0.5);
Write($"длина отрезка {result:f3}");