﻿// Дан текст. В тексте нужно все черточки заменить пробелами,
// маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

string text = "_-Я думаю,-_-сказал-князь,-улыбаясь,-_-что,-"
            + "ежели-бы-вас-послали-вместо-нашего-милого-Винценгероде,-"
            + "вы-бы-взяли-приступом-согласие-прусского-короля.-"
            + "Вы-так-красноречивы.-Вы-дадите-мне-чаю?";

//             012345
// string s = "qwerty"
// s[3] // r

string Replace (string text, char oldValue, char newValue) 
//метод Replace возвращает текст, на входе сам текст, 
//символы которые меняем и символы на которые меняем
{
    string result = String.Empty; //инициализация пустой строки

    int lenght = text.Length; //получаем длину строки с помощью встроенного метода
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";//
        //если символ text[i] совпал с oldValue, то этот символ меняем на newValue
        else
        {
            result = result + $"{text[i]}";
            //если совпадения не обнаружено, то в result добавляем текущий символ text[i]
        }
    }
    return result; // возвращаем результат
}

string newText = Replace(text, '-', ' '); 
//присваиваем переменной newText с помощью метода Replace (первоначальный текст, что меняем, на что меняем)
newText = Replace(newText, 'к', 'К'); //замена в тексте символов 'к' на 'К'
newText = Replace(newText, 'С', 'с'); //замена в тексте символов 'С' на 'с'
Console.WriteLine(newText); // вывод на экрам измененный текст