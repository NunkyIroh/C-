Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "анастасия")
{
    Console.WriteLine("Привет самая лучшая девушка на свете!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}