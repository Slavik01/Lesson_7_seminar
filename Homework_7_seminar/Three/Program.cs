// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:З
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix = new int [2, 3];
double sum = 0;
double result = 0;
for (int i = 0; i < matrix.GetLength(0); i++) // проход по 1 строчке 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] =  new Random().Next(0,11);
        Console.Write(matrix[i,j] + "\t");
        sum += matrix[i,j]; // считает 00 01 02
    }
    result = sum /3; // вынесли из for что бы не делил на каждый индекс 
    sum = 0; // не тянуть на 2 круг значение 
    Console.WriteLine($"Cреднее арефмитическое чисел равна: {result}");
}




// int [,] matrix = new int [3, 3];

// void FillArrayRandomNumbers (int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] =  new Random().Next(0,11);
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// FillArrayRandomNumbers(matrix);


