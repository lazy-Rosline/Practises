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
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    {
        Write("не выходной");
        break;
    }

    default:
    {
        Write("нет такого дня недели");
        break;
    }
}