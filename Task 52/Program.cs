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

double GetSumColumns(int [,] massive)
{
   for (int i = 0; i < massive.GetLength(0); i++)
        Console.WriteLine(string.Join("\t", massive));

        double average = Enumerable.Range(0, massive.GetLength(1).Select)
}

//Печатаем матрицу в консоль
            for (int i = 0; i < N; i++)
                Console.WriteLine(string.Join("\t", massive));
 
            //Находим среднее арифметическое столбцов
            var result = Enumerable.Range(0, M).Select(x => matrix.GetColumn(x).Sum() / M);
 
            //Печатаем среднее арифметическое под соответствующим столбцом (округление к меньшему по модулю)
            Console.WriteLine();
            Console.WriteLine(string.Join("\t", result));
 
            Console.ReadKey(true);
for (j = 0; j < n; j++) { b[j] = 0; for (i = 0; i < m; i++) b[j] += a[i][j]; b[j] = b[j] / m; }



Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Среднее арифметическое столбцов равно {GetSumColumns(array)}");
