Console.Clear();
Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int count = -N;
while (count<=N)
{
    Console.Write($"{count} ");
    count++;
}

