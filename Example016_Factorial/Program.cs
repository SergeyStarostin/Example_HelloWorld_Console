// Вычисление факториала числа N с помощью рекурсии.

int Number = InputInt("Введите число N: ");

int InputInt(string Number) // Метод ввода массива
{
    Console.WriteLine(Number);
    return Convert.ToInt32(Console.ReadLine());
}

double Factorial (int N)
{
    if(N == 1) return 1;
    else return N * Factorial(N - 1);
}

for (int i = 1; i < Number; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}