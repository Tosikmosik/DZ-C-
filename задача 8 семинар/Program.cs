// string NumberFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }
// string NumberRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumberRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine(NumberFor(1, 10));
// Console.WriteLine(NumberRec(1, 10));

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(11));