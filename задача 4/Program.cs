// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 & num < 6)
{
    Console.WriteLine("Нет");
}
else if (num <= 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}
