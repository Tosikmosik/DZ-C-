// Задача 1: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// int InputNumber(string msg)
// {
//     Console.WriteLine(msg);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int Count(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         number = number / 10;
//         result++;
//     }
//     return result;
// }
// int n = InputNumber("Введите чило: ");
// int result = Count(n);
// Console.WriteLine($"{result}");

// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int N = Convert.ToInt32(Console.ReadLine());
// int multiply = 1;
// for (int i = 1; i <= N; i++)
// {
//     multiply = multiply * i;
// }
// Console.WriteLine($"ФАкториал____{multiply}");
// Задача с факториалом
// int N = Convert.ToInt32(Console.ReadLine());
// int multiply = 1;
// for (int i = 1; i <= N; i++)
// {
//     multiply = multiply * i;
// }
// Console.WriteLine($"Выводим факториал,   {multiply}");

// Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5
int[] arr = { -1, -2, 3, -54 };
int max = arr[0];
int second_max = arr[1];

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        second_max = max;
        max = arr[i];
    }
    if (second_max < arr[i])
    {
        second_max = arr[i];
    }
}
Console.WriteLine(second_max);
Console.WriteLine(max);
