void FillArray (int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection [index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col) // Метод void не возвращает значения
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int [10]; // Создали новый массив, в котором будет 10 элементов (по умолчанию он наполнен нулями)

FillArray(array);
PrintArray(array);