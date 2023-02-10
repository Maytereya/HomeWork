// задачка по ссылке
//  https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=691

Console.Clear();
Console.Write("Введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение для поиска: ");
int find = Convert.ToInt32(Console.ReadLine()), result = 0;
int [] array = new int[l];

for (int i = 0; i < l; i++)
    array[i] = new Random().Next(0, 3); // [0, 20]

for (int s = 0; s < l; s++)
 {
    if (array[s] == find)
 result++;

 }

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество вхождений числа {find} равно {result}");