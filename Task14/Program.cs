// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using static System.Console;
Clear();

int number1 = new Random() .Next(1, 101);
int number2 = new Random() .Next(1, 101);
//int number1 = 9;
//int number2 = 84;
WriteLine(number1);
WriteLine(number2);
WriteLine(number1 / number2 == number2 ? number1 % number2 == 0 : "False" );
WriteLine(number2 / number1 == number1 ? number2 % number1 == 0 : "False" );
//WriteLine(number1 / number2 == number2 ? "number2 квадрат number1"
        //: number2 / number1 == number1 ? "number1 квадрат number2" : "не являются квадратами друг друга" );
