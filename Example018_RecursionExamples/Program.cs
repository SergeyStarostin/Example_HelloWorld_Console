// Собрать строку с числами от A до B, A<=B

Console.WriteLine("Числа по возрастанию");

string NumbersFor1 (int a1, int b1) // Итеральный метод решения
{
    string result = String.Empty;
    for (int i = a1; i <= b1; i++)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor1(1, 10));

string NumbersRec1 (int a2, int b2) // Метод решения с помощью рекурсии
{
    if ( a2 <= b2) return $"{a2} " + NumbersRec1(a2 + 1, b2);
    else return String.Empty;
}

Console.WriteLine(NumbersRec1(1, 10));

// Собрать строку с числами от A до B, A>=B

Console.WriteLine("Числа по убыванию");

string NumbersFor (int a3, int b3) // Итеральный метод решения
{
    string result = String.Empty;
    for (int i = b3; i >= a3; i--)
    {
        result += $"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1, 10));

string NumbersRec2 (int a4, int b4) // Метод решения с помощью рекурсии
{
    if ( a4 <= b4) return NumbersRec2(a4 + 1, b4) + $"{a4} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec2(1, 10));