// Программа просмотра информации о файлах каталога

void CatalogInfo(string path, string indent = "")
// метод CatalogInfo, path - первый аргумент, путь к папке; indent - 2й аргумент визуализации структуры каталога
{
    DirectoryInfo catalogs = new DirectoryInfo(path); // получаем информацию о каталоге, в который зашли
    foreach (var currentCatalog in catalogs.GetDirectories()) // получаем массив всех файлов в этого каталога
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}"); // выводим информацию о текущей каталоге
        CatalogInfo(currentCatalog.FullName, indent + " "); // рекурсивно просматриваем все каталоги
    }
    foreach (var item in catalogs.GetFiles()) // просматриваем все файлы каталогов
    {
        Console.WriteLine($"{indent}{item.Name}"); // выводим на экран всефайлы каталогов
    }
}
string path = "D:/GB/Examples/Example023_DirInfo"; // переменной path присваиваем путь к каталогу
CatalogInfo(path); // вызов метода CatalogInfo