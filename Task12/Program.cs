// Введите 2 числа, если a>b, то показать знак >; если a<b, то показать знак <, если а=б, то показать знак =

using static System.Console;
Clear();

int number1 = new Random() .Next(1, 11);
int number2 = new Random() .Next(1, 11);
WriteLine(number1);
WriteLine(number2);
//int result = number1 % number2;
WriteLine(number1 > number2 ? ">" : number1 < number2 ? "<" : "=" );
