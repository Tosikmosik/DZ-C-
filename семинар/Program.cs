Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.Read());

int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

