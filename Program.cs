﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <= 5)
{
    Console.WriteLine("Нет, день рабочий.");
}
else if (n >= 6 && n <= 7)
{
    Console.WriteLine("Да, день выходной.");
}
else
{
    Console.WriteLine("Неверный ввод");
}