Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
<<<<<<< HEAD
if (username.ToLower() == "Маша") // переводим все символы в вашей строкев нижний регистр
=======
if (username.ToLower() == "маша") // переводим все символы в вашей строкев нижний регистр
>>>>>>> 33715d28dd050c26c9865a10b6273814a14b3192
{
Console.WriteLine("Ура, это же Маша!");
}
else
{
Console.Write("Привет, ");
}
Console.Write(username);
