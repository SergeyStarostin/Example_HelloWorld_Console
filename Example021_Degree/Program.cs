// Вычислить A в степени n

int PowerFor(int a, int n)  // Итеральный метод решения
{ int result = 1;
 for (int i = 1; i <= n; i++) result *= a;
 return result;
}

Console.WriteLine($"Итеральный метод решения: {PowerFor(2, 10)}");

int PowerRec(int a, int n)  // Метод решения с помощью рекурсии
{ //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
}

Console.WriteLine($"Решение с помощью рекурсии: {PowerRec(2, 10)}");