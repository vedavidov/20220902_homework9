// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите M: ");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine($"Все натуральные числа в промежутке от {start} до {end}: ");
Console.WriteLine(PrintNumber(start, end));

string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumber(start + 1, end));
}