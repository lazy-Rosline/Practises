// переводит в двоичную систему счисления
using System;
using static System.Console;

Clear();

string DecToBinary(string user)
{
    int N=int.Parse(user);
    string res="";
    while(N>0)
    {
        int v=N%2;
        res=v.ToString()+res;
        N=N/2;
    }
    return res;
}

// int[] ConvertToBinary(int number) 
// {
//     int length=0;
//     int N=number;
//     while (N!=0)
//     {
//         N=N/2;
//         length++;
//     }
//     int[] arrayIn = new int[length];
//     for(int i=0; i<arrayIn.Length;i++)
//     {
//         arrayIn[i]=number%2;
//         number=number/2;
//     }
//     int[] result=new int[length];
//     for(int k=0; k<result.Length; k++)
//     {
//         result[k]=arrayIn[arrayIn.Length-1-k];
//     }
//     return result;
// }

// Write("Введите число: ");
// int x =int.Parse(ReadLine());
// WriteLine(String.Join("",ConvertToBinary(x)));
Write("Введите число: ");
WriteLine(DecToBinary(ReadLine()));