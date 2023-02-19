// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа (разные варианты решения).
using static System.Console;
Clear();

int number = new Random() .Next(10, 100);
WriteLine(number);
WriteLine(number / 10 > number % 10 ? number / 10 : number % 10);

//int a1 = number / 10;
//int a2 = number % 10;
//int max = a1 > a2 ? a1 : a2; // знаки ? и : используемые вместо if и else называются тернарным оператором
//WriteLine(max);
//WriteLine(a1 > a2 ? a1 : a2);
// if (a1 > a2)
// {
//   WriteLine(a1);  
// }
// else
// {
//     WriteLine(a2);
// }
// Использование данных операторов для решения домашней задачи на проверку четных чисел:
WriteLine(number);
WriteLine(number % 2 == 0 ? "Even" : "End");
