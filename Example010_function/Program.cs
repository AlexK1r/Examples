// f(x)= x^2 + 1 можно написать следующим образом:
//
// double f(bouble x) возвращаемый тип имя функции(возвращаемый тип аргумента аргумент)
// {
// double result =x * x + 1;             // тело функции (метода)
// return result;                        // возвращаемое значение
// }

//Найти максимальное значение из 9 чисел при помощи функции.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15,  b1 = 21,  c1 = 39;
int a2 = 43,  b2 = 255, c2 = 152;
int a3 = 456, b3 = 5,   c3 = 23;

//int max1 = Max(a1, b1, c1);  //здесь вызывается функция Мах. В аргументы записываются значения переменных a1, b1, c1. 
//int max2 = Max(a2, b2, c2);  //Результат вычисления функции возвращается и записывается в переменную max
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

//А можно так...
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3));

Console.WriteLine(max);