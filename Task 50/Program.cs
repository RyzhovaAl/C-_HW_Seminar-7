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

// void FindNumber(int[,] inArray, int n)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if(inArray[i, j] == n)
//             {
//                 Console.Write($"Искомое в массиве число {n} находится по адресу {i} строка, {j} столбец\t ");
//                 break;
//             }
//             Console.WriteLine(); 
//         }
//     }
//     Console.Write($"Искомого числа {n} в массиве нет");
// }

void FindNumber(int[,] inArray, int n)
{
    int i = 0;
    int j = 0;
    while (i < inArray.GetLength(0) && j < inArray.GetLength(1))
    {
        if(inArray [i, j] == n)
        {
            Console.WriteLine($"Искомое в массиве число {n} находится по адресу {i} строка, {j} столбец\t ");
            i++;
            j++; 
        }
        else
        {
            Console.Write($"Искомого числа {n} в массиве нет");
            break;
        }
    }
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое в массиве число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
FindNumber(array, num);
