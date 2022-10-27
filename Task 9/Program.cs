using System;
Console.Clear();
int N = new Random().Next(10, 100);
Console.WriteLine(N);
if(N/10>N%10) 
{
    Console.Write(N/10);
}
else {
    Console.Write(N%10);
}