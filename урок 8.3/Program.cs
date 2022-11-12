﻿// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],2} ");
            else Console.Write($"{matr[i, j],2}");
        }
        Console.WriteLine("");
    }
}

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matrix = new int[matr2.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr1.GetLength(0))
    {
        Console.WriteLine($"Произвести расчёт невозможно!");
    }
    else
    {
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                for (int k = 0; k < matr2.GetLength(0); k++)
                {
                    matrix[i, j] += matr1[i, k] * matr2[k, j];
                }
            }
        }
    }
    return matrix;
}

int[,] matrix1 = CreateMatrix(2, 2, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(2, 2, 1, 9);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] result = MultiplicationMatrix(matrix1, matrix2);
PrintMatrix(result);