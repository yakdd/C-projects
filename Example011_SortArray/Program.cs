// int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
// int[] array = { 0, 8, 4, 7, 6, 5, 0, 7, 12, 4, 3, 2, 1 };

int[] FillArray(int count)
{
    int[] createArray = new int[count];

    for (int i = 0; i < count; i++)
    {
        createArray[i] = new Random().Next(0, 100);
    }

    return createArray;
}


int[] SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int beginPosition = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                int temp = arr[i];
                arr[beginPosition] = arr[j];
                arr[j] = temp;
            }
        }
    }

    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}



int[] array = FillArray(10);
PrintArray(array);
Console.WriteLine();

SortArray(array);
PrintArray(array);
