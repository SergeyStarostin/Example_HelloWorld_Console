Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "Маша") // переводим все символы в вашей строкев нижний регистр
{
Console.WriteLine("Ура, это же Маша!");
}
else
{
Console.Write("Привет, ");
}
Console.Write(username);
