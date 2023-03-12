// Обход разных структур
// Решение некоторых задач
// 4-2*1+3/10


string emp = String.Empty; // незаполненный элемент массива
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                 0    1    2     3    4    5    6    7    8    9    10   11

void InOrderTraversal(int pos = 1) // Метод обхода структуры с аргументом = 1
{
    if (pos < tree.Length)
    {
    int left = 2 * pos; // элемент позиции слева
    int right = 2 * pos + 1; // элемент позиции справа
    if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    // проверка, если левое поддерево имеется и тот элемент, который там хранится не является пустым
    // то в этом случае нужно рекурсивно запустить обход того дерева с текущей позиции (left)
    Console.Write(tree[pos]); // выводим на экран значение операции или числа
    if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    // проверка, если правое поддерево имеется и тот элемент, который там хранится не является пустым
    // то в этом случае нужно рекурсивно запустить обход того дерева с текущей позиции (right)
    }
}
InOrderTraversal();