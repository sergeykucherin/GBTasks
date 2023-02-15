// Программа, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
using static System.Console;
Clear();
Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int n = -a;

while (n <= a)
{
    Write($" {n} ");
    n = n + 1;
}
