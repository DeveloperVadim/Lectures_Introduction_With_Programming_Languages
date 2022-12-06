// Цикл For

string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++) // (инициализация счетчика; проверка условия; увеличение счетчика (инкримент))
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Метод4 ");
// Console.WriteLine(res);
Console.WriteLine();



// Цикл в цикле For

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j} "); // интерполяция строк
    }
    Console.WriteLine(); // разделяем циклы пустой строкой
}

Console.WriteLine();