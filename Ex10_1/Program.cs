﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string str = Convert.ToString(num);
        Console.WriteLine("Вторая цифра введенного числа: " + str[1]);
    }
}