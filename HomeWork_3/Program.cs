//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 1000;
int num2 = number % 100;
if (num1 == num2) Console.WriteLine("введеное число является палиндромом");
else Console.WriteLine("введеное число не является палиндромом");
Console.WriteLine();
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точек A(x,y,z), B(x,y,z):");
Console.Write("Введите xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

Console.Clear();
double distance = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
Console.Write($"Растояние между точек А и Б = {distance - distance % 0.01}");

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < number +1 ; i++)
{
   Console.Write($"{Math.Pow(i, 3)} ");
}
*/