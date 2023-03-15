// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (1000 > num && num > 99)
    Console.Write($"Third digit of number: {num % 100 / 10}");
else
    Console.Write("Error. Try again");

