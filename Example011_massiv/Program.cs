/* Массивы 
Тип данных[] имя = {Значение1, Значение2, ....}
int[] array = {9,4,45,5,64564,22}

int[] array = {0,0,0,0,0,0}
int[] array = new int[5];
int[] array = new int[]{0,0,0,0,0}
int[] array = new int[5]{1,2,0,3,5}
*/

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = {11,12,12,12,12,54,668,99,638};

//А можно так...
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);