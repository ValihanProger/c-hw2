﻿// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    Console.WriteLine($"Вторая цифра числа {number} -> {(number%100)/10}");
}

else
{
    Console.WriteLine("Неправильное число!");
}