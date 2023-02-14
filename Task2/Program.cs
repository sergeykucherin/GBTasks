using static System.Console;

WriteLine("Какой это день недели?");

Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a == 1)
{
    Write("Понедельник");
    }
else if (a == 2)
{
    Write("Вторник");
    }
    else if (a == 3)
    {
        Write("Среда");
        }
        else if (a == 4)
        {
            Write("Четверг");
            }
            else if (a == 5)
            {
                Write("Пятница");
                }
                else if (a == 6)
                {
                    Write("Cуббота");
                    }
                    else if (a == 7)
                    {
                        Write("Воскресенье");
                        }
else
{
    Write("Введено неверное число и дня недели не существует");
}                        