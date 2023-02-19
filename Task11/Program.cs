// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

using static System.Console;
Clear();

int number1 = new Random() .Next(10, 101);
int number2 = new Random() .Next(1, 11);
WriteLine(number1);
WriteLine(number2);
int result = number1 % number2;
WriteLine(number1 % number2 == 0 ? "Even" : $" {result} ");
