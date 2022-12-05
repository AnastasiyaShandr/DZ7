// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, -20, 20);
PrintArray(array);
Console.WriteLine();
AverageColumns(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void AverageColumns(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        Console.Write($"{sum / inArray.GetLength(0):f2} ");
    }
    Console.WriteLine();
}


