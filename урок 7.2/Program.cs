﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

void SearchDigit(int[,] array, int pos)
{
    int row = pos / 10;
    int column = pos % 10;
    if ((row > 3) || (column > 4)) Console.WriteLine($"{pos} -> такого элемента в массиве нет");
    else Console.WriteLine($"Элемент по этой позиции - {array[row - 1, column - 1]}"); // "- 1" добавлен для более упрощённой проверки наличия элемента 
}

int[,] array2D = CreateMatrixRndInt(3, 4);

PrintMatrix(array2D);

Console.Write($"Введите позицию элемента в массиве: ");
int position = Convert.ToInt32(Console.ReadLine());

SearchDigit(array2D, position);