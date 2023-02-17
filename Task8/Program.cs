/// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
/// Первые два элемента последовательности задаются пользователем

void Print(int a, int b, int num)
{
    int temporary = 0;
    int i=0;
    if (num > 0)
    {
        Console.Write(a + b + " ");
        temporary = a;
        a =b;
        b =b + temporary;
        Print(a, b, num -= 1);
    }
}

Console.WriteLine("Введите первое число последовательности");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите  второе число последовательности");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество чисел, которое нужно отобразить");
int num = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
int temp = 0;

Print(a, b, num);