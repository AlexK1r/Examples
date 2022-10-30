// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// string[,] table = new string[2,5];
// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

Console.WriteLine("Решение задачи 47: ");
double[,] arr = new double[3,4];                         
for (int i = 0; i < arr.GetLength(0); i++)                       
    { 
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            //метода для генерации дробных чисел в C# нет, поэтому делаем через деление на дробное
            arr[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0); 
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }    
 

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Решение задачи 50: ");

link1:

Console.WriteLine("Введите номер строки элемента в массиве 4x4: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца элемента в массиве 4x4: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows < 0 || rows > 3 || columns < 0 || columns > 3) 
{   
    Console.WriteLine("Не верный ввод!");
    goto link1;
}

int[,] arr1 = new int[4,4];                         
for (int i = 0; i < arr1.GetLength(0); i++)                       
    { 
        for(int j = 0; j < arr1.GetLength(1); j++)
        {
           arr1[i,j] = new Random().Next(0, 10); 
           Console.Write($"{arr1[i,j]} ");
        }
        Console.WriteLine();
    }
 
Console.WriteLine($"Искомый элемент массива имеет значение: {arr1[rows, columns]}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//использую предидущий массив

for (int j = 0; j < arr1.GetLength(1); j++)                       
    { 
        double Summ = 0;
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            Summ += arr1[i,j];
        }
        Console.WriteLine($"Средне арифметическое столбца {j+1} равна: {Summ/arr1.GetLength(0)}");
    }