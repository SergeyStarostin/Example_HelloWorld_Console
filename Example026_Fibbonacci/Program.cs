// Вычисления числа Фибоначчи итеративным и рекурсионным способами

decimal fIte = 0; // переменная для подсчета итераций цикла

decimal FibonacciIteration(int n) // метод вычисления числа Фибоначчи итеративным способом
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

decimal fRec = 0; // переменная для подсчета вызовов рекурсии

decimal FibonacciRecursion (int n)  // метод вычисления числа Фибоначчи рекурсивным способом
{
    fRec++;
    //return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion (n - 2);
    if (n == 0 || n == 1) return 1;
    else return FibonacciRecursion(n - 1) + FibonacciRecursion (n - 2);
}

DateTime dt = DateTime.Now;
for (int n = 1; n < 30; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte}");
    fIte = 0; 
}
Console.WriteLine("Время выполнения итеративного метода, в мс");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();

dt = DateTime.Now;
for (int n = 1; n < 30; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), - 15}");
    fRec = 0;
}
Console.WriteLine("Время выполнения рекурсивного метода, в мс");
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);