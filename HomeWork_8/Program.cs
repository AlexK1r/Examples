// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Решение задач 54 и 56: ");
int[,] array = new int[4,4];
int min = -1000;
//int summ = 0;
int numberString = 0;                         
for (int i = 0; i < array.GetLength(0); i++)    //задаем двумерный массив и выводим его                  
    { 
        int summ = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10); 
            Console.Write($"{array[i,j]} ");
            summ += array[i,j];
        }
        if (min == -1000) min = summ;
        if (summ < min) 
        {
            min = summ;
           numberString = i;
        }
        Console.WriteLine();        
    }
   
Console.WriteLine("\n Итог:\n");

int temp = 0;

for (int i = 0; i < array.GetLength(0); i++)    //сортировка в строке от большего к меньшему                  
    {   
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,j] < array[i,k]) 
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    
for (int i = 0; i < array.GetLength(0); i++)      // вывожу полученный массив                 
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        { Console.Write($"{array[i,j]} "); }
        Console.WriteLine();
    }
Console.Write($"наименьшая сумма по строкам = {min}, строка {numberString + 1} \n"); 

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("\nРешение задачи 58: \n");
int[,] arrayA = new int[2,2];
int[,] arrayB = new int[2,2];
int[,] arrayC = new int[2,2];
                         
for (int i = 0; i < arrayA.GetLength(0); i++)    //задаем двумерный массив и выводим его                  
    {        
        for(int j = 0; j < arrayA.GetLength(1); j++)
        {
            arrayA[i,j] = new Random().Next(1, 10);
            Console.Write($"{arrayA[i,j]} ");            
        }
        Console.WriteLine();        
    }
Console.WriteLine();

for (int i = 0; i < arrayB.GetLength(0); i++)    //задаем двумерный массив и выводим его                  
    {        
        for(int j = 0; j < arrayB.GetLength(1); j++)
        {
            arrayB[i,j] = new Random().Next(1, 10); 
            Console.Write($"{arrayB[i,j]} ");           
        }
        Console.WriteLine();        
    }
Console.WriteLine("\nИтог:\n");

for (int i = 0; i < arrayC.GetLength(0); i++)      // вывожу полученный массив                 
    { 
        for(int j = 0; j < arrayC.GetLength(1); j++)
        { 
            if (i == 0 && j == 0) arrayC[i,j] = (arrayA[i,j] * arrayB[i,j]) + (arrayA[i,j+1] * arrayB[i+1,j]);
            else if (i == 0 && j == 1) arrayC[i,j] = (arrayA[i,j-1] * arrayB[i,j]) + (arrayA[i,j] * arrayB[i+1,j]);
            else if (i == 1 && j == 0) arrayC[i,j] = (arrayA[i,j] * arrayB[i-1,j]) + (arrayA[i,j+1] * arrayB[i,j]);
            else if (i == 1 && j == 1) arrayC[i,j] = (arrayA[i,j-1] * arrayB[i-1,j]) + (arrayA[i,j] * arrayB[i,j]);            
                        
        Console.Write($"{arrayC[i,j]} "); }
        Console.WriteLine();
    }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("\n Решение задачи 60: \n");
int[,,] arrayD = new int[2,2,2];
int t = 20;
for (int i = 0; i < arrayD.GetLength(0); i++)    //задаем трехмерный массив                  
    {        
        for(int j = 0; j < arrayD.GetLength(1); j++)
            {            
                for(int k = 0; k < arrayD.GetLength(2); k++)
                    {
                        arrayD[i,j,k] = t;
                        t += 5;                          
                    }                
            }
    }

for (int i = 0; i < arrayD.GetLength(0); i++)    //вывод массива                
    {       
        for(int j = 0; j < arrayD.GetLength(1); j++)
            {
                for(int k = 0; k < arrayD.GetLength(2); k++)
                    {                 
                        Console.Write($"{arrayD[i,j,k]}({i},{j},{k}) ");           
                    }
                Console.WriteLine();
            }        
    }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("\nРешение задачи 62: \n");
//массив, количество строк m, столбцов n.
int m = 4;
int n = 4;

int[,] arrayF = new int[m , n];

int s = 1;

//Заполняем периметр массива против часовой стрелке.
for (int x = 0; x < m; x++) 
    {
        arrayF[x , 0] = s;
        s++;
    }
for (int y = 1; y < n; y++) 
    {
        arrayF[m - 1 , y] = s;
        s++;
    }
for (int x = m - 2; x >= 0; x--) 
    {
        arrayF[x , n - 1] = s;
        s++;
    }
for (int y = n - 2; y >= 1; y--) 
    {
        arrayF[0 , y] = s;
        s++;
    }

//координаты ячейки, которую необходимо заполнить следующей.
int c = 1;
int d = 1;
 
while (s < m * n) 
    {
            //вниз
            while (arrayF[c + 1 , d] == 0) 
            {
                arrayF[c , d] = s;
                s++;
                c++;
            }

            //вправо
            while (arrayF[c , d + 1] == 0) 
            {
                arrayF[c , d] = s;
                s++;
                d++;
            }
 
            //вверх
            while (arrayF[c - 1 , d] == 0) 
            {
                arrayF[c , d] = s;
                s++;
                c--;
            }
 
            //влево
            while (arrayF[c , d - 1] == 0) 
            {
                arrayF[c , d] = s;
                s++;
                d--;
            } 
    }

//Остаётся незаполненная ячейка, убираем циклом.
for (int x = 0; x < m; x++) 
    {
        for (int y = 0; y < n; y++) 
            {
                if (arrayF[x , y] == 0) arrayF[x , y] = s;                
            }
    }

for (int i = 0; i < arrayF.GetLength(0); i++)                  
    {       
        for(int j = 0; j < arrayF.GetLength(1); j++)
            {
                if (arrayF[i,j] < 10) Console.Write("0" + arrayF[i,j] + " "); 
                else Console.Write(arrayF[i,j] + " ");
            }
        Console.WriteLine();
    }        


// 53 задача Задать двумерный массив. Поменять местами первую и последнюю строки массива.

// Console.WriteLine("Решение задачи 53: ");
// int[,] array = new int[4,4];                         
// for (int i = 0; i < array.GetLength(0); i++)    //задаем двумерный массив и выводим его                  
//     { 
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1, 100); 
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }    
// int temp = 0;
// Console.WriteLine();
// for(int j = 0; j < array.GetLength(1); j++) // меняю местами 1 и 4 строки местами через доп переменную
//     {
//         temp = array[0,j];
//         array[0,j] = array[3,j];
//         array[3,j] = temp;
//     }
    
// for (int i = 0; i < array.GetLength(0); i++)      // вывожу полученный массив                 
//     { 
//         for(int j = 0; j < array.GetLength(1); j++)
//         { Console.Write($"{array[i,j]} "); }
//         Console.WriteLine();
//     }

// 55 задача Задать двумерный массив. Заменить строки на столбцы. Если это не возможно вывести сообщение.

// 57 задача Составить частотный словарь элементов двумерного массива.
// Словарь содержит инфу о том, сколько раз встречается элемент входных данных. 

// 59 задача Задать двумерный массив из целых чисел.
// Удалить строку и столбец на пересечение которых есть наименьший элемент массива.

// 61 задача Вывести первые N строк треугольника Паскаля.
// Вывести в виде равнобедренного треугольника.