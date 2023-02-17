//// Найти сумму цифр числа


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");
int SumNumbers(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumNumbers(num / 10);
    }
}
Console.WriteLine(SumNumbers(num));