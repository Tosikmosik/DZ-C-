int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'y' координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'z' координату первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'y' координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'z' координату первой точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Dlin(int xa, int ya, int xb, int yb, int za, int zb)
{
    double minusx = xb - xa;
    double minusy = yb - ya;
    double minusz = zb - za;
    minusx *= minusx;
    minusy *= minusy;
    minusz *= minusz;
    double res = minusx + minusy + minusz;
    return Math.Sqrt(res);
}
double result = Dlin(x1, y1, x2, y2, z1, z2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));