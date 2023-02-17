/// Написать программу возведения числа А в целую стень B


Console.WriteLine("Введите число А ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите степень В ");
int b = int.Parse(Console.ReadLine() ?? "");

int Result(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    else
    {
        return Result(a, b - 1) * a;
    }
}
Console.WriteLine($"Число {a} в степени {b} = {Result(a, b)}");