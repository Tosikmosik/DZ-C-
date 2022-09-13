Console.Clear();
Console.WriteLine("Введите число ");
Console.Write("x: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
void Cub(int num1, int count1)
{
    while (count1 <= num1)
    {
        Console.WriteLine($"{count1} . {count1 * count1 * count1}");
        count1++;
    }
}
Cub(num, count);










// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int numcub = num * num * num;
// Console.WriteLine(numcub);