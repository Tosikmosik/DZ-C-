// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.


int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void Printmatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],2} ");
            else Console.Write($"{matr[i, j],2}");
        }
        Console.WriteLine("|");
    }
}

int[] SearchSum(int[,] matr)
{
    int[] arrayResultSum = new int[matr.GetLength(1)];
    int columnsSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        columnsSum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            columnsSum += matr[i, j];
        }
        arrayResultSum[i] = columnsSum;
    }
    return arrayResultSum;
}

void SearchMin(int[] array)
{
    int min = array[0];
    int indexmin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexmin = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexmin + 1} строка.");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Сумма {i + 1} строки равна {array[i],2} ");
    }
}

int[,] matrix = CreateMatrix(4, 4, 1, 10);
Printmatrix(matrix);
Console.WriteLine();
int[] array = SearchSum(matrix);
PrintArray(array);
SearchMin(array);