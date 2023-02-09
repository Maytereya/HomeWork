/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("Введите пятизначное число для проверки: ");
int pal = Convert.ToInt32(Console.ReadLine());

int n1 = pal/10000, n2= pal%10000/1000, n4= pal%100/10, n5 = pal%10;

Console.WriteLine($"{n1}_{n2}_|_{n4}_{n5}");

if (n1 == n5 && n2 == n4)
Console.WriteLine($"число {pal} является палиндромом.");
else
Console.WriteLine($"число {pal} не является палиндромом.");
