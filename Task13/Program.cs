// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using static System.Console;
Clear();

int number = new Random() .Next(161, 645);
//int number = 644;
WriteLine(number);
WriteLine(number % 7 == 0 ? number % 23 == 0 : "False" );
