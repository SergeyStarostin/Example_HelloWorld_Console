// Вычисление числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int InputInt(string Number) // Метод ввода массива
{
    Console.WriteLine(Number);
    return Convert.ToInt32(Console.ReadLine());
}

int Fibonacci (int Number) // Метод вычисления чисел Фибоначчи
{
    if(Number == 1 || Number == 2) return 1;
    else return (Fibonacci (Number - 1)) + (Fibonacci (Number - 2));
}

int Number = InputInt($"Введите число n: "); // Ввод числа n 
Console.WriteLine($"Ряд чисел Фибоначчи: ");

for (int i = 1; i < Number; i++)
{
    Console.WriteLine(Fibonacci(i)); // Вывод ряда чисел Фибоначчи
}