using System;
using static System.Console;

Clear();
Write("Введите N: ");
int N = int.Parse(ReadLine());
// 1.- Моё решение:
// int sum=0;
// for (int i=1;i<=N;i++)
// {
//     sum=sum+i;
// }
// Write($"сумма от 1 до N = {sum}");
// 2.-С использованием МЕТОДА, (как на лекции):
int GetSumNumbers (int number)
{
    int sum=0;
    for(int i=1;i<=number;i++)
    {
        sum = sum + i;
    }
    return sum;
}

int summa = GetSumNumbers(N);
Write($"Сумма= {summa}");