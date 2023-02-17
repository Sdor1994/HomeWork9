//// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите начальное и конечное значения числового ряда");
int M = int.Parse(Console.ReadLine() ?? "");
int N = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int M, int N)
{
    if (M <= N)
    {
        return $"{M} " + NumbersLength(M+1, N);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(M, N));