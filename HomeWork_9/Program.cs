// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.Write("Задача 64: ");
int RecursMetod(int N)
{
    if (N == 0) return 0;
    
    Console.Write(N + " ");
    return RecursMetod(N - 1);
}
RecursMetod(10);
Console.WriteLine();
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("\nЗадача 66: ");
int SummRecursMetod(int a, int b)
{
    if (a == b) return b; 
        else return a + SummRecursMetod(a + 1, b);
}
//Задайте числа здесь
int a = 2;
int b = 2;

Console.WriteLine($"M = {a}, N = {b} -> {SummRecursMetod(a , b)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("\nЗадача 68: ");
int AkkermanRecursMetod(int m, int n)
{
    if (m == 0) return n + 1; 
        else if ((m != 0) && (n == 0)) return AkkermanRecursMetod(m - 1, 1);
            else return AkkermanRecursMetod(m - 1, AkkermanRecursMetod(m, n - 1));
}
//Задайте числа здесь (если m больше 2 будет переполнение стека)
int m = 2;
int n = 7;

Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {AkkermanRecursMetod(m , n)}\n");