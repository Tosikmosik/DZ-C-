Console.Clear();
void Number(int num)
{
    while (num > 99999 || num <= 9999)
    {
        Console.WriteLine("Ввели не верное число:");
        Console.WriteLine("Введите пятизначное число");
        num = Convert.ToInt32(Console.ReadLine());
    }
    int num1 = num % 10;
    int num2 = num / 10 % 10;
    int num4 = num / 1000 % 10;
    int num5 = num / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является полиндропом");
        }
        else Console.WriteLine("Число не является полиндропом");
    }
    else Console.WriteLine("Число не является полиндропом");
}
Console.WriteLine("Ввести пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

Number(num);

