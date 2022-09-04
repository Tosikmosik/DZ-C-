Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b){
    Console.WriteLine($"Большее число - {a}");
    Console.WriteLine($"меньшее число - {b}");
}
else if (b > a){
    Console.WriteLine($"Большее число - {b}" );
    Console.WriteLine($"меньшее число - {a}");
}
else{
    Console.Write("Они равны");
}