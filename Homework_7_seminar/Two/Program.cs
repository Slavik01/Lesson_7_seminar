// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите строку: ");
int rows = Int32.Parse(Console.ReadLine());
Console.Write("Введите столбец: ");
int columns = Int32.Parse(Console.ReadLine());
int rowsTest = 0; // индекс на 1 всегда больше 
int columnsTest = 0;// размер таблици 3 на 3 будет 0 1 2 
int [,] matrix = new int[rows,columns];  // при 10,10 переменные не нужны
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j] + "\t");
        if (rowsTest == i && columnsTest == j) // сравниваем с элементом строки и столбца
        {
            Console.Write($"Числа найденны: строчка {rowsTest}, столбец {columnsTest}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Элемента нет");
        }
    }

    Console.WriteLine();
}