// Факториал числа N

int FactorialFor(int n)
{
 int result = 1;
 for (int i = 1; i <= n; i++) result *= i;
 return result;
}

System.Console.WriteLine(FactorialFor(5));

int FactorialRec(int n)
{
 if (n == 0) return 1;
 else return n * FactorialRec(n - 1);
}
System.Console.WriteLine(FactorialRec(5));