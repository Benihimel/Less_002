﻿// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
    Console.WriteLine($"Third digit of number: {number % 10}");
else
    Console.WriteLine("Third digit of number: NULL");