//// Показать натуральные числа от N до 1, N задано

Console.WriteLine("Введите первое натуральное число в ряду: ");
int Num = 1;
int Num2 = int.Parse(Console.ReadLine() ?? "");

string NumbersLength(int Num2, int Num)
{
    if (Num2 >= Num)
    {
        return $"{Num2} " + NumbersLength(Num2-1, Num);
    }
    else
    {
        return String.Empty;
    }
}

Console.WriteLine(NumbersLength(Num2, Num));