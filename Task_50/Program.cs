// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Write("Введите m - число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n - число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

newArray(array);
FindByIndex(array, a, b);

void newArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
    for (int j = 0; j < m; j++)
    {
        array[i, j] = random.Next(10);
        Console.Write("{0}" + " ", array[i, j]);
    }
    Console.WriteLine();
    }
}

int FindByIndex(int [,] array, int a, int b)
{
    if (array.GetLength(0)>a && array.GetLength(1)>b) 
    {
        int result = array [a,b];
        Console.WriteLine($"Значение элемента с индексом ({a},{b}): {result}");
        return result;
    }
    else 
    {
        Console.WriteLine("Такого числа в массиве нет");
        return -1;
    }
}