//выводит 3-ю цифру заданного числа, либо сообщает, что третьей цифры нет

using System;

Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
int length = s.Length;
  
//if (s[2]==null) ?
if (length<3)
{
    Console.Write("третьей цифры нет");
}
else {
    Console.Write(s[2]);
}

