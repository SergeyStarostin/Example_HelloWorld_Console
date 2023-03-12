// Сумма чисел от 1 до n

Console.WriteLine("Сумма чисел от 1 до n");

int SumFor (int n1) // Итеральный метод решения
{
    int result = 0;
    for (int i = 1; i <= n1; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine(SumFor(10));

int SumRec (int n2) // Метод решения с помощью рекурсии
{
    if ( n2 == 0) return 0;
    else return n2 + SumRec(n2 - 1);
}

Console.WriteLine(SumRec(10));