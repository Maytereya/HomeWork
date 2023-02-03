/*
Выводится третья цифра заданного числа или сообщается, что третьей цифры нет.
Число с любым количеством знаков.
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 999)

{ 
    n = n/10;
Console.Write($"{n} "); //проверка корректности работы цикла

}

if (n > 99)

    Console.WriteLine($"; третье число: {n%10}");

else 
    Console.WriteLine("Третьего числа нет");