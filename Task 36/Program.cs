using System;
using static System.Console;

Clear();
int[] ArrayFromString(string s)
{
    string[] User = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[User.Length];
    for(int i=0;i<result.Length;i++)
    {
        result[i]=int.Parse(User[i]);
    }
    return result;
}
int EvenPositionSum (int[] InArr)
{
    int sum=0;
    for(int i=0;i<InArr.Length;i+=2)
    {
        sum+=InArr[i];
    }
    return sum;
}

Write("Введите набор чисел (через пробел): ");
int[] array=ArrayFromString(ReadLine());
int Sum=EvenPositionSum(array);
WriteLine($"[{String.Join(",",array)}]-->сумма элементов на нечетных позициях: {Sum}");
