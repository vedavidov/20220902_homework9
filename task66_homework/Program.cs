// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Решать методом рекурсии.

Console.WriteLine("Введите M:");
int start = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N :");
int end = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {start} до {end}: ");

void PrintSum(int start, int end, int sum)
{
    if (start > end)
    {
        Console.Write(sum);
        return;
    }
    sum = sum + (start++);
    PrintSum(start, end, sum);
}
PrintSum(start, end, 0);