// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

void PrintArray(int[] array) // Метод вывода на экран
{
    int count = array.Length; // Получение количества элементов
    for (int i = 0; i < count; i++) // Проходим по элементам
    {
        Console.Write($"{array[i]}"); // Выводим на экран
    }
    Console.WriteLine(); // Пустая строка
}
void SelectionSort(int[] array) // Метод упорядочивающий массив
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // Определяем позицию на которую смотрим
        for (int j = i + 1; j < array.Length; j++) 
        {
            if (array[j] < array[minPosition]) // Ищем позицию минимального элемента
            {
                minPosition = j;
            }
        }
        int temporary = array[i]; // Запоминаем позицию рабочего элемента
        array[i] = array[minPosition]; // Ложим найденый в цикле элемент
        array[minPosition] = temporary;
    }
}

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // Вводные данные
PrintArray(arr); // Запустили метод PrintArray к arr (вводный массив)
SelectionSort(arr); // Запустили метод упорядочивания
PrintArray(arr);