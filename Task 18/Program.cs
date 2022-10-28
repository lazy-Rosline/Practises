using System;
using static System.Console;

Clear();
Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());  
if(number==1) 
{
    WriteLine("--> x>0; y>0");
}
if(number==2) 
{
    WriteLine("--> x<0; y>0");
}
if(number==3) 
{
    WriteLine("--> x<0; y<0");
}
if(number==4) 
{
    WriteLine("--> x>0; y<0");
}