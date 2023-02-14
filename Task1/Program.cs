using static System.Console;

WriteLine("Является или нет число a квадратом чиcла b");
Write("Введите число a:  ");
int a = int.Parse(ReadLine());
Write("Введите число b:  ");
int b = int.Parse(ReadLine());
if (a == b*b)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
