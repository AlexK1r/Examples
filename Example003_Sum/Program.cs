//сумма двух целых чисел
//Console.WriteLine("введите первое число");
//int numberA = Int32.Parse(Console.ReadLine());
int numberA = new Random().Next(1,10); //значения будет от 1 до 9 т.к. значение max-1
Console.WriteLine(numberA);
//Console.WriteLine("введите втрое число");
//int numberB = Int32.Parse(Console.ReadLine());
int numberB = new Random().Next(1,15);
Console.WriteLine(numberB);
int sum = numberA + numberB;
Console.WriteLine(sum);