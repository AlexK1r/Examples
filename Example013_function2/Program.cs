// группы методов

//Первая группа методов (ни чего не получает на вход и ни чего не передает)
/*
void Metod1()
{
Console.WriteLine("Автор …");
}

Metod1(); //вызов метода


//Вторая группа методов (получает на вход, но ни чего не передает)

void Metod2(string msg)
{
Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}

Metod2("например какойто текст...");

//Можно аргументы именовать и в вызове ставить в любом порядке

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); 
        i++;
    }
}
Metod21("Например текст", 4); //можно так
Metod21(count: 4, msg: "Например текст"); // а можно используя имена аргументов и меняя их последовательность 


//Третья группа методов (ни чего не получает на вход, зато передает)

int Metod3()
{
    return DataTime.Now.Year; // обязательное использование оператора return,
}
int year = Metod3(); //вызываем метод, в левой части используем идентификатор
                     //переменной (year) и через оператор присваивания (=) кладём нужное значение 
Console.WriteLine(year);


//Четвёртая группа методов (получает на вход и передает на выход)

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Metod4(10, "a");
Console.WriteLine(res);

// тоже через цикл for

string Metod4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i<count; i++)
        result = result + text;
    return result;
}
string res = Metod4(10, "a");
Console.WriteLine(res);

//есть еще циклы с постусловиеь do while, те сначала сделали потом проверили условие 

//Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

//можно с помощью такой конструкции например построить таблицу умножения

// Задача
// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s =  “qwerty”
//              012345    То есть «q» — это 0, «w» — 1, «e» — 2 и так далее.
// Чтобы получить конкретный символ, мы можем через квадратные скобки обратиться, указать
// идентификатор строки. 
// Например: s[3] // будет соответствовать r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;   // создали пустую строку
    int length = text Length;       // определили длинну текста
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{str[i]}";
    }
    return result;
}

string newText = replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText = replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

string newText = replace(text, 'С', 'с');
Console.WriteLine(newText);
*/
// Программа сортировки массива
// Было: 6 8 3 2 1 4 5 7
// Результат: 1 2 3 4 5 6 7 8
// в то же время они могут быть выражены тремя пунктами.
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) // метод выведет массив на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array) //метод сортировки массива от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;           
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void selectionSort2(int[] array) //Разворот массива
{
    int j = array.Length;
    for (int i = 0; i < j / 2; i++)
    {
      int temporary = array[i];
      array[i] = array[j - 1];
      array[j - 1] = temporary;
       j--;
    }
}

PrintArray(arr);    //данный вызов метода вывода массива нам покажет первичный массив
selectionSort(arr); //данный вызов метода отсортирует массив и вернет его в новом виде
PrintArray(arr);    //данный вызов метода вывода массива нам покажет массив после сортировки
selectionSort2(arr);
PrintArray(arr);
