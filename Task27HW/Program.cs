// Сумма цифр в числе
Console.Clear();
Console.Write("Input number: ");
string? n = Console.ReadLine();
int l = n.Length, Sum = 0;

if (n is not null)
{
for (int i = 0; i<l; i++)
    Sum += Convert.ToInt32(n[i].ToString());
    
Console.WriteLine($"The summ of digits in a number: {Sum}");
}
else
Console.WriteLine("Nothing entered!");