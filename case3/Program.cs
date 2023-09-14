/* Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
        Набор данных                                Частотный массив
    { 1, 9, 9, 0, 2, 8, 0, 9 }                  0 встречается 2 раза
                                                1 встречается 1 раз
                                                2 встречается 1 раз
                                                8 встречается 1 раз
                                                9 встречается 3 раза
    1, 2, 3                                     1 встречается 3 раза
    4, 6, 1                                     2 встречается 2 раз
    2, 1, 6                                     3 встречается 1 раз
                                                4 встречается 1 раз
                                                6 встречается 2 раза */

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

int[] CopyArray(int[,] array)
{
    int[] ar = new int[array.Length];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            ar[index] = array[i, j];
            index++;
        }
    }
    return ar;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void Frequency(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length -1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Число {array[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"Число {array[array.Length -1]} встречается {count} раз");
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
int[] sortArray = CopyArray(myArray);
SortArray(sortArray);
Frequency(sortArray);