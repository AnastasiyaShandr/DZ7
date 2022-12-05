// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

Console.Write("Введите первый индекс искомого элемента: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второй индекс искомого элемента: ");
int y = int.Parse(Console.ReadLine());

if (x <= rows && y <= columns && x >= 0 && y >= 0)
{
    Console.WriteLine($"Искомым элементом является число: {array[x, y]}");
}
else
{
Console.WriteLine($"Числа с вводимыми индексами в массиве нет");
}


