//// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите начальное и конечное значения числового ряда");
int M = int.Parse(Console.ReadLine() ?? "");
int N = int.Parse(Console.ReadLine() ?? "");

int SumNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    else
    {
        return M + SumNumbers(M + 1, N);
    }
}
Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumNumbers(M, N)}");