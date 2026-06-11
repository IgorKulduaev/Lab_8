//Базовый Уровень Вариант 2
using System.Collections.Generic;

Queue<double> queue = new Queue<double>();
Random rng = new Random();
int n = rng.Next(5, 15); 
for (int i = 0; i < n; i++)
{
    double value = Math.Round(rng.NextDouble() * 100 - 50, 2);
    queue.Enqueue(value);
}
Console.WriteLine("Элементы очереди:");
foreach (double item in queue)
{
    Console.Write(item + " ");
}
Console.WriteLine();
int positiveCount = 0;
foreach (double item in queue)
{
    if (item > 0)
    {
        positiveCount++;
    }
}
Console.WriteLine($"Кол-во положительных элементов: {positiveCount}");
