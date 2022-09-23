// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static System.Console;

Clear();

WriteLine("Введите пятизначное число:");
int number = int.Parse(ReadLine()!);

if (number < 10000 || number > 99999)
{
    WriteLine("Это не пятизначное число:");
    return;
}

if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
{
    WriteLine("Это палиндром");
}
else
{
   WriteLine("Это не палиндром"); 
}