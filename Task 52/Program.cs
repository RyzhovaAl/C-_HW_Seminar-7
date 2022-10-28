// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double GetSumColumns(int[,] massive)
// {
//    double[] result = new double[massive.GetLength(1)]; 
//    double average = 0;
//    int sum = 0;
//    int i = 0;
//    int j = 0;
//    while(j <massive.GetLength(0))
//    {
//         while(i < massive.GetLength(0))
//         {
//             sum = sum + massive[i, j];
//             i++;
//             average = sum / massive.GetLength(0);
//             {
//                 result[massive.GetLength(1)] = average; 
//                 Console.WriteLine(String.Join(", " , result));
//             }
//         }
//         j++; 
//     }
//     return result[massive.GetLength(1)];
// }
{
    int sum = 0;
    double average = 0;
    int i = 0;
    int j = 0;
    while (i < massive.GetLength(0))
        {
            sum = sum + massive[i, j];
            i++;
            average = sum / massive.GetLength(0);
        }
        return average;
}




Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое столбцов равно {GetSumColumns(array):f2}");
