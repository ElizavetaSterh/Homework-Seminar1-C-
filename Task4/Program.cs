﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// вводим три числа
// сравниваем
// выводим максимальное

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int a = number1;
int b = number2;
int c = number3;
int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
Console.Write("max= ");
Console.WriteLine(max);

