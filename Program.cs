﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input a ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 < num2) Console.Write($"a = {num1}; b = {num2}-> max = {num2} ");
// if (num1 > num2) Console.Write($"a = {num1}; b = {num2}-> max = {num1} ");
// if (num1 == num2) Console.Write($"a = {num1}; b = {num2}-> num2 = num1 ");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("input a ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input b ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input c ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
//  Console.Write($"a = {num1}; b = {num2}; c = {num3} -> max = {max} ");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Input(введите) a ");
// int num1 = Convert.ToInt32(Console.ReadLine()); //32бит int(целые числа)  ReadLine -готов считать с переходом на новую строку
// if ( num1 % 2 == 0 ) 
// Console.Write($" a = {num1} -> чётное "); 
// else Console.Write($" a = {num1} -> нечётное ");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Input(введите) n ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ($" {num1} -> ");
int count = 2;
while (count <= num1) 
{
    Console.Write ($"{count}, " ); 
    count = count + 2;
}


