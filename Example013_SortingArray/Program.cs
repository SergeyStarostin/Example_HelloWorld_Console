// Упорядочить массив.
// Было:  6 8 3 2 1 4 5 7 
// Стало: 1 2 3 4 5 6 7 8

int [] array = {6, 8, 3, 2, 1, 4, 5, 7, 8, 1}; // присвоение массива

void PrintArray (int [] array) // метод вывода на экран массива
{
    int count = array.Length; // присвоение переменной значение равное длине массива
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //вывод на экран массив
    }
    Console.WriteLine(" ");
}

void SelectionSortMin (int [] array)//метод, для упорядочивания массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;//присвоение переменной минимального значения
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;// поиск минимального значения массива
        }
        int temporary = array[i]; //временная переменная
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        }
}

void SelectionSortMax (int [] array)//метод, для упорядочивания массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;//присвоение переменной минимального значения
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[minPosition]) minPosition = j;// поиск минимального значения массива
        }
        int temporary = array[i]; //временная переменная
        array[i] = array[minPosition];
        array[minPosition] = temporary;
        }
}

System.Console.WriteLine($"Массив: ");
PrintArray(array);
SelectionSortMin (array);
System.Console.WriteLine($"Массив от min к max:");
PrintArray(array);
SelectionSortMax (array);
System.Console.WriteLine($"Массив от max к min:");
PrintArray(array);


