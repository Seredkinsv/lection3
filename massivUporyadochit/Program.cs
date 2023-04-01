// сортировка чисел внутри массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
//выводим массив на экран
void PrintArray(int[] array)
{
    // получение кол-ва элементов
    int count = array.Length;
    //цикл в котором мы пробегаем по всем элементам массива и показываем на экране
for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]}");
}
//выводим пустую строчку
Console.WriteLine();
}
// пишем метод упорядующий массив

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        //определяем позицию на которую смотрим
        int minPosition = i;
        //ищем минимальный элемент
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        //
        // после того как выполним блок кода, меняем значение минимальной позиции с значением которое нашли
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;


    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);