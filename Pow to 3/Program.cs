// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static System.Console;
Clear();

WriteLine("Введите положительное число N");
int N = int.Parse(ReadLine()!);

if (N < 1)
{
    WriteLine("Число меньше 1");
    return;
}

for (int i=1; i<=N; i++)
{
    Write($"{Math.Pow(i,3)}, ");
}