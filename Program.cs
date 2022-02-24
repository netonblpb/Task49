// Показать двумерный массив размером m×n, заполненный вещественными числами.

Console.Clear();
Random rnd = new Random();
Console.Write("Задайте размер по Х: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте размер по Y: ");
int n = int.Parse(Console.ReadLine());
double[,] array = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(10, 100) + rnd.NextDouble();
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}