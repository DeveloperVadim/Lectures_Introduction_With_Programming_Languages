// Вид 1 Метод не принимает и не возвращает аргументы

void Method1() // Объявление метода
{
    Console.WriteLine("Автор Котов В.Л."); // операторы
}
Method1(); // вызов метода
Console.WriteLine();


// Вид 2 Метод принимает но не возвращает аргументы

void Method2(string msg) // принимает аргументы
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
Console.WriteLine();

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2_1("Текст сообщения 2_1", 3); // не именнованные аргументы указывать по порядку
Method2_1(msg: "Текст", count: 2); // именнованые аргументы
Method2_1(count: 1, msg: "Новый текст"); // инменнованые аргументы не обязательно записывать по порядку
Console.WriteLine();



// Вид 3 Метод не принимает но возвращает аргументы

int Method3()
{
    return DateTime.Now.Year;  // оператор
}
int year = Method3();  // место возвращения метода
Console.WriteLine(year);
Console.WriteLine();



// Вид 4 Метод принимает и возвращает аргументы

string Method4(int count, string text) // принимает аргументы
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Метод4 ");  // место возвращения метода
Console.WriteLine(res);
Console.WriteLine();