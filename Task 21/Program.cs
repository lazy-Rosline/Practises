using System;
using static System.Console;

Clear();
Write("Введите координату х точки А ");
int x1 = int.Parse(ReadLine());
Write("Введите координату y точки А ");
int y1 = int.Parse(ReadLine());
Write("Введите координату z точки A ");
int z1 = int.Parse(ReadLine());
Write("Введите координату x точки B ");
int x2 = int.Parse(ReadLine());
Write("Введите координату y точки B ");
int y2 = int.Parse(ReadLine());
Write("Введите координату z точки B ");
int z2 = int.Parse(ReadLine());
double result = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
Write($"длина отрезка {result:f3}");