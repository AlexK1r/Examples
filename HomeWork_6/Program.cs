// Домашняя работа

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void Array(int[] arr)                            
// {
//     int length = arr.Length;
//     int temp = 0;                         
//     for (int i = 0; i < length; i++)                        
//        { 
//         Console.Write($"Введите число {i+1}: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
        
//         if (arr[i] > 0) temp++;
//        }
//     Console.Write($"Среди введеных чисел {temp} больше ноля. \n");
// }

// Console.Write($"Введите восемь чисел: \n");
// int[] array = new int[8];
// Array(array);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y-y = k1*x + b1 - (k2 * x + b2)  =>>  0 = k1*x + b1 - k2 * x - b2  =>> 0 = x*(k1 - k2) + b1 - b2  =>>
// x*(k1 - k2) = b2 - b1  =>> x = (b2 - b1) / (k1 - k2)


Console.Write("Ищем точку пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("\nВведите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double tempX = (b2 - b1) / (k1 - k2);
double tempY = k1 * tempX + b1;

Console.Write($"\nПересечение будет в точке ({tempX}, {tempY}). \n");









//двумерные массивы
// int[] n = {1, 2, 3, 4, 5, 6};
// int[,] n2 = {{1, 2, 3, 7},
//              {4, 5, 6, 8}}; //двухмерный массив
// //int[,] n2;
// //int[,,] n3 = new int[2, 4, 3] //трехмерный

// for (int i = 0; i < n2.GetLength(0); i++)
// {
//     for (int j = 0; j < n2.GetLength(1); j++)
//     {
//         Console.Write($"{n2[i, j]} ");
//     }
//     Console.WriteLine();
// }

// // Задача 39 перевернуть одномерный массив
// int t = 0;
// int[] arr = {1, 2, 3, 4, 5, 6};
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     t = arr[i];
//     arr[i] = arr[arr.Length -1 - i];
//     arr[arr.Length - 1 - i] = t;
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }
// Console.WriteLine();

// // Задача 40 принять на вход три числа и проверить, может ли существ-ть треугольник со сторонами такой длинны.

// int[] arr2 = new int[3];                         
// for (int i = 0; i < arr2.Length; i++)                       
//     { 
//         arr2[i] = new Random().Next(1,21);
//     }
// for (int i = 0; i < arr2.Length; i++)
// {
//     Console.Write($"{arr2[i]} ");
// }
// if (arr2[0] + arr2[1] > arr2[2] && arr2[1] + arr2[2] > arr2[0] && arr2[0] + arr2[2] > arr2[1]) Console.Write("треугольник возможен");
// else Console.Write("треугольник НЕ возможен");
// Console.WriteLine();

// // Задача 42 преобразовать десятичное число в двоичное

// Console.Write("Введите число: ");
// double number = Convert.ToDouble(Console.ReadLine());

// while (number > 0)
// {
//     number = number / 2;
//     Console.Write(number);
// }




