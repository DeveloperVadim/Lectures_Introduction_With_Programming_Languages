Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // ToLower преобразует заглавные символы в строчные
{
    Console.WriteLine("Попутного тебе ветра в сраку! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}