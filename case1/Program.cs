/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

using System.Net.WebSockets;

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = 2 * i + j;
}

void ChangeArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int s = array[0, j];
        array[0, j] = array[array.GetLength(0) -1, j];
        array[array.GetLength(0) -1, j] = s;
    }
}       
            
void Print2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}        

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столцов: ");

int[,] myArray = Create2DArray(rows, columns);

Fill2DArray(myArray);
Print2DArray(myArray);
ChangeArray(myArray);
Print2DArray(myArray);