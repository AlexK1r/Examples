/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Clear();

//Записываем числа в массив
Console.WriteLine("Введите четыре числа (последнее число для Задачи 8): ");
int[] massive = new int[4];
for (int i = 0; i < massive.Length ; i++) massive[i] = Convert.ToInt32(Console.ReadLine());

int A = massive [0], B = massive [1];

Console.WriteLine("Ответ на Задачу 2 (сравнение двух чисел)");

if (A > B) Console.WriteLine("Первое число больше второго");
    else Console.WriteLine("Второе число больше первого");

Console.WriteLine();


/*Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int max = massive [0];
for (int j = 0; j < 3; j++) if (massive[j] > max) max = massive [j];

Console.WriteLine("Ответ на Задачу 4 (Нахождение максимального числа)");
Console.WriteLine($"Максимальным числом среди введенных является число: {max}");
Console.WriteLine();


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Ответ на Задачу 6 (определение четного числа)");
for (int j = 0; j < 3; j++) 
 {
    if (massive[j] % 2 ==0) Console.WriteLine($"Число {massive[j]} является четным");
        else Console.WriteLine($"Число {massive[j]} является нечетным");
 }

Console.WriteLine();

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Ответ на Задачу 8 (показать все четные числа от числа N)");

for (int j = massive[3]; j > 0; j--) 
 {
    if (j % 2 == 0 && j > 2) Console.Write($"{j}, ");
        else if (j % 2 == 0) Console.Write($"{j}");
 }