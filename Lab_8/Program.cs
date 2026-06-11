Stack<int> stack = new Stack<int>();
int n = new Random().Next(10, 20);
for (int i = 0; i < n; i++)
{
    stack.Push(new Random().Next(10, 100));
}

foreach (int i in stack) Console.Write(i + " ");
Console.WriteLine();
double s = 0;
foreach (int i in stack) if (i % 2 == 0) s += i;
Console.WriteLine($"Avg={(s / stack.Count):F2}");
