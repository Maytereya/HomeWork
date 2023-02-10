// Сумма цифр в числе
// число вводится произвольно

Console.Clear();
Console.Write("Input number: ");
string? n = Console.ReadLine();

if (n is not null)
{
int l = n.Length, Sum = 0;
for (int i = 0; i<l; i++)
    Sum += Convert.ToInt32(n[i].ToString());
    
Console.WriteLine($"The summ of digits in a number: {Sum}");
}
else
Console.WriteLine("Nothing entered!");