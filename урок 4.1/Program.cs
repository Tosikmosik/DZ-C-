// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponent(int numberA, int numberB)
{
    int result = 1;
    int i = 1;
    while (i <= numberB)
    {
        result = result * numberA;
        i++;
    }
    return result;
}
int result = Exponent(number1, number2);
Console.WriteLine($"Ответ: {result}");