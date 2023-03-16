// Задача 15: Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5 && number < 8)
    Console.WriteLine("Yes, Day off");
else if (0 < number && number < 6)
    Console.WriteLine("No, Weekdays");
else
    Console.WriteLine("Incorrect number");

