// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Ведите число: ");
int num = new Random().Next(0, 7);
Console.WriteLine(num);
if (num >= 6)
{
    Console.WriteLine("Это выходной");
}
else if (num <= 5)
{
    Console.WriteLine("Это не выходной");
}