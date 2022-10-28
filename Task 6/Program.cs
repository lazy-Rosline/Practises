Console.Clear();
Console.Write("Ваше число?: ");
int a=int.Parse(Console.ReadLine());

if(a%2==0)
{
    Console.Write("четное");
}
else
{
    Console.Write("нечетное");
}