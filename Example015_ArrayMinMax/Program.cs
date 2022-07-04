// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int[] arr = { 1, 4, 9, 2, 8, 3, 7, 5, 6 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPositioin = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPositioin])
            {
                minPositioin = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPositioin];
        array[minPositioin] = temporary;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPositioin = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[maxPositioin])
            {
                maxPositioin = j;
            }
        }

        int temporary = array[i];
        array[i] = array[maxPositioin];
        array[maxPositioin] = temporary;
    }
}

PrintArray(arr);

SelectionSortMin(arr);
PrintArray(arr);

SelectionSortMax(arr);
PrintArray(arr);