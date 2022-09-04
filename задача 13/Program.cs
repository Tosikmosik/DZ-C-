// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int final = num % 10;
    Console.WriteLine($"{final} - 3-я цифра числа");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
