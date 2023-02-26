//string[,] table = new string[3, 4];
//String.Empty - инициализация строк
//table[0, 0] table[0, 1] table[0, 2] table[0, 3]
//table[1, 0] table[1, 1] table[1, 2] table[1, 3]
//table[2, 0] table[2, 1] table[2, 2] table[2, 3]

void PrintArray(int[,] matrix) //метод вывода на экран массива
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)//цикл перебора строк (3 строки)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++) //цикл перебора столбцов от 0-3 (4 столбца)
        {
            Console.Write($" {matrix[rows, columns]} ");
        }
    Console.WriteLine(" "); //для разделения строк и столбцов
    }
}

void FillArray(int[,] matrix)  //метод, который будет заполнять матрицу случайными числами
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)//цикл перебора строк (3 строки)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++) //цикл перебора столбцов от 0-3 (4 столбца)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4]; //инициализация массива

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(" "); //для разделения строк и столбцов
PrintArray(matrix);