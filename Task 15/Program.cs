// проверяет по номеру является ли день недели выходным
using System;
using static System.Console;

Clear();

Write("Введите номер дня недели ");
int dayNumber=int.Parse(ReadLine());
switch(dayNumber)
{
    case 6:
    case 7:
    {
        Write("выходной");
        break;
    }
    default:
    {
        Write("не выходной");
        break;
    }


}