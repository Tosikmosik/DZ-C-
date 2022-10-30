// Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value = value / 10;
    }
    return result;
}
int result = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}");