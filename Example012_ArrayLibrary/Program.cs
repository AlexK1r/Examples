//Функция заполнения массива
void FillArray(int[] collection)  //определяем функцию где аргумент это массив collection (функция ничего не возвращает)
{
    int length = collection.Length; //определим длинну массива
    int index = 0;
    while (index < length)  //пока не достигним максимального размера массива
    {
        collection[index] = new Random().Next(1,10); //добавляем в массив рандомное число из диапазона 1,10
        index++;
    }

}

//Функция вывод на экран
void PrintArray(int[] col) //определяем функию где  аргумент это массив col (функция ничего не возвращает)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

//Функция поиска позиции элемента в массиве
int IndexPositional(int[] collection, int find) //определяем функцию где аргументы это массив collection и find
{
    int length = collection.Length;             //определим длинну массива
    int index = 0;
    int positional = -1;                        // -1 ставим специально чтобы определить, что искомого значения в массиве нет 
    while (index < length)                      //пока не достигним максимального размера массива
    {
        if (collection[index] == find)          //перебираем пока элемент массива не будет равен find
        {
            positional = index;
            break;
        }
        index++;
    }
    return positional;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = IndexPositional(array, 4);

Console.WriteLine(pos);