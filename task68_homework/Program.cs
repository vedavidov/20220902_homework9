// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.WriteLine("Введите M: ");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int end = int.Parse(Console.ReadLine());

Console.Write($"Значение функции Аккермана для чисел ({start}, {end}) = ");
Console.WriteLine(PrintFunction(start, end));

int PrintFunction(int start, int end)
{
    if (start == 0) return end + 1;
    if (start != 0 && end == 0) return PrintFunction(start - 1, 1);
    if (start > 0 && end > 0) return PrintFunction(start - 1, PrintFunction(start, end - 1));
    return PrintFunction(start, end);
}