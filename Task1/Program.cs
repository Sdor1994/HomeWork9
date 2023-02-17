//// Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите последнее натуральное число в ряду: ");
int Num = 1;
int Num2 = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int Num, int Num2)
{
    if (Num < Num2)
    {
        return $"{Num} " + NumbersLength(Num+1, Num2);
    }
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(NumbersLength(Num, Num2));