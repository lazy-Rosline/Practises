using System;
using static System.Console;

Clear();
Write("Введите число: ");
int N=int.Parse(Console.ReadLine());
int NumberAmount=GetNumbers(N);
WriteLine($"кол-во цифр равно {NumberAmount}");

int GetNumbers (int Initial)
{
    int count=0;
    while (Initial>0)
    {
        count+=1;
        Initial/=10;
    }
    return count;
}
//МОЕ решение:
// int i=10;
// int count=1;
// while (N>i)
// {
//     i*=10;
//     count++;
// }
// Write(count);
