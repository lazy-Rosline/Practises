using System;
using static System.Console;
Clear();

Write("Введите сторону a: ");
int a=int.Parse(ReadLine());
Write("Введите сторону b: ");
int b=int.Parse(ReadLine());
Write("Введите сторону c: ");
int c=int.Parse(ReadLine());

if ((a+b)>c&&(b+c>a)&&(a+c)>b) Write("можно получить треугольник");
else Write("треугольник невозможен");

// лекционное решение:

// bool IsTriangle(int a, int b, int c)
// {
//     return (((a+b)>c)&&((a+c)>b&&((c+b)>a)));
// }

// Write("Введите длины сторон треугольника через пробел: ");
// string[] nums=ReadLine().Split(" ");
// if (IsTriangle(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])))
// {
//     WriteLine("Да");
// }
// else 
// {
//     WriteLine("нет");
// }