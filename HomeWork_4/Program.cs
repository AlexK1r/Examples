//                              Урок 4. Функции продолжение

//                                  Домашняя работа ниже под семинарскими задачами

//**********************************************************************************************
// Задача 25: Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
//**********************************************************************************************

// Console.Clear();
// int summation(int A) // функция расчета суммы числа A
// {
//     int s = 0;
//     for (int i = 0; i <= A; i++)
//         s = s + i;      
//     return s;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(summation(num));


//**********************************************************************************************
// Задача 26: Написать программу, которая принимает на вход число и выдает количество цифр в числе.
//**********************************************************************************************

// ВНИМАНИЕ!!! НЕ КОМЕНТИТЬ!!! Функция используется в домашней работе

int FindLengthNum(int number)                    //Функция определяет длинну целого числа
{
         int count = 1;                           //определим для удобства если в числе один знак  
         while (number > 9)                       //пока число в переменной number > 9 будет выполняться скобка
         {
            number /= 10;
            count++;                               //считаем сколько раз выполнили действие начиная с 1 + ... это и будет длинна введеного числа
         }
         return count;
}

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Длинна числа {FindLengthNum(n)} знаков");


//**********************************************************************************************
// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
//**********************************************************************************************

// Console.Clear();
// int multiplication(int N) // функция расчета произведения числа N
// {
//     int s = 1;
//     for (int i = 1; i <= N; i++)
//         s = s * i;      
//     return s;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write(multiplication(num));




//**********************************************************************************************
//**********************************************************************************************
//                                          ДОМАШНЯЯ РАБОТА
//**********************************************************************************************
//**********************************************************************************************

//**********************************************************************************************
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//**********************************************************************************************

Console.Clear();
int A = new Random().Next(1,4);                 //число
int B = new Random().Next(1,6);                 //степень
int res = 1;                                    //итоговая переменная

for (int j =0; j < B; j++)
    res = res * A;
Console.WriteLine("Задача 25: возвести число A в натуральную степень B (числа сгенерированы).");
Console.WriteLine($"Ответ: {A} в степени {B} равно {res} ");

Console.WriteLine();

//**********************************************************************************************
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11   82 -> 10    9012 -> 12
//**********************************************************************************************

// значение длинны числа получаем из функции FindLengthNum()

int summation(int number, int length) // функция расчета суммы цифр числа А
{
    int sum = 0;
    int a = 0;
    int b = 1;
    for (int i = 0; i < length; i++)
    { 
        a = number / b % 10;
        b = b * 10;
        sum = sum + a;      
    }
    return sum;
}

Console.Write("Задача 27: выдаёт сумму цифр в числе. Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int x = FindLengthNum(n);

Console.Write($"Сумма цифр от числа равна: {summation(n, x)}");

Console.WriteLine();
Console.WriteLine();

//**********************************************************************************************
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
//**********************************************************************************************

void FillArray(int[] collection)                            //Функция заполнения массива
{
    int length = collection.Length;                         //запишем в переменную length длинну массива
    for (int i = 0; i < length; i++)                        //пока не достигним конца массива
       { 
        collection[i] = new Random().Next(0,50);
       }
}

void PrintArray(int[] col)                                  //Функция вывод на экран
{
    int count = col.Length;                                 //запишем в переменную count длинну массива
    for (int position = 0; position < count; position++)    //пока не достигним конца массива
        Console.Write($"{col[position]} ");                       //будем последовательно читать элементы массива и выводить на экран
}

int[] array = new int[8];                                   //определяем массив и его размер
FillArray(array);
Console.WriteLine("Задача 29: массив из 8 элементов сгенерирован случайным порядком."); 
Console.WriteLine("Вывод элементов массива на экран:");
PrintArray(array);
Console.WriteLine();

//**********************************************************************************************
// Задача 30: Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке [1,0,1,1,0,1,0,0]
//**********************************************************************************************

//решение этой задачи такое же как и в Задачи 29 только рандом будем делать из 0 и 1

//collection[i] = new Random().Next(0,2);             //будем генерировать случайное число 0 или 1 и последовательно складывать в массив


//**********************************************************************************************
//Семинар

// переворот числа в переменной x
// int x = 1234;
// int a1 = x % 10; //здесь будет 4
// int a2 = x /10 % 10; //здесь будет 3
// int a3 = x / 100 % 10; //здесь будет 2
// int a4 = x / 1000; //здесь будет 1
// x = a1 * 1000 + a2 * 100 + a3 * 10 + a4; // здесь будет 4321
// Console.Write (x == 1); //будет false

//Фукция 1
// void sayHello() //void означает что функция ничего не возвращает, пустые скобки говорят что фукция ничего не принимает
// {
//     Console.Write("Привет С#");
// }
// sayHello(); //вызов функции

//Фукция 2
// void sayHello(string lang) //void означает что функция ничего не возвращает, фукция принимает
// {
//     Console.Write($"Привет {lang}");
// }
// sayHello("японский язык"); //вызов функции
// string name1 = "китайский язык"
// sayHello("name1"); //вызов функции
// string name2 = "монгольский язык"
// sayHello(name2); //вызов функции


//Фукция 3
// int MinMax(int x, int y) //функция возвращает тип данных int, фукция принимает значения двух переменных
// {
//      if (x > y)
//      return x;
//      else
//      return y;
// }
// int max1 = MinMax(5, 3); //вызов функции
// int a1 = 5;
// int a2 = 7;
// int max2 = MinMax(a1, a2);

// Console.Write($"{max1} + {max2} = {max1 + max2}");