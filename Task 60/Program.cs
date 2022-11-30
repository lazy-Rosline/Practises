// Формирует трехмерный массив, и выводит элементы построчно с указанием индекса

using System;

Console.Clear();

void Get3xArray (int par1, int par2, int par3)
{
    int[,,] array = new int[par1, par2, par3];
    for (int i = 0; i < par1; i++)
    {
        for (int j = 0; j < par2; j++)
        {
            for (int k = 0; k < par3; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            continue;
        }
        Console.WriteLine();
    }
}

Get3xArray(3,3,3);

//(не согласна с выводом приведенным в условии задачи, по-моему, даже двухмерный массив - значит кубик, по 4элемента в строке)