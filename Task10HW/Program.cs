﻿/*
На ввод принимается трехзначное число и на выходе вторая цифра этого числа.
*/

Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n/100; //первое число в трехзначном.
int n3 = n%10; //третье число в трехзначном.

int n2 = (n - n1*100 - n3); // второе число с десятком.

if (n2 != 0)
 
Console.WriteLine($"Второе число: {n2 = n2/10}");

else

Console.WriteLine("Второе число: 0");