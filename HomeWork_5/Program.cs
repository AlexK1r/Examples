// 5 й семинар
//решение через строки
// string num = Console.ReadLine(); //работаем так же, как с одномерным массивом
// int dlina = num.Length;

// if (dlina == 5)
// {
//     if(num[0] == num[4] && num[1] == num[3])
//         Console.WriteLine("МЫ нашли Палиндром");
// }

// вар 1 собирать некий массив и потом сравнить элементы
// int x = 
// int i = 0;
// while (x > 0)
// {
//     num[i] = x % 10;
//     x /= 10;
//     i++;
// }

// вар 2 или перевернуть число в цикли и сравнить реультат с заданым числом

// int x = 12345;
// int result = 0;
// while (x > 0)
// {
//     result = result * 10 + x % 10;
//     x /= 10;
// }
// Console.WriteLine(result);

//работа со строками
// string s1 = "C#";
// string s2 = "Python";
// string s3 = s1 + " - " + s2;
// string s4 = string.Concat(s1, s2, s3);
// string s5 = "Java";
// string s6 = "C++";
// string s7 = "JS";

// Console.WriteLine(s3);
// Console.WriteLine(s4);
// Console.WriteLine(s4.Length);
// Console.WriteLine(s4[2] + s4[3] - s4[3]);
// Console.WriteLine($"{s4[2]}{s4[3]}");

// string[] arr = new string[] {s1,s2,s5,s6,s7};
// string s10 = string.Join(" ", arr); //объеденение
// Console.WriteLine(s10);

//Задача 31 Задать массив из 12 элементов, со случайными числами [-9,9] найти сумму отрицательных и положительных чисел.
//Задача 32 поменять знаки числам в массиве  
//Задача 33 определить есть ли заданное число в массиве
void PrintArray(int[] array) // метод выведет массив на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// int sherlok = -5;
// int j = 0;
// int poloj = 0;
// int otric = 0;
// int[] arr = new int[12];                         
// for (int i = 0; i < arr.Length; i++)                       
//     { 
//         arr[i] = new Random().Next(-9,10);
//     }
// PrintArray(arr);

// for (int i = 0; i < arr.Length; i++)                        
//     {     
//         if (arr[i] >= 0)  
//             {poloj = poloj + arr[i];}
//         else if (arr[i] < 0)  
//             {otric = otric + arr[i];}
//         if (sherlok == arr[i])
//            {j = j + 1;}    
//         arr[i] = arr[i] * (-1);
//     }

// Console.WriteLine(poloj);
// Console.WriteLine(otric);
// Console.WriteLine($"Искомое число в массиве найдено {j} раз");
// PrintArray(arr);

// Console.WriteLine();
// Console.WriteLine();

// //Задача 35 задать массив из 123 случ чисел и найте количество элентов которые находятся в диапазоне [10,99]
// int k = 0;
// int[] uno = new int[40];             //сокрощу до сорока иначе вывод длинный и след задачу чтоб решить             
// for (int i = 0; i < uno.Length; i++)                       
//     { 
//         uno[i] = new Random().Next(0,500);
//     }
// PrintArray(uno);

// for (int i = 0; i < uno.Length; i++)                        
//     {     
//         if (uno[i] > 9 && uno[i] < 100)
//            {k = k + 1;}    
//     }

// Console.WriteLine($"Искомое число в массиве найдено {k} раз");
// Console.WriteLine();
// Console.WriteLine();

// //Задача 37 найти произведение пар чисел в массиве (парой считать "первый" и "последний" элемент) Результат в новый массив

// int p = 1;
// int[] uno2 = new int[uno.Length / 2];    //пока не придумал лучшего способа вычислить длинну второго массива. тупость под вечер;)
// for (int i = 0; i < uno.Length / 2; i++)                        
//     {           
//         uno2[i] = uno[i] * uno[uno.Length - p];
//         p++;    
//     }

// PrintArray(uno2);
// Console.WriteLine();
// Console.WriteLine();

// Домашняя работа

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int res = 0;
int[] arr2 = new int[4];                         
for (int i = 0; i < arr2.Length; i++)                       
    { 
        arr2[i] = new Random().Next(100,1000);
    }
Console.WriteLine("Решение задачи 34: ");
PrintArray(arr2);

for (int j = 0; j < arr2.Length; j++) 
 {
    if (arr2[j] % 2 == 0) res++;        
 }

Console.WriteLine(res);
Console.WriteLine();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int res2 = 0;
int[] arr3 = new int[7];                         
for (int i = 0; i < arr3.Length; i++)                       
    { 
        arr3[i] = new Random().Next(-99,100);
    }
Console.WriteLine("Решение задачи 36: ");
PrintArray(arr3);

for (int j = 0; j < arr3.Length; j += 2) 
 {
    res2 += arr3[j];        
 }

Console.WriteLine(res2);
Console.WriteLine();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Решение задачи 38: ");
double min = 0.0;
double max = 0.0;
double[] arr4 = new double[5];                         
for (int i = 0; i < arr4.Length; i++)                       
    { 
        arr4[i] = new Random().Next(-99,100);
        Console.Write($"{arr4[i]} ");
    }    
 for (int j = 0; j < arr4.Length; j++) 
 {
    if (arr4[j] > max) max = arr4[j];
    else if (arr4[j] < min) min = arr4[j];      
 }
Console.WriteLine();
Console.WriteLine($"Ответ: {max - (min)}");
Console.WriteLine();