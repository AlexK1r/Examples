//**********************************************************************************************************
// Задача 17
//Программа которая на вход принимает координаты точки (X и Y) причем X и Y не равны 0 и выдает номер четверти
//**********************************************************************************************************

// Console.Clear();
// Console.WriteLine("Введите координаты точек X и Y ");
// Console.Write("Введите X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x == 0 && y == 0) Console.WriteLine("точка на оси координат");
// if (x > 0 && y > 0) Console.WriteLine("координата 1 четверти");
// if (x < 0 && y > 0) Console.WriteLine("координата 2 четверти");
// if (x < 0 && y < 0) Console.WriteLine("координата 3 четверти");
// if (x > 0 && y < 0) Console.WriteLine("координата 4 четверти");

//**********************************************************************************************************
//Задача 18
// Программа котора по номеру четверти показывает диапазон возможных координат
//**********************************************************************************************************

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 1 || num > 4) Console.WriteLine("такой четверти нет");
// if (num == 1) Console.WriteLine("координата в диапазоне x > 0, y > 0");
// if (num == 2) Console.WriteLine("координата в диапазоне x < 0, Y от y > 0");
// if (num == 3) Console.WriteLine("координата в диапазоне x < 0, y < 0");
// if (num == 4) Console.WriteLine("координата в диапазоне x > 0, y < 0");


//**********************************************************************************************************
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//**********************************************************************************************************

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num3 = num / 10 % 10;
int num4 = num % 10;

if (num1 == num4 && num2 == num3) Console.WriteLine("это палиндром");
else Console.WriteLine("это не палиндром");

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[5];
// int num = number;
// int d = 100000;
// for (int i = 0; i < arr.Length; i++)
// {
//    int m = 0;
//    d /= 10;
//    arr[i] = number / d;
//    m = number / d;
//    number -= (m * d);
// }

// void selectionSort2(int[] array) //Разворот массива
// {
//     int j = array.Length;
//     for (int i = 0; i < j / 2; i++)
//     {
//       int temporary = array[i];
//       array[i] = array[j - 1];
//       array[j - 1] = temporary;
//        j--;
//     }
// }

// selectionSort2(arr);

// string temp = "";
// for (int i = 0; i < arr.Length; i++)
//             temp += arr[i].ToString();
// int s = Convert.ToInt32(temp);

// Console.WriteLine(s);
// Console.WriteLine(number);


//**********************************************************************************************************
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//**********************************************************************************************************

// Console.Clear();
// Console.WriteLine("Введите координаты точек A(x,y,z), B(x,y,z):");
// Console.Write("Введите xa: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ya: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите za: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите xb: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите yb: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите zb: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// double distance = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
// Console.Write($"Растояние между точек А и Б = {Math.Round(distance, 2)}");

//**********************************************************************************************************
//Задача 22
// принимает на вход число и выдает таблицу квадратов чисел
//**********************************************************************************************************

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i < number + 1 ; i++)
// {
//    Console.Write($"{i*i} ");
// }

//*****************************************************************************************************
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//**********************************************************************************************************

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < number + 1 ; i++)
// {
//    Console.Write($"{Math.Pow(i, 3)} ");
// }


//**********************************************************************************************************
//запись в массив
//**********************************************************************************************************

// char s = Console.ReadLine();
           
//             char[] dig_mas = new char[s.Length]; 
//             for (int i = 0; i < s.Length; i++)
//             {
//                 dig_mas[i] = s[i];
//                 Console.WriteLine(dig_mas[i]);
 
//             }
//             Console.ReadLine();