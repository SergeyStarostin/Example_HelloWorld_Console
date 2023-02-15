//Программа вывода номера индекса массива, в которой есть 4

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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Если нет в массиве четверки - возвращается -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10]; // Создали новый массив, в котором будет 10 элементов (по умолчанию он наполнен нулями)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // Поиск элемента с названием 4
Console.Write("Позиция индекса => ");
Console.WriteLine(pos);