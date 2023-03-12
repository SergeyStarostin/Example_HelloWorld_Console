// Игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// 1-й шпиль (откуда берем блинчик); 3-й шпиль (на котором пирамидка должна оказаться); 
// 2-й шпиль промежуточный; count - количество блинчиков
{
    if (count > 1) Towers(with, some, on, count - 1); 
    // рекурсивно перекладываем блинчики "count - 1" раз
        Console.WriteLine($"{with} >> {on}"); 
        // выводим на экран каждое действие (откуда - куда перемещаем блинчик)
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();