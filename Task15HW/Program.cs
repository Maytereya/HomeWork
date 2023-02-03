/*
На вход цифра, обозначающая день недели. 
Проверить, является ли этот день выходным.
*/

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)

{ 
Console.Write("Вы ошиблись,\n введите число от 1 до 7: ");
n = Convert.ToInt32(Console.ReadLine());

}

if (n > 0 && n < 6)
Console.WriteLine("День не является выходным");
else if (n == 6)
Console.WriteLine("Суббота, выходной день");
else
Console.WriteLine("Воскресенье, выходной день");
