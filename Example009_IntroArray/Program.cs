// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
void FillArray(int[] collection)    // void - метод (функция), который ничего не возвращает
{                                   // также называется процедурой
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{coll[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int posFind = -1;   // в случае отсутсвия икомого элемента в массиве выдаст -1.
    while (index < length)
    {
        if (collection[index] == find)
        {
            posFind = index;
            break;
        }
        index++;
    }
    return posFind;
}

int[] array = new int[10]; // создать новый массив с 10 элементами по-умолчанию

FillArray(array);
PrintArray(array);
Console.WriteLine();
// Console.WriteLine(array);

int pos = IndexOf(array, 15);
Console.WriteLine(pos);
