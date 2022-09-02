﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine($"Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}.");
double[,] array = new double[m, n];

void CreateArray(double[,] array)
{
    Random random = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array[i, j] = random.NextDouble() * 100; 
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}

CreateArray(array);
