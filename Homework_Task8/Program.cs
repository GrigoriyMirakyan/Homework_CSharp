﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = a; i >= 1; i--)
{
    if (i % 2 != 0) { } else Console.Write(i); Console.Write(" ");
}