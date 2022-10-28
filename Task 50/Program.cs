// Задача 50. Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
    Console.WriteLine();
    }
}

void FindNum(int[,] inArray, int n)
{
    int i = 0;
    int j = 0;
    while (i < inArray.GetLength(0) && j < inArray.GetLength(1))
    {
        if(inArray[i, j] != n)
        {
            i++;
            j++;
        }
        else if(inArray[i, j] == n)
        {
            Console.WriteLine($"Искомое число {n} в массиве находится в {i} строке и {j} столбце");
        }
        else 
        {
            Console.WriteLine($"Искомого числа {n} в массиве нет");
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое в массиве число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
FindNum(array, number);
