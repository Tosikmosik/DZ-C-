// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> не
int number = new Random().Next(1, 8);
if (number >= 6)
{
    Console.WriteLine($"{number} - Да");
}
else if (number <= 5)
{

    Console.WriteLine($"{number} - НЕТ");
}
