Console.Clear();

//Программа пренимает число и выдает его квадрат

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Квадрат числа равен {numA * numA}");

if (numA > 5) // Возведение числа A в степень B  - Math.Pow(A,B)
{
    Console.WriteLine($"Введеное число больше 5 Значит число в квадрате: {Math.Pow(numA, 2)}");
}
else 
{
    Console.WriteLine($"Введеное число меньше 5 Значит число в кубе: {Math.Pow(numA, 3)}");
}

/* 
//вступительная часть
int a = 2, b =3;

string name = "Tom";
int age = 23;

//****ВВод с консоли****
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//**********************
//*****вывод************
//***********************
Console.WriteLine("Hello, C#!");

//Форматирование строк
Console.WriteLine("Имя: {0}  Возраст: {1}", name, age); 

//конкатенация строк
Console.WriteLine("Сумма чисел a и b равна " + (a + b + 1) + " " + name + " "+ age);

//интерполяции строк
Console.WriteLine($"Сумма чисел a и b равна {num + b + 1}");  

*/