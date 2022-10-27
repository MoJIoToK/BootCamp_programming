int[] array = { 2, 3, 5, 0, 3 };
int[] res = QuickSortt(array, 0, array.Length-1);
Console.Write($"Отсортированный массив {string.Join(", ", res)}");

int[] QuickSortt(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSortt(inputArray, minIndex, pivot - 1); // сортируем левый подмассива
    QuickSortt(inputArray, pivot + 1, maxIndex); // сортируем правый подмассива
    return inputArray;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++) // -1 потому что крайний элемент опорный
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex); //ref - нужен для того чтобы числа передаваемые в функцию менялись как в функции, так и вне её. Он нужен именно для чисел
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}