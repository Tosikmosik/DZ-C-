// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();
int[] arr = new int[8];

void ArrEight(int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = new Random().Next(0, 29);
    }
}
void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr1[i]},");
        else
            Console.Write($"{arr1[i]}");
    }

    Console.Write("]");
}
ArrEight(arr);
PrintArray(arr);